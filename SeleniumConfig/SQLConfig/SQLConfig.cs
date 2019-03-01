using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using GisqRealEstate.ProDataSource;
using SeleniumConfig.CommonClass;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.SQLConfig
{
    public class SqlConfig
    {
        public static String MsqlConfigXmlPath = AppDomain.CurrentDomain.BaseDirectory + @"\SQLConfig.xml";


        /// <summary>
        /// 加载sql配置方案树
        /// </summary>
        /// <param name="tree"></param>
        public static void LoadSqlSchema(AdvTree tree,String selectValue)
        {
            tree.Nodes.Clear();
            Node nodeRoot=new Node();
            nodeRoot.Name = "ROOT_" + Guid.NewGuid().ToString();
            nodeRoot.Text = "所有SQL方案";
            nodeRoot.Expanded = true;
            tree.Nodes.Add(nodeRoot);

            XmlDocument doc=new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            List<XmlNode>
                nodeList = doc.SelectNodes("//SqlSchema").ToList<XmlNode>();

            foreach (XmlNode node in nodeList)
            {
                String id = node.Attributes["ID"].Value;
                String name = node.Attributes["Name"].Value;
                SqlSchemaEntity sqlSchemaEntity=new SqlSchemaEntity();
                sqlSchemaEntity.ID = id;
                sqlSchemaEntity.Name = name;
                Node nodeChild=new Node();
                nodeChild.Name = "SCHEMA_" + id;
                nodeChild.Text = name;
                nodeChild.Tag = sqlSchemaEntity;
                nodeRoot.Nodes.Add(nodeChild);

                if (selectValue.Equals(id))
                {
                    tree.SelectNode(nodeChild,eTreeAction.Mouse);
                }
            }
        }


        /// <summary>
        /// 把表控件信息加载到Combobox
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static void LoadTableSspacesToTree(AdvTree tree)
        {
            Node nodeParent = new Node();
            nodeParent.Name = "ROOT_"+Guid.NewGuid().ToString();
            nodeParent.Text = @"所有表信息";
            tree.Nodes.Add(nodeParent);
            nodeParent.Expanded = true;

            DataTable dt = GetAllTableSpaces();
            dt.AsEnumerable().ToList().ForEach(p =>
            {
                Node nodeChild =new Node();
                nodeChild.Name = "TABLESPACE_" + p["TABLESPACE_NAME"];
                nodeChild.Text = p["TABLESPACE_NAME"].ToString();
                nodeParent.Nodes.Add(nodeChild);
            });
        }

        /// <summary>
        /// 获取所有表空间信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllTableSpaces()
        {
            String sql = @"select tablespace_name from user_tablespaces where contents='PERMANENT'
                        order by tablespace_name";
            DataTable dataTable = StaticValue.MObjDataSource.ExecuteDataTable(sql);
            return dataTable;
        }


        /// <summary>
        /// 把表数据加载到ComboBox
        /// </summary>
        /// <param name="tableSpaceName"></param>
        /// <param name="comboBox"></param>
        public static void LoadTablesToTree(String tableSpaceName, Node nodeParent)
        {
            nodeParent.Expanded = true;
            DataTable dtValue = GetAllTables(tableSpaceName);
            dtValue.AsEnumerable().ToList().ForEach(p =>
            {
                TableEntity tableEntity=new TableEntity();
                tableEntity.TableName = p["TABLE_NAME"].ToString();
                tableEntity.Comments = p["COMMENTS"].ToString();
                tableEntity.TableSpaceName = tableSpaceName;
                Node nodeChild = new Node();
                nodeChild.Name = "TABLE_" + tableEntity.TableName;
                nodeChild.Text = tableEntity.TableName + "(" + (tableEntity.Comments == "" ? "未说明" : tableEntity.Comments) + ")";
                nodeChild.Tag = tableEntity;
                nodeParent.Nodes.Add(nodeChild);
            });
        }

        /// <summary>
        /// 获取指定表空间下所有表的信息
        /// </summary>
        /// <param name="tableSpaceName"></param>
        /// <returns></returns>
        public static DataTable GetAllTables(String tableSpaceName)
        {
            String sql = string.Format(@"select table_name,comments from all_tab_comments
                 where  owner='{0}'
                and table_name not like 'GDB%' and table_name not like 'KEYSET%'
                and table_name not like 'DR$%' 
                and table_name not like 'SMP%' 
                and table_name not like 'SRC%'  and table_name not like '%A' and table_name not like '%MODIFIED'
                and table_name not like 'GEOMETRY%'
                and table_name not in ('COMPRESS_LOG','COLUMN_REGISTRY','GCDRULES')
                and not regexp_like(replace(table_name,'A',''),'^[[:digit:]]+$')
                and not regexp_like(replace(table_name,'D',''),'^[[:digit:]]+$')
                and not regexp_like(replace(table_name,'F',''),'^[[:digit:]]+$')
                and not regexp_like(replace(table_name,'S',''),'^[[:digit:]]+$')
                order by table_name
                ", tableSpaceName);
            DataTable dataTable = StaticValue.MObjDataSource.ExecuteDataTable(sql);
            return dataTable;
        }

        public static void LoadColumnToDgv(String sqlSchemaId, String tableSpaceName, String tableName,
            DataGridView dgvColumns)
        {
            DataTable dt = SqlConfig.GetAllColumnsByTableName(tableSpaceName, tableName);
            
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeTable =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/Table[@ID='" + tableName +
                                     "' and @TableSpace='" + tableSpaceName + "']");
            if (nodeTable != null)
            {
                List<XmlNode> nodeColumnList = nodeTable.ChildNodes.ToList<XmlNode>();
                var dsList = dt.AsEnumerable();
                nodeColumnList.ForEach(p =>
                {
                    DataRow dr = dsList.FirstOrDefault(t => t["COLUMN_NAME"].ToString().Equals(p.Attributes["ID"].Value));
                    if (dr != null)
                    {
                        dr["FZ"] = p.InnerText;
                    }
                });

            }

            dgvColumns.DataSource = dt;
            dgvColumns.Rows.ToList<DataGridViewRow>().ForEach(p =>
            {

                if (p.Cells["COLUMN_NAME"].Value.ToString().Equals("BSM")
                    || p.Cells["COLUMN_NAME"].Value.ToString().Equals("REV_")
                    || p.Cells["COLUMN_NAME"].Value.ToString().Equals("GXSJ"))
                {
                    p.Cells["FZ"].ReadOnly = true;
                }
            });


        }

        /// <summary>
        /// 获取指定表下的所有字段信息
        /// </summary>
        /// <param name="tableSpaceName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DataTable GetAllColumnsByTableName(String tableSpaceName,String tableName)
        {
            String sql = string.Format(@"select a.COLUMN_NAME,a.DATA_TYPE ||'(' || a.DATA_LENGTH || case when nvl(a.DATA_SCALE,0)=0 then ')' else ',' ||a.DATA_SCALE||')' end DATA_TYPE, 
b.COMMENTS,case when a.COLUMN_NAME='REV_' then '1' when a.COLUMN_NAME='GXSJ' then '#SYSDATE#'  when a.COLUMN_NAME='BSM' then '#SEQ_BSM#' else '' end as FZ,a.data_type as DATA_TYPE_SJ,a.data_length,a.data_scale from all_tab_cols a
inner join all_col_comments b on a.table_name=b.table_name and a.column_name=b.column_name and a.owner=b.OWNER
where a.owner='{0}' and a.table_name='{1}'     AND A.COLUMN_ID=1
UNION ALL  
select * from (
select a.COLUMN_NAME,a.DATA_TYPE ||'(' || a.DATA_LENGTH || case when nvl(a.DATA_SCALE,0)=0 then ')' else ',' ||a.DATA_SCALE||')' end DATA_TYPE, 
b.COMMENTS,case when a.COLUMN_NAME='REV_' then '1' when a.COLUMN_NAME='GXSJ' then '#SYSDATE#'   when a.COLUMN_NAME='BSM' then '#SEQ_BSM#' else '' end as FZ,a.data_type as DATA_TYPE_SJ,a.data_length,a.data_scale from all_tab_cols a
inner join all_col_comments b on a.table_name=b.table_name and a.column_name=b.column_name and a.owner=b.OWNER
where a.owner='{0}' and a.table_name='{1}'     AND A.COLUMN_ID>1
order by a.COLUMN_NAME)
 ", tableSpaceName, tableName);
            DataTable dataTable = StaticValue.MObjDataSource.ExecuteDataTable(sql);
            
            
            return dataTable;
        }




        /// <summary>
        /// 加载方案下的表信息
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        public static void LoadSchemaTables(String sqlSchemaId,DataGridView dgv)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            LoadSchemaTables(doc,sqlSchemaId,dgv);

        }

        public static void LoadSchemaTables(XmlDocument doc, String sqlSchemaId,DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataTable dt = LoadSchemaTable(sqlSchemaId, doc);
            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Rows[0].Selected = false;
                dgv.CurrentCell = null;
            }

            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                if (dgvRow.Cells["TABLEHAVECOLUMN"].Value.ToString().Equals("true"))
                {
                    dgvRow.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public static DataTable LoadSchemaTable(String sqlSchemaId)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            return LoadSchemaTable(sqlSchemaId, doc);
        }

        public static DataTable LoadSchemaTable(String sqlSchemaId,XmlDocument doc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TABLEID");
            dt.Columns.Add("TABLENAME");
            dt.Columns.Add("TABLESPACENAME");
            dt.Columns.Add("TABLEHAVECOLUMN");
            var ele = doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']");
            if (ele != null)
            {
                List<XmlNode> xmlNodeList
                   = ele.ChildNodes.ToList<XmlNode>();
              
                xmlNodeList.ForEach(p =>
                {
                    if (!p.LocalName.Equals("TableRelation"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["TABLEID"] = p.Attributes["ID"].Value;
                        dr["TABLENAME"] = p.Attributes["ID"].Value + "(" +
                                          (String.IsNullOrEmpty(p.Attributes["Name"].Value.ToString())
                                              ? "未说明"
                                              : p.Attributes["Name"].Value.ToString()) + ")";
                        dr["TABLESPACENAME"] = p.Attributes["TableSpace"] == null ? "" : p.Attributes["TableSpace"].Value;
                        if (p.HasChildNodes)
                        {
                            dr["TABLEHAVECOLUMN"] = "true";
                        }
                        else
                        {
                            dr["TABLEHAVECOLUMN"] = "false";
                        }
                        dt.Rows.Add(dr);
                    }

                });
            }
            return dt;
        }

        /// <summary>
        /// 获取已经设置的字段信息
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableSpaceName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DataTable LoadSchemaTableColumns(String sqlSchemaId,String tableSpaceName,String tableName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeTable = doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/Table[@ID='" + tableName + "' and @TableSpace='" + tableSpaceName + "']");
            DataTable dt=new DataTable();
            dt.Columns.Add("ColumnName");
            dt.Columns.Add("ColumnComments");
            if (nodeTable != null)
            {
                List<XmlNode> nodeColumnList
                    = nodeTable.ChildNodes.ToList<XmlNode>();
                nodeColumnList.ForEach(p =>
                {
                    DataRow dr = dt.NewRow();
                    dr["ColumnName"] = p.Attributes["ID"].Value;
                    dr["ColumnComments"] = p.Attributes["Name"].Value;
                    dt.Rows.Add(dr);
                });
            }
            return dt;
        }


        #region 校验录入数据是否合格
        /// <summary>
        /// 检验录入数据是都符合标准
        /// </summary>
        /// <param name="dgvRow"></param>
        /// <returns></returns>
        public static String verifyData(DataGridViewRow dgvRow)
        {
            String colunName = dgvRow.Cells["COLUMN_NAME"].Value.ToString();
            String value = dgvRow.Cells["FZ"].Value.ToString();
            String dataType = dgvRow.Cells["DATA_TYPE_SJ"].Value.ToString();
            String dataLength = dgvRow.Cells["DATA_LENGTH"].Value.ToString();
            String dataScale = dgvRow.Cells["DATA_SCALE"].Value.ToString();
            if (dataType.Equals("VARCHAR2") || dataType.Equals("NVARCHAR2"))
            {
                if (
                    value !="#WBDCDYH#" && value !="#FBDCDYH#" && value!="#LBDCDYH#" &&
                        value!="#DJQDM#" && value!="#DJQZH#" 
                        && value!="#LZDYH#" && value!="#FZDYH#" && value!="#ZDDM#"
                    && value!="#ZDSYQLX#" && value!="#ZDTZM#" 
                    && value != "#WDZWTZM#"
                    && value != "#FDZWTZM#"
                    && value != "#LDZWTZM#"
                    && value!="#ZSXH#" && value!="#DZWSXH#" && value!="#QXDM#")
                {
                    if (!IsStringOverflow(value, Convert.ToInt32(dataLength)))
                    {
                        return string.Format("字段({0})对应的值({1})长度({2})太长，超过指定长度！", colunName, value, value.Length);
                    }
                }
            }
            else if (dataType.Equals("DATE"))
            {
                if (value != "#SYSDATE#")
                {
                    if (!DataVerify.IsDate(value))
                    {
                        return string.Format("字段({0})对应的值({1})不是有效的日期格式！", colunName, value);
                    }
                }
            }
            else if (dataType.Equals("NUMBER"))
            {
                if (value != "#SEQ_BSM#" && value != "#DJQZH#" && value != "#ZSXH#" && value != "#DZWSXH#" && value != "#QXDM#")
                {
                    if (!IsNumeric(value))
                    {
                        return string.Format("字段({0})对应的值({1})不是数字！", colunName, value);
                    }

                    int precision = Convert.ToInt32(dataLength);
                    int scale = Convert.ToInt32(String.IsNullOrEmpty(dataScale) ? "0" : dataScale);

                    if (scale == 0)
                    {
                        if (!IsInt(value))
                        {
                            return string.Format("字段({0})对应的值({1})不是整数！", colunName, value);
                        }
                    }

                    if (!IsNumber(Convert.ToInt32(value.Split('.')[0]).ToString(), precision, scale, true))
                    {
                        return string.Format("字段({0})对应的值({1})整数部分超出长度！", colunName, value);
                    }

                    if (!IsNumber(value, precision, scale, false))
                    {
                        return string.Format("字段({0})对应的值({1})小数部分超出长度！", colunName, value);
                    }
                }

                
            }
            return "";

        }
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        public static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
        /// <summary>
        /// 判断字符串是否超出长度
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool IsStringOverflow(String value,int length)
        {
            return value.Length <= length;
        }

        public static bool IsNumber(string s, int precision, int scale,bool isInteger)
        {
            if ((precision == 0) && (scale == 0))
            {
                return false;
            }
            string pattern = @"(^\d{1," + precision + "}";
            if (isInteger)
            {

            }
            else
            {
                if (scale > 0)
                {
                    pattern += @"\.\d{0," + scale + "}$)|" + pattern;
                }
            }
            pattern += "$)";
            return Regex.IsMatch(s, pattern);
        }

        #endregion

        /// <summary>
        /// 保存SQL方案
        /// </summary>
        /// <param name="sqlSchemaEntity"></param>
        public static void saveSqlSchema(SqlSchemaEntity sqlSchemaEntity)
        {
            XmlDocument doc=new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeRoot = doc.SelectSingleNode("Element");
            if (nodeRoot == null)
            {
                doc.AppendChild(doc.CreateElement("Element"));
            }

            XmlNode nodeSchema = nodeRoot.SelectSingleNode("SqlSchema[@ID='" + sqlSchemaEntity.ID + "']");
            if (nodeSchema == null)
            {
                nodeSchema = doc.CreateElement("SqlSchema");
                nodeRoot.AppendChild(nodeSchema);
            }

            XmlElement elementSchema  = nodeSchema as XmlElement;
            elementSchema.SetAttribute("ID", sqlSchemaEntity.ID);
            elementSchema.SetAttribute("Name", sqlSchemaEntity.Name);

            doc.Save(MsqlConfigXmlPath);
        }

        /// <summary>
        /// 添加已选中表信息
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableEntity"></param>
        public static void saveSchemaTable(String sqlSchemaId,TableEntity tableEntity,DataGridView dgv)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeRoot = doc.SelectSingleNode("Element");
            if (nodeRoot == null)
            {
                doc.AppendChild(doc.CreateElement("Element"));
            }

            XmlNode nodeSchema = nodeRoot.SelectSingleNode("SqlSchema[@ID='" + sqlSchemaId + "']");
            if (nodeSchema == null)
            {
                throw new Exception("请先添加方案！");
            }

            XmlNode nodeTable = nodeSchema.SelectSingleNode("Table[@ID='" + tableEntity.TableName + "']");
            if (nodeTable == null)
            {
                nodeTable = doc.CreateElement("Table");
                nodeSchema.AppendChild(nodeTable);
            }

            XmlElement elementTable =nodeTable as XmlElement;
            elementTable.SetAttribute("ID", tableEntity.TableName);
            elementTable.SetAttribute("Name", tableEntity.Comments);
            elementTable.SetAttribute("TableSpace", tableEntity.TableSpaceName);

            doc.Save(MsqlConfigXmlPath);
            LoadSchemaTables(doc,sqlSchemaId,dgv);
        }

        /// <summary>
        /// 保存字段录入信息
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableName"></param>
        /// <param name="sqlConfigEntities"></param>
        public static void saveSchemaColumnInfo(String sqlSchemaId, String  tableName,List<SQLConfigEntity> sqlConfigEntities )
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeTable =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/Table[@ID='" + tableName + "']");
            if(nodeTable==null)
                throw new Exception("请先配置表信息");

            //清空所有节点
            List<XmlNode> nodeChildList = nodeTable.ChildNodes.ToList<XmlNode>();
            foreach (XmlNode nodeChild in nodeChildList)
            {
                nodeChild.ParentNode.RemoveChild(nodeChild);
            }
            XmlElement nodeColumn = null;
            XmlCDataSection cDataSection = null;
            sqlConfigEntities.ForEach(p =>
            {
                nodeColumn = doc.CreateElement("Column");
                nodeColumn.SetAttribute("ID", p.ColumnName);
                nodeColumn.SetAttribute("Name", p.Comments);
                nodeColumn.SetAttribute("Type", p.ColumnType);
                nodeColumn.SetAttribute("Length", p.ColumnLength);
                nodeColumn.SetAttribute("Scale", p.ColumnScale);
                cDataSection = doc.CreateCDataSection(p.ColumnValue);
                nodeColumn.AppendChild(cDataSection);
                nodeTable.AppendChild(nodeColumn);
            });

            doc.Save(MsqlConfigXmlPath);
        }

        /// <summary>
        /// 删除方案配置的表信息
        /// </summary>
        public static bool deleteTable(String sqlSchemaId,String tableSpaceName,String tableName,DataGridView dgvTable,DataGridView dgvColumn)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeTable =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/Table[@ID='" + tableName + "' and @TableSpace='"+tableSpaceName+"']");

            if (nodeTable != null)
            {
                if (nodeTable.HasChildNodes)
                {
                    if (MessageBox.Show("当前表已经配置了字段信息，是否继续删除？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        DialogResult.Cancel)
                    {
                        return false;
                    }
                }

                XmlNode nodeTableRealtion
                    = nodeTable.ParentNode.SelectSingleNode("//TableRelation");
                if (nodeTableRealtion != null)
                {
                    List<XmlNode> nodeDetailRelation = nodeTableRealtion.ChildNodes.ToList<XmlNode>();
                    List<XmlNode> nodeHaveUserTableRelation
                        = nodeDetailRelation.Where(p =>
                            (p.Attributes["FTableName"].Value.Equals(tableName)
                            && p.Attributes["FTableSpaceName"].Value.Equals(tableSpaceName))
                            ||
                            (p.Attributes["LTableName"].Value.Equals(tableName)
                             && p.Attributes["LTableSpaceName"].Value.Equals(tableSpaceName))).ToList();
                    if (nodeHaveUserTableRelation.Count>0)
                    {
                        if (MessageBox.Show("当前表已经配置了关联信息，是否继续删除？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                      DialogResult.Cancel)
                        {
                            return false;
                        }
                        //删除关联关系节点
                        nodeHaveUserTableRelation.ForEach(p =>
                        {
                            p.ParentNode.RemoveChild(p);
                        });
                    }

                }

                nodeTable.ParentNode.RemoveChild(nodeTable);
                doc.Save(MsqlConfigXmlPath);
                LoadSchemaTables(doc,sqlSchemaId,dgvTable);
                LoadColumnToDgv("","", tableName, dgvColumn);
                return true;
            }
            return false;
        }

        #region 表关系建立信息查询
        /// <summary>
        /// 加载所有已选择的表空间
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="comboBoxEx"></param>
        /// <returns></returns>
        public static DataTable LoadHaveSelectTableSpace(String sqlSchemaId,ComboBoxEx comboBoxEx)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeSchema =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']");
            List<XmlNode> nodeTables
                = nodeSchema.ChildNodes.ToList<XmlNode>();
            nodeTables = nodeTables.Where(p => !p.LocalName.Equals("TableRelation")).ToList();
            nodeTables = nodeTables.Distinct(new Compare<XmlNode>(
                (x, y) => x.Attributes["TableSpace"].Value.ToString()
                .Equals(y.Attributes["TableSpace"].Value.ToString()))
                    ).ToList();
            nodeTables = nodeTables.OrderBy(p => p.Attributes["TableSpace"].Value.ToString()).ToList();
            DataTable dt=new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("VALUE");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            nodeTables.ForEach(p =>
            {
                DataRow dr = dt.NewRow();
                String tableSpaceName = p.Attributes["TableSpace"].Value.ToString();
                dr["NAME"] = tableSpaceName;
                dr["VALUE"] = tableSpaceName;
                dt.Rows.Add(dr);
            });
            comboBoxEx.DisplayMember = "NAME";
            comboBoxEx.ValueMember = "VALUE";
            comboBoxEx.DataSource = dt;
            return dt;
        }

        /// <summary>
        /// 加载指定表空间的下的所有已选择的表
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableSpaceName"></param>
        /// <param name="comboBoxEx"></param>
        /// <returns></returns>
        public static DataTable LoadHaveSelectTable(String sqlSchemaId,String tableSpaceName, ComboBoxEx comboBoxEx)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeSchema =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']");

            List<XmlNode> nodeTableList
                = nodeSchema.SelectNodes("Table[@TableSpace='" + tableSpaceName + "']").ToList<XmlNode>();
            nodeTableList = nodeTableList.OrderBy(p => p.Attributes["ID"].Value.ToString()).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("VALUE");
            dt.Rows.InsertAt(dt.NewRow(),0);
            nodeTableList.ForEach(p =>
            {
                DataRow dr = dt.NewRow();
                String tableName = p.Attributes["ID"].Value.ToString();
                dr["NAME"] = tableName;
                dr["VALUE"] = tableName;
                dt.Rows.Add(dr);
            });
            comboBoxEx.DisplayMember = "NAME";
            comboBoxEx.ValueMember = "VALUE";
            comboBoxEx.DataSource = dt;
            return dt;
        }

        /// <summary>
        /// 加载所有以选择的字段信息
        /// </summary>
        /// <param name="tableSpaceName"></param>
        /// <param name="tableName"></param>
        /// <param name="comboBoxEx"></param>
        public static void LoadHaveSelectColumn(String tableSpaceName, String tableName,ComboBoxEx comboBoxEx)
        {
            DataTable dt = GetAllColumnsByTableName(tableSpaceName, tableName);
            dt.Rows.InsertAt(dt.NewRow(),0);
            comboBoxEx.DisplayMember = "COLUMN_NAME";
            comboBoxEx.ValueMember = "COLUMN_NAME";
            comboBoxEx.DataSource = dt;
        }

        #endregion

        /// <summary>
        /// 保存方案表结构关系
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableRelationEntity"></param>
        public static void saveTableRelation(String sqlSchemaId, 
            TableRelationEntity tableRelationEntity,DataGridView dgv,String selectValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeSchema =
                doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']");

            XmlNode nodeTableRelation
                = nodeSchema.SelectSingleNode("TableRelation");
            if (nodeTableRelation == null)
            {
                nodeTableRelation = doc.CreateElement("TableRelation");
                nodeSchema.AppendChild(nodeTableRelation);
            }

            //删除所有节点重新建立关系
            XmlNode nodeTableRelationDetail
                = nodeTableRelation.SelectSingleNode("DetialRelation[@ID='" + tableRelationEntity.Id + "']");
            if (nodeTableRelationDetail != null)
                nodeTableRelationDetail.ParentNode.RemoveChild(nodeTableRelationDetail);

            nodeTableRelationDetail = doc.CreateElement("DetialRelation");
            nodeTableRelation.AppendChild(nodeTableRelationDetail);

            XmlElement elementTableRelationDetail = nodeTableRelationDetail as XmlElement;
            elementTableRelationDetail.SetAttribute("ID", tableRelationEntity.Id);
            elementTableRelationDetail.SetAttribute("FTableSpaceName", tableRelationEntity.FTableSpaceName);
            elementTableRelationDetail.SetAttribute("FTableName", tableRelationEntity.FTableName);
            elementTableRelationDetail.SetAttribute("FColumnName", tableRelationEntity.FColumnName);
            elementTableRelationDetail.SetAttribute("LTableSpaceName", tableRelationEntity.LTableSpaceName);
            elementTableRelationDetail.SetAttribute("LTableName", tableRelationEntity.LTableName);
            elementTableRelationDetail.SetAttribute("LColumnName", tableRelationEntity.LColumnName);
            XmlCDataSection cData
                = doc.CreateCDataSection(string.Format("{0}.{1}.{2}={3}.{4}.{5}",
                    tableRelationEntity.FTableSpaceName,
                    tableRelationEntity.FTableName,
                    tableRelationEntity.FColumnName,
                    tableRelationEntity.LTableSpaceName,
                    tableRelationEntity.LTableName,
                    tableRelationEntity.LColumnName));
            elementTableRelationDetail.AppendChild(cData);

            doc.Save(MsqlConfigXmlPath);

            LoadSchemaTableRelation(sqlSchemaId, doc, dgv, selectValue);
        }


        public static void LoadSchemaTableRelation(String sqlSchemaId, DataGridView dgv,String selectValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            LoadSchemaTableRelation(sqlSchemaId,doc, dgv,selectValue);
        }

        public static void LoadSchemaTableRelation(String sqlSchemaId,XmlDocument doc, DataGridView dgv,String selectValue)
        {
            XmlNode nodeTableRelation =
               doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/TableRelation");
            DataTable dt = new DataTable();
            dt.Columns.Add("TableRelationID");
            dt.Columns.Add("FTableSpaceName");
            dt.Columns.Add("FTableName");
            dt.Columns.Add("FColumnName");
            dt.Columns.Add("LTableSpaceName");
            dt.Columns.Add("LTableName");
            dt.Columns.Add("LColumnName");
            dt.Columns.Add("TableRelationValue");
            if (nodeTableRelation != null)
            {
                List<XmlNode> nodeTableRelationList
                    = nodeTableRelation.ChildNodes.ToList<XmlNode>();
                nodeTableRelationList.ForEach(p =>
                {
                    DataRow dr = dt.NewRow();
                    dr["TableRelationID"] = p.Attributes["ID"].Value;
                    dr["FTableSpaceName"] = p.Attributes["FTableSpaceName"].Value;
                    dr["FTableName"] = p.Attributes["FTableName"].Value;
                    dr["FColumnName"] = p.Attributes["FColumnName"].Value;
                    dr["LTableSpaceName"] = p.Attributes["LTableSpaceName"].Value;
                    dr["LTableName"] = p.Attributes["LTableName"].Value;
                    dr["LColumnName"] = p.Attributes["LColumnName"].Value;
                    dr["TableRelationValue"] = p.InnerText;
                    dt.Rows.Add(dr);
                });
            }

            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                if (!String.IsNullOrEmpty(selectValue))
                {
                    DataGridViewRow dgvRow
                        = dgv.Rows
                            .ToList<DataGridViewRow>()
                            .FirstOrDefault(p => p.Cells["TableRelationID"].Value.ToString().Equals(selectValue));
                    if (dgvRow != null)
                    {
                        dgvRow.Selected = true;
                        dgv.CurrentCell = dgvRow.Cells[0];
                    }
                }
                else
                {
                    dgv.Rows[0].Selected = false;
                    dgv.CurrentCell = null;
                }
               
            }
        }

        /// <summary>
        /// 删除关联关系信息
        /// </summary>
        /// <param name="sqlSchemaId"></param>
        /// <param name="tableRelationId"></param>
        /// <param name="dgv"></param>
        public static void deleteTableRelation(String sqlSchemaId, 
            String tableRelationId,DataGridView dgv)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MsqlConfigXmlPath);
            XmlNode nodeTableRelation =
             doc.SelectSingleNode("//SqlSchema[@ID='" + sqlSchemaId + "']/TableRelation/DetialRelation[@ID='"+tableRelationId+"']");
            if (nodeTableRelation != null)
            {
                nodeTableRelation.ParentNode.RemoveChild(nodeTableRelation);
            }
            doc.Save(MsqlConfigXmlPath);

            LoadSchemaTableRelation(sqlSchemaId,doc, dgv, "");
        }
    }

   
}
