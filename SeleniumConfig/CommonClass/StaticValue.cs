using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using GisqRealEstate.ProDataSource;
using SeleniumConfig.CommonClass.Entity;
using SeleniumConfig.Forms.Entity;
using SeleniumConfig.ProInfo;
using SeleniumConfig.ProInfo.Entity;
using SeleniumConfig.SeleniumSchema.Entity;

namespace SeleniumConfig.CommonClass
{
    public class StaticValue
    {
        public static string MXmlPath = AppDomain.CurrentDomain.BaseDirectory + @"\ServicePath.xml";
        public static string MProdefListXmlPath = AppDomain.CurrentDomain.BaseDirectory + @"\XML\ProdefList.xml";
        public static string MSeleniumSchemaPath = AppDomain.CurrentDomain.BaseDirectory + @"\SeleniumSchema.xml";
        private static GisqLandProDataSource m_objDataSource;

        private static ServicePath _mServicePath;

        public static ServicePath ServicePath
        {
            get
            {
                GetServiceInfo();
                return _mServicePath;
            }
            set { _mServicePath = value; }
        }

        public static GisqLandProDataSource MObjDataSource
        {
            get {
                if (m_objDataSource == null)
                {
                    try
                    {
                        m_objDataSource
                            = GisqLandProDataSourceFactory.CreateInstance(_mServicePath.DbName, "",
                                _mServicePath.DbUserName
                                , _mServicePath.DbPassWord, DataSourceType.DB_Oracle);
                        m_objDataSource.Open();
                        return m_objDataSource;
                    }
                    catch (Exception er)
                    {
                        
                        Logger.Log.Error(er.ToString());
                        MessageBox.Show("数据库连接失败!" + er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (m_objDataSource != null)
                        {
                            m_objDataSource.Close();
                            m_objDataSource = null;
                        }
                        return null;
                    }
                }
                else
                {
                    return m_objDataSource;
                }
            }
            set { m_objDataSource = value; }
        }

        private static void GetServiceInfo()
        {
            if (_mServicePath == null)
            {
                var docServicePath = new XmlDocument();
                docServicePath.Load(MXmlPath);
                var nodeVerify = docServicePath.SelectSingleNode("//ElementTable[@TableName='VerifyUser']");
                if (nodeVerify == null)
                    throw new Exception("请配置访问服务需要的账户密码！");
                _mServicePath = new ServicePath();
                if (nodeVerify.Attributes != null)
                {
                    var node = nodeVerify.SelectSingleNode("ElementInfo[@UserName]");
                    if (node != null)
                        _mServicePath.UserName = node.Attributes["UserName"].Value;
                    var o = nodeVerify.SelectSingleNode("ElementInfo[@PassWord]");
                    if (o != null)
                        _mServicePath.PassWord = o.Attributes["PassWord"].Value;
                }

                var nodePath = docServicePath.SelectSingleNode("//ElementTable[@TableName='ServicePath']");
                if (nodePath == null)
                    throw new Exception("请配置服务访问地址！");

                var nodeSeriveIP = nodePath.SelectSingleNode("ElementInfo[@ID='ServiceIP']");
                if (nodeSeriveIP != null)
                    _mServicePath.ServiceIP = nodeSeriveIP.InnerText;

                var xmlNode = nodePath.SelectSingleNode("ElementInfo[@ID='Package']");
                if (xmlNode != null)
                    _mServicePath.PackagePath = xmlNode.InnerText;
                var singleNode = nodePath.SelectSingleNode("ElementInfo[@ID='Prodef']");
                if (singleNode != null)
                    _mServicePath.ProdefPath = singleNode.InnerText; ;
                var selectSingleNode = nodePath.SelectSingleNode("ElementInfo[@ID='Actdef']");
                if (selectSingleNode != null)
                    _mServicePath.ActdefPath = selectSingleNode.InnerText; ;

                var nodeDepartment = nodePath.SelectSingleNode("ElementInfo[@ID='Department']");
                if (nodeDepartment != null)
                    _mServicePath.DepartmentPath = nodeDepartment.InnerText; ;
                var nodeUser = nodePath.SelectSingleNode("ElementInfo[@ID='User']");
                if (nodeUser != null)
                    _mServicePath.DeparmentUserPath = nodeUser.InnerText; ;

                var bizDef = nodePath.SelectSingleNode("ElementInfo[@ID='Bizdef']");
                if (bizDef != null)
                    _mServicePath.BizdefPath = bizDef.InnerText; ;

                var bizDefForm = nodePath.SelectSingleNode("ElementInfo[@ID='BizdefForm']");
                if (bizDefForm != null)
                    _mServicePath.BizdefFormPath = bizDefForm.InnerText; ;

                var restService = nodePath.SelectSingleNode("ElementInfo[@ID='RestService']");
                if (restService != null)
                    _mServicePath.BizRestServicePath = restService.InnerText;



                var nodeChromeDriver = docServicePath.SelectSingleNode("//ElementTable[@TableName='ChromeDriver']");
                if (nodeChromeDriver == null)
                    throw new Exception("请配置ChromeDriver地址");

                var ChromeDriver = nodeChromeDriver.SelectSingleNode("ElementInfo[@ID='ChromeDriverUrl']");
                if (ChromeDriver != null)
                    _mServicePath.ChromeDriverPath = ChromeDriver.InnerText;

                var nodeLogin = docServicePath.SelectSingleNode("//ElementTable[@TableName='Login']");
                if (nodeLogin == null)
                    throw new Exception("请配置Login地址");

                var login = nodeLogin.SelectSingleNode("ElementInfo[@ID='LoginUrl']");
                if (login != null)
                    _mServicePath.LoginUrl = login.InnerText; ;

                var loginUserName = nodeLogin.SelectSingleNode("ElementInfo[@ID='LoginUserName']");
                if (loginUserName != null)
                    _mServicePath.LoginUserName = loginUserName.InnerText;

                var loginPassWord = nodeLogin.SelectSingleNode("ElementInfo[@ID='LoginPassWord']");
                if (loginPassWord != null)
                    _mServicePath.LoginPassWord = loginPassWord.InnerText;

                var nodeIfame = docServicePath.SelectSingleNode("//ElementTable[@TableName='Iframe']");
                if (nodeIfame == null)
                    throw new Exception("请配置Iframe参数");

                var firstPageIframe = nodeIfame.SelectSingleNode("ElementInfo[@ID='FirstPageIframe']");
                if (firstPageIframe != null)
                    _mServicePath.FirstPageIframeName = firstPageIframe.InnerText;

                var createProIframe = nodeIfame.SelectSingleNode("ElementInfo[@ID='CreateProIframe']");
                if (createProIframe != null)
                    _mServicePath.CreateProIframeName = createProIframe.InnerText;

                var workFlowFrameIframe = nodeIfame.SelectSingleNode("ElementInfo[@ID='WorkFlowFrameIframe']");
                if (workFlowFrameIframe != null)
                    _mServicePath.WorkFlowFrameIfram = workFlowFrameIframe.InnerText;

                var dataCategory = nodeIfame.SelectSingleNode("ElementInfo[@ID='DataCategory']");
                if (dataCategory != null)
                    _mServicePath.DataCategoryPath = dataCategory.InnerText;

                var nodeDbConnection = docServicePath.SelectSingleNode("//ElementTable[@TableName='DBConnection']");
                if(nodeDbConnection==null)
                    throw new Exception("请配置数据库连接参数");

                var dbName = nodeDbConnection.SelectSingleNode("ElementInfo[@ID='DbName']");
                if (dbName != null)
                    _mServicePath.DbName = dbName.InnerText;


                var dbUserName = nodeDbConnection.SelectSingleNode("ElementInfo[@ID='DbUserName']");
                if (dbUserName != null)
                    _mServicePath.DbUserName = dbUserName.InnerText;


                var dbPassWord = nodeDbConnection.SelectSingleNode("ElementInfo[@ID='DbPassWord']");
                if (dbPassWord != null)
                    _mServicePath.DbPassWord = dbPassWord.InnerText;


                var temp = MObjDataSource; //测试数据库连接

            }
        }

        /// <summary>
        /// 获取初始化参数配置信息
        /// </summary>
        /// <param name="servicePath"></param>
        public static void saveServicePath(ServicePath servicePath)
        {
            var doc = new XmlDocument();
            doc.Load(MXmlPath);
            var nodeVerify = doc.SelectSingleNode("//ElementTable[@TableName='VerifyUser']/ElementInfo");
            var elementVerify = nodeVerify as XmlElement;
            elementVerify.SetAttribute("UserName", servicePath.UserName);
            elementVerify.SetAttribute("PassWord", servicePath.PassWord);
            //调用框架服务地址
            setSerivePathXmlNode(doc, "ServicePath", "Package", servicePath.PackagePath);
            setSerivePathXmlNode(doc, "ServicePath", "Prodef", servicePath.ProdefPath);
            setSerivePathXmlNode(doc, "ServicePath", "Actdef", servicePath.ActdefPath);
            setSerivePathXmlNode(doc, "ServicePath", "Department", servicePath.DepartmentPath);
            setSerivePathXmlNode(doc, "ServicePath", "User", servicePath.DeparmentUserPath);
            setSerivePathXmlNode(doc, "ServicePath", "Bizdef", servicePath.BizdefPath);
            setSerivePathXmlNode(doc, "ServicePath", "BizdefForm", servicePath.BizdefFormPath);
            setSerivePathXmlNode(doc, "ServicePath", "ServiceIP", servicePath.ServiceIP);

            //Chorme驱动地址
            setSerivePathXmlNode(doc, "ChromeDriver", "ChromeDriverUrl", servicePath.ChromeDriverPath);

            //Iframe配置

            setSerivePathXmlNode(doc, "Iframe", "FirstPageIframe", servicePath.FirstPageIframeName);
            setSerivePathXmlNode(doc, "Iframe", "CreateProIframe", servicePath.CreateProIframeName);
            setSerivePathXmlNode(doc, "Iframe", "WorkFlowFrameIframe", servicePath.WorkFlowFrameIfram);
            setSerivePathXmlNode(doc, "Iframe", "DataCategory", servicePath.DataCategoryPath);
            //登陆相关设置
            setSerivePathXmlNode(doc, "Login", "LoginUrl", servicePath.LoginUrl);
            setSerivePathXmlNode(doc, "Login", "LoginUserName", servicePath.LoginUserName);
            setSerivePathXmlNode(doc, "Login", "LoginPassWord", servicePath.LoginPassWord);

            //数据库连接设置
            setSerivePathXmlNode(doc, "DBConnection", "DbName", servicePath.DbName);
            setSerivePathXmlNode(doc, "DBConnection", "DbUserName", servicePath.DbUserName);
            setSerivePathXmlNode(doc, "DBConnection", "DbPassWord", servicePath.DbPassWord);

            doc.Save(MXmlPath);
            servicePath.IsOrginal = false;
            _mServicePath = servicePath;
            if (m_objDataSource != null)
            {
                m_objDataSource.Close();
                m_objDataSource.Dispose();
                m_objDataSource = null;
            }
            var temp = MObjDataSource;//重新连接数据库
        }

        private static void setSerivePathXmlNode(XmlDocument doc, string nodeTableName, string nodeName,
            string nodeValue)
        {
            var nodeServicePath = doc.SelectSingleNode("//ElementTable[@TableName='" + nodeTableName + "']");
            var nodePropackageUrl = nodeServicePath.SelectSingleNode("ElementInfo[@ID='" + nodeName + "']");
            var elementPropackage = nodePropackageUrl as XmlElement;
            elementPropackage.InnerText = "";
            var cData = doc.CreateCDataSection(nodeValue);
            elementPropackage.AppendChild(cData);
        }


        /// <summary>
        /// 加载定位元素方式
        /// </summary>
        public static void LoadLocationElementType(ComboBoxEx cmbLocationType)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("VALUE");
            dt.Rows.Add(dt.NewRow());
            List<String> lstAllTypes = new List<string>() {"ID", "NAME", "XPATH"};
            foreach (var type in lstAllTypes)
            {
                DataRow dr = dt.NewRow();
                dr["NAME"] = type;
                dr["VALUE"] = type;
                dt.Rows.Add(dr);
            }
            cmbLocationType.DataSource = dt;
            cmbLocationType.DisplayMember = "NAME";
            cmbLocationType.ValueMember = "VALUE";

        }

        /// <summary>
        /// 加载操作元素方式
        /// </summary>
        public static void LocadLocationOpearateType(ComboBoxEx cmbOperateType, bool isNeedIframe)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME");
            dt.Columns.Add("VALUE");
            dt.Rows.Add(dt.NewRow());
            List<String> lstAllTypes = new List<string>() {"点击", "赋值", "循环赋值", "弹出Iframe", "帆软表单", "其他"};
            List<String> lstAllTypesValue = new List<string>()
            {
                "CLICK",
                "SENDKEYS",
                "CIRCLESENDKEYS",
                "IFRAME",
                "FR",
                "QT"
            };
            for (int i = 0; i < lstAllTypes.Count; i++)
            {
                if (!isNeedIframe)
                {
                    if (lstAllTypes[i].Equals("Iframe"))
                        continue;
                }
                DataRow dr = dt.NewRow();
                dr["NAME"] = lstAllTypes[i];
                dr["VALUE"] = lstAllTypesValue[i];
                dt.Rows.Add(dr);
            }

            cmbOperateType.DataSource = dt;
            cmbOperateType.DisplayMember = "NAME";
            cmbOperateType.ValueMember = "VALUE";

        }

        /// <summary>
        /// 读取流程方案配置信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="dgv"></param>
        public static void LoadProdefList(String prodefId, DataGridView dgv,String selectChildProdefId)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MProdefListXmlPath);
            DataTable dt = new DataTable();
            dt.Columns.Add("ChildProdefID");
            dt.Columns.Add("ChildProdefName");
            XmlNode node = doc.SelectSingleNode("//Prodef[@ID='" + prodefId + "']");
            if (node != null)
            {
                XmlNodeList nodeList = node.SelectNodes("ProdefChild");
                foreach (XmlNode nodeProdefChild in nodeList)
                {
                    DataRow dr = dt.NewRow();
                    dr["ChildProdefID"] = nodeProdefChild.Attributes["ID"].Value;
                    dr["ChildProdefName"] = nodeProdefChild.Attributes["Name"].Value;
                    dt.Rows.Add(dr);
                }
            }
            dgv.DataSource = dt;
            if (!String.IsNullOrEmpty(selectChildProdefId))
            {
                if (dt.Rows.Count > 0)
                {
                    //默认选中行
                    List<DataGridViewRow> dataGridViewRowList
                        = dgv.Rows.ToList<DataGridViewRow>();
                    DataGridViewRow dgvSelectRow =
                        dataGridViewRowList
                            .FirstOrDefault(o => o.Cells["ChildProdefID"].Value.ToString().Equals(selectChildProdefId));
                    if (dgvSelectRow != null)
                    {
                        dgvSelectRow.Selected = true;
                        dgv.CurrentCell = dgvSelectRow.Cells["ChildProdefName"];
                    }
                }
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = false;
                    dgv.CurrentCell = null;
                }
            }
           
        }

        /// <summary>
        /// 保存流程方案配置信息
        /// </summary>
        /// <param name="childProdef"></param>
        public static void SaveChildProdefList(ChildProdefEntity childProdef)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MProdefListXmlPath);
            XmlNode elementRoot = doc.SelectSingleNode("Element");
            if (elementRoot == null)
            {
                elementRoot = doc.CreateElement("Element");
                doc.AppendChild(elementRoot);
            }

            XmlNode nodeProdef = elementRoot.SelectSingleNode("Prodef[@ID='" + childProdef.ProdefId + "']");
            if (nodeProdef == null)
            {
                XmlElement elementProdef = doc.CreateElement("Prodef");
                elementProdef.SetAttribute("ID", childProdef.ProdefId);
                elementProdef.SetAttribute("Name", childProdef.ProdefName);
                elementProdef.SetAttribute("PackageName", childProdef.PropackageName);
                nodeProdef = elementProdef as XmlNode;
                elementRoot.AppendChild(elementProdef);
            }

            XmlNode nodeChildProdef =
                nodeProdef.SelectSingleNode("//ProdefChild[@ID='" + childProdef.ChildProdefId + "']");
            if (nodeChildProdef != null)
            {
                nodeChildProdef.ParentNode.RemoveChild(nodeChildProdef);
            }

            XmlElement elementChildProdef
                = doc.CreateElement("ProdefChild");
            elementChildProdef.SetAttribute("ID", childProdef.ChildProdefId);
            elementChildProdef.SetAttribute("Name", childProdef.ChildProdefName);
            nodeProdef.AppendChild(elementChildProdef);
            doc.Save(MProdefListXmlPath);
        }

        /// <summary>
        /// 删除配置方案信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="childProdefId"></param>
        public static void DeleteChildProdefList(String prodefId,
            String childProdefId)
        {
            if (MessageBox.Show("确定删除当前配置方案？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String filePath
               = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\XML\" +
                            string.Format("Prodef_{0}_{1}.xml", prodefId, childProdefId));
                if (File.Exists(filePath))
                {
                    if (MessageBox.Show("当前方案已配置过信息，如果继续删除，则会同步删除配置信息，是否继续？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        DialogResult.Cancel)
                    {
                        return;
                    }
                }

                XmlDocument document = new XmlDocument();
                document.Load(MProdefListXmlPath);
                XmlNode node = document.SelectSingleNode("//ProdefChild[@ID='" + childProdefId + "']");
                if (node != null)
                    node.ParentNode.RemoveChild(node);
                document.Save(MProdefListXmlPath);
                File.Delete(filePath);
            }
           
        }


        /// <summary>
        /// 加载所有方案
        /// </summary>
        /// <param name="dgv"></param>
        public static void LoadSeleniumSchema(DataGridView dgv,SeleniumSchemaEntity seleniumSchemaEntity)
        {
            XmlDocument document = new XmlDocument();
            document.Load(MProdefListXmlPath);
            DataTable dt = new DataTable();
            dt.Columns.Add("ProdefID");
            dt.Columns.Add("ProdefName");
            dt.Columns.Add("PropackageName");
            dt.Columns.Add("ChildProdefId");
            dt.Columns.Add("ChildProdefName");
            dt.Columns.Add("SELECT");
            XmlNodeList nodeProdefParent = document.SelectNodes("//Prodef");

            if (nodeProdefParent != null)
            {
                List<XmlNode> nodeProdefList = nodeProdefParent.ToList<XmlNode>();

                nodeProdefList = nodeProdefList.Where(p => p.HasChildNodes).ToList(); //只选择配置了方案的
                nodeProdefList.ForEach(o =>
                {
                    o.ChildNodes.ToList<XmlNode>().ForEach(p =>
                    {
                        DataRow dr = dt.NewRow();
                        dr["ProdefID"] = o.Attributes["ID"].Value.ToString();
                        dr["ProdefName"] = o.Attributes["Name"].Value.ToString();
                        dr["PropackageName"] = o.Attributes["PackageName"].Value.ToString();
                        dr["ChildProdefID"] = p.Attributes["ID"].Value.ToString();
                        dr["ChildProdefName"] = p.Attributes["Name"].Value.ToString();
                        dr["SELECT"] = false;
                        dt.Rows.Add(dr);
                    });
                });
            }

            //加载已有的配置，默认选中状态
            XmlDocument docSchema  =new XmlDocument();
            docSchema.Load(MSeleniumSchemaPath);
            XmlNode xmlNodeSchema
                = docSchema.SelectSingleNode("//Schema[@ID='" + seleniumSchemaEntity.Id + "']");
            if (xmlNodeSchema!=null)
            {
                dt.AsEnumerable().ToList().ForEach(p =>
                {
                    if (xmlNodeSchema.SelectSingleNode("Prodef[@ID='" + p["ProdefID"] + "']/ProdefChild[@ID='" + p["ChildProdefID"] + "']") != null)
                    {
                        p["SELECT"] = true;
                    }
                    else
                    {
                        p["SELECT"] = false;
                    }
                });
            }

            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Rows[0].Selected = false;
                dgv.CurrentCell = null;
            }
        }

        /// <summary>
        /// 获取所有自动化测试方案
        /// </summary>
        /// <param name="tree"></param>
        public static void GetAllSeleniumSchema(AdvTree tree,String selectNodeId)
        {
            tree.Nodes.Clear();
            Node nodeRoot = new Node();
            nodeRoot.Name = "ROOT_" + Guid.NewGuid().ToString();
            nodeRoot.Text = " 所有测试方案";
            Node selectNode = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(MSeleniumSchemaPath);
            nodeRoot.Expanded = true;
            List<XmlNode> nodeList = doc.SelectNodes("//Schema").ToList<XmlNode>();
            if (nodeList.Count > 0)
            {
                nodeList.ForEach(o =>
                {
                    SeleniumSchemaEntity seleniumSchemaEntity = new SeleniumSchemaEntity();
                    seleniumSchemaEntity.Id = o.Attributes["ID"].Value;
                    seleniumSchemaEntity.Name = o.Attributes["Name"].Value;
                    seleniumSchemaEntity.IsExecute = o.Attributes["Execute"] != null && Convert.ToBoolean(o.Attributes["Execute"].Value);

                    Node nodeChild = new Node();
                    nodeChild.Name = "SCHEMA_" + seleniumSchemaEntity.Id;
                    nodeChild.Text = seleniumSchemaEntity.Name;
                    nodeChild.Tag = seleniumSchemaEntity;
                    if (selectNodeId.Equals(seleniumSchemaEntity.Id))
                    {
                        selectNode = nodeChild;
                    }

                    if (seleniumSchemaEntity.IsExecute)
                    {
                        ElementStyle style=new ElementStyle();
                        style.TextColor = Color.Red;
                        nodeChild.Style = style;
                        nodeChild.Text = nodeChild.Text + "(执行方案)";
                    }
                    nodeRoot.Nodes.Add(nodeChild);
                });
            }
            tree.Nodes.Add(nodeRoot);
            if (selectNode != null) //选中节点
            {
                tree.SelectNode(selectNode, eTreeAction.Mouse);
            }

        }

        /// <summary>
        /// 保存自动化测试方案
        /// </summary>
        /// <param name="schemaId">方案内码</param>
        /// <param name="schemaName">方案名称</param>
        public static void SaveSeleniumSchema(String schemaId,String schemaName)
        {
            XmlDocument doc=new XmlDocument();
            doc.Load(MSeleniumSchemaPath);
            XmlNode nodeRoot = doc.SelectSingleNode("Element");
            if (nodeRoot == null)
            {
                nodeRoot = doc.CreateElement("Element");
                doc.AppendChild(nodeRoot);
            }

            XmlNode nodeSchema = nodeRoot.SelectSingleNode("Schema[@ID='" + schemaId + "']");
            XmlElement elementSchema;
            if (nodeSchema == null)
            {
                elementSchema = doc.CreateElement("Schema");
                elementSchema.SetAttribute("ID", schemaId);
                elementSchema.SetAttribute("Name", schemaName);
                nodeRoot.AppendChild(elementSchema);
            }
            else
            {
                elementSchema =nodeSchema as XmlElement;
                elementSchema.SetAttribute("Name", schemaName);
            }
            doc.Save(MSeleniumSchemaPath);
        }

        /// <summary>
        /// 配置自动化测试对应需要测试的流程方案
        /// </summary>
        /// <param name="schemaId"></param>
        /// <param name="seleniumSchemaEntityList"></param>
        public static void SaveSeleniumSchemaProdef(String schemaId,List<SeleniumSchemaEntity> seleniumSchemaEntityList )
        {
            XmlDocument docSchema = new XmlDocument();
            docSchema.Load(MSeleniumSchemaPath);
            XmlNode nodeSchema = docSchema.SelectSingleNode("//Schema[@ID='"+schemaId+"']");
            if(nodeSchema==null)
                throw new Exception("没有当前方案的配置信息，请检查！");

            //删除所有子节点
            nodeSchema.ChildNodes.ToList<XmlNode>().ForEach(p =>
            {
                p.ParentNode.RemoveChild(p);
            });

            XmlDocument documentProdef =new XmlDocument();
            documentProdef.Load(MProdefListXmlPath);
            List<XmlNode> lstSelectProdef = new List<XmlNode>();
            seleniumSchemaEntityList = seleniumSchemaEntityList.Where(p => p.IsSelect).ToList();
            seleniumSchemaEntityList = seleniumSchemaEntityList.OrderBy(p => p.ProdefId).ToList(); //按照ProdefId排序
            seleniumSchemaEntityList.ForEach(p =>
            {
                XmlNode nodeProdefChild = documentProdef.SelectSingleNode("//ProdefChild[@ID='" + p.ChildProdefId + "']");
                if (nodeProdefChild != null)
                {
                    lstSelectProdef.Add(nodeProdefChild);
                }
            });
            lstSelectProdef.ForEach(p =>
            {

                XmlNode nodeProdef =
                    nodeSchema.SelectSingleNode("Prodef[@ID='" + p.ParentNode.Attributes["ID"].Value + "']");
                if (nodeProdef == null)
                {
                    nodeProdef = docSchema.ImportNode(p.ParentNode, false);
                    nodeSchema.AppendChild(nodeProdef);
                }
                XmlNode nodeProdefChild = docSchema.ImportNode(p, false);
                nodeProdef.AppendChild(nodeProdefChild);
            });
            docSchema.Save(MSeleniumSchemaPath);
        }

        /// <summary>
        /// 设置为当前执行的方案
        /// </summary>
        /// <param name="seleniumSchemaEntity"></param>
        public static void SetExecuteSeleniumSchema(SeleniumSchemaEntity seleniumSchemaEntity)
        {
            XmlDocument docSchema = new XmlDocument();
            docSchema.Load(MSeleniumSchemaPath);
            List<XmlNode> nodeSchemaList = docSchema.SelectNodes("//Schema").ToList<XmlNode>();
            nodeSchemaList.ForEach(p =>
            {
                XmlElement elementP = p as XmlElement;
                if (p.Attributes["ID"].Value.Equals(seleniumSchemaEntity.Id))
                {
                    elementP.SetAttribute("Execute", "true");
                }
                else
                {
                    elementP.SetAttribute("Execute", "false");
                }
            });
            docSchema.Save(MSeleniumSchemaPath);
        }


        /// <summary>
        /// 复制流程方案
        /// </summary>
        public static String CopyProdefSchema(String prodefId, String childProdefId)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MProdefListXmlPath);
            XmlNode nodeProdef = doc.SelectSingleNode("//Prodef[@ID='" + prodefId + "']");
            if (nodeProdef == null)
            {
                throw new Exception("复制方案没有找到流程信息");
            }

            XmlNode nodeChildProdef
                = nodeProdef.SelectSingleNode("ProdefChild[@ID='" + childProdefId + "']");
            if(nodeChildProdef==null)
                throw new Exception("复制流程没有找到方案信息");

            String childPordefName = nodeChildProdef.Attributes["Name"].Value;
            String newGuid = Guid.NewGuid().ToString();
            XmlElement elementCopy = doc.CreateElement("ProdefChild");
            elementCopy.SetAttribute("ID", newGuid);
            Random random=new Random();
            elementCopy.SetAttribute("Name", childPordefName + "_copy" + "_" + random.Next(1,99999));
            nodeProdef.AppendChild(elementCopy);
            doc.Save(MProdefListXmlPath);
            String dictoryPath = AppDomain.CurrentDomain.BaseDirectory + @"\XML\";
            String filePath = dictoryPath + string.Format("Prodef_{0}_{1}.xml", prodefId, childProdefId);
            String newFilePath = dictoryPath + string.Format("Prodef_{0}_{1}.xml", prodefId, newGuid);
            File.Copy(filePath,newFilePath,true);
            
            return newGuid;
        }

        /// <summary>
        /// 复制流程方案
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="lstSchemaId"></param>
        /// <param name="lstBCopy"></param>
        public static void CopyProdefSchemaToOtherProdef(String prodefId, List<String> lstSchemaId, List<Node> lstBCopy)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(MProdefListXmlPath);

            XmlNode nodeRoot = doc.SelectSingleNode("Element");

            XmlNode nodeProdef = doc.SelectSingleNode("//Prodef[@ID='" + prodefId + "']");
            if (nodeProdef == null)
                throw new Exception("找不到被复制对象的流程配置信息，请检查！");

            //所有选中的方案
            List<XmlNode> lstSelectSchemaNode = new List<XmlNode>();
            lstSchemaId.ForEach(p =>
            {
                lstSelectSchemaNode.Add(nodeProdef.SelectSingleNode("ProdefChild[@ID='"+p+"']"));
            });

            XmlNode nodeCopyToProdefXmlNode = null;
            XmlElement elementCopyToProdefXmlElement = null;
            XmlElement elementProdefSchema = null;
            lstBCopy.ForEach(p =>
            {
                ProdefEntity prodefEntity = (ProdefEntity) p.Tag;
                PropackageEntity propackageEntity = (PropackageEntity) p.Parent.Tag;

                String copyToProdefId = prodefEntity.Id;
                String copyToProdefName = prodefEntity.Name;
                String copyToPropackageName = propackageEntity.Caption;
                nodeCopyToProdefXmlNode = doc.SelectSingleNode("//Prodef[@ID='" + copyToProdefId + "']");
                if (nodeCopyToProdefXmlNode == null)
                {
                    nodeCopyToProdefXmlNode = doc.CreateElement("Prodef");
                    nodeRoot.AppendChild(nodeCopyToProdefXmlNode);
                }
                elementCopyToProdefXmlElement = nodeCopyToProdefXmlNode as XmlElement;
                elementCopyToProdefXmlElement.SetAttribute("ID", copyToProdefId);
                elementCopyToProdefXmlElement.SetAttribute("Name", prodefEntity.Name);
                elementCopyToProdefXmlElement.SetAttribute("PackageName", propackageEntity.Caption);


                lstSelectSchemaNode.ForEach(t =>
                {
                    String newChildProdefId = Guid.NewGuid().ToString();
                    elementProdefSchema = doc.CreateElement("ProdefChild");
                    elementProdefSchema.SetAttribute("ID", newChildProdefId);
                    elementProdefSchema.SetAttribute("Name", t.Attributes["Name"].Value + "_copy" +
                                                             Guid.NewGuid().ToString());
                    elementCopyToProdefXmlElement.AppendChild(elementProdefSchema);

                    //复制配置文件
                    String dictoryPath = AppDomain.CurrentDomain.BaseDirectory + @"\XML\";
                    String filePath = dictoryPath +
                                      string.Format("Prodef_{0}_{1}.xml", prodefId, t.Attributes["ID"].Value);
                    String newFilePath = dictoryPath +
                                         string.Format("Prodef_{0}_{1}.xml", copyToProdefId, newChildProdefId);
                    File.Copy(filePath, newFilePath, true);

                    ActdefDataEntity actdefDataEntity
                        = ProTree.GetActdefInfo(new string[] {prodefEntity.Key});

                    List<ActdefEntity> allActdef = actdefDataEntity.ListTaskInfor.ToList<ActdefEntity>();
                    XmlDocument docProdefDetailXml=new XmlDocument();
                    docProdefDetailXml.Load(newFilePath);

                    XmlElement nodeDetailProdef = docProdefDetailXml.SelectSingleNode("//Prodef") as XmlElement;
                    nodeDetailProdef.SetAttribute("ID", copyToProdefId);
                    nodeDetailProdef.SetAttribute("Name", copyToProdefName);
                    nodeDetailProdef.SetAttribute("PackageName", copyToPropackageName);

                    allActdef.ForEach(o =>
                    {
                        XmlNode nodeDetailActdef =
                            nodeDetailProdef.SelectSingleNode("Actdef[@Name='" + o.Task_name + "']");
                        if (nodeDetailActdef != null)
                        {
                            XmlElement elementDetailActdef
                                = nodeDetailActdef as XmlElement;
                            elementDetailActdef.SetAttribute("ID", o.Task_id);
                        }
                    });

                    docProdefDetailXml.Save(newFilePath);
                });

            });
            doc.Save(MProdefListXmlPath);
        }
    }
}