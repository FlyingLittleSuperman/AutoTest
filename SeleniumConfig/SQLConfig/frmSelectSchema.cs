using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.SQLConfig
{
    public partial class FrmSelectSchema : DevComponents.DotNetBar.Office2007Form
    {

        private ISqlSchemaSelectInterface _iSqlSchemaInterface;

        public FrmSelectSchema()
        {
            InitializeComponent();
        }

        private String outColumnName;
        private String outSqlSchemaId;


        public ISqlSchemaSelectInterface SqlSchemaSelectInterface
        {
            get { return _iSqlSchemaInterface; }
            set { _iSqlSchemaInterface = value; }
        }

        public string OutColumnName
        {
            get { return outColumnName; }
            set
            {
                outColumnName = value;
                if (!String.IsNullOrEmpty(value))
                {
                    String[] arrColumnInfos = value.Split('.');
                    if (arrColumnInfos.Length == 3)
                    {
                        _mTableSpaceName = arrColumnInfos[0];
                        _mTableName = arrColumnInfos[1];
                        _mColumnName = arrColumnInfos[2];
                        txtColumn.Text = value;
                    }
                }

            }
        }

        public string OutSqlSchemaId
        {
            get { return outSqlSchemaId; }
            set
            {
                outSqlSchemaId = value;
                _mSqlSchemaId = value;
            }
        }

        private static String _mSqlSchemaId;
        private static String _mTableSpaceName;
        private static String _mTableName;
        private static String _mColumnName;
        private void frmSelectSchema_Load(object sender, EventArgs e)
        {
            try
            {
                var tes = StaticValue.ServicePath;
                SqlConfig.LoadSqlSchema(treeSqlSchema, "");
                if (!String.IsNullOrEmpty(_mSqlSchemaId))
                {
                    List<Node> nodeSchema = treeSqlSchema.Nodes[0].Nodes.ToList<Node>();
                    Node nodeSelect = nodeSchema.FirstOrDefault(p => p.Name.IndexOf(_mSqlSchemaId, StringComparison.Ordinal) > -1);
                    if (nodeSelect != null)
                    {
                        treeSqlSchema.SelectNode(nodeSelect,eTreeAction.Mouse);
                        treeSqlSchema_NodeDoubleClick(nodeSelect,null);

                        List<Node> nodeTables = nodeSelect.Nodes.ToList<Node>();
                        Node nodeSelectTable =
                            nodeTables
                                .FirstOrDefault(p => ((TableEntity) p.Tag).TableSpaceName.Equals(_mTableSpaceName)
                                                  && ((TableEntity) p.Tag).TableName.Equals(_mTableName));
                        if (nodeSelectTable != null)
                        {
                            treeSqlSchema.SelectNode(nodeSelectTable,eTreeAction.Mouse);
                            treeSqlSchema_NodeClick(nodeSelectTable,null);

                            List<DataGridViewRow>
                                dataGridViewRows = dgvColumns.Rows.ToList<DataGridViewRow>();
                            DataGridViewRow dgvSelectRow
                                =
                                dataGridViewRows
                                    .FirstOrDefault(p => p.Cells["ColumnName"].Value.ToString().Equals(_mColumnName));

                            if (dgvSelectRow != null)
                            {
                                dgvSelectRow.Selected = true;
                                dgvColumns.CurrentCell = dgvSelectRow.Cells[0];
                            }
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeSqlSchema_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeSqlSchema.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("TABLE_") > -1)
                    {
                        SqlSchemaEntity sqlSchemaEntity = (SqlSchemaEntity) nodeSelect.Parent.Tag;
                        _mSqlSchemaId = sqlSchemaEntity.ID;
                        TableEntity tableEntity = (TableEntity) nodeSelect.Tag;
                        _mTableSpaceName = tableEntity.TableSpaceName;
                        _mTableName = tableEntity.TableName;
                        DataTable dt = SqlConfig.LoadSchemaTableColumns(_mSqlSchemaId, tableEntity.TableSpaceName,
                            tableEntity.TableName);
                        dgvColumns.DataSource = dt;
                        if (dt.Rows.Count > 0)
                        {
                            dgvColumns.Rows[0].Selected = false;
                            dgvColumns.CurrentCell = null;
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeSqlSchema_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeSqlSchema.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("SCHEMA_", StringComparison.Ordinal) > -1)
                    {
                        //加载配置的表信息
                        SqlSchemaEntity sqlSchemaEntity = (SqlSchemaEntity)nodeSelect.Tag;
                        DataTable dt = SqlConfig.LoadSchemaTable(sqlSchemaEntity.ID);
                        nodeSelect.Expanded = true;
                        foreach (DataRow dr in dt.Rows)
                        {
                            TableEntity tableEntity=new TableEntity();
                            tableEntity.TableName = dr["TABLEID"].ToString();
                            tableEntity.TableSpaceName = dr["TABLESPACENAME"].ToString();
                            tableEntity.Comments = dr["TABLENAME"].ToString();
                            Node nodeChild =new Node();
                            nodeChild.Name = "TABLE_" + tableEntity.TableName;
                            nodeChild.Text = tableEntity.Comments;
                            nodeChild.Tag = tableEntity;
                            nodeSelect.Nodes.Add(nodeChild);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvColumns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvColumns.CurrentRow != null)
                {
                    String columnName = dgvColumns.CurrentRow.Cells["ColumnName"].Value.ToString();
                  
                    txtColumn.Text = string.Format("{0}.{1}.{2}",_mTableSpaceName,_mTableName,columnName);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                SelectColumn();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvColumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvColumns.CurrentRow != null)
                {
                    String columnName = dgvColumns.CurrentRow.Cells["ColumnName"].Value.ToString();
                    txtColumn.Text = string.Format("{0}.{1}.{2}", _mTableSpaceName, _mTableName, columnName);


                    SelectColumn();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectColumn()
        {
            if (String.IsNullOrEmpty(_mSqlSchemaId))
            {
                MessageBox.Show("请选择方案！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtColumn.Text))
            {
                MessageBox.Show("请选择关联字段！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_iSqlSchemaInterface != null)
            {
                _iSqlSchemaInterface.SqlSchemaSelectCallBack(_mSqlSchemaId, txtColumn.Text);
            }
            this.Close();
        }
    }
}
