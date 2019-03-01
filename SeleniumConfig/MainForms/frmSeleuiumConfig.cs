using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SeleniumConfig.Bizdef;
using SeleniumConfig.Bizdef.Entity;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.Entity;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.CommonClass.loading;
using SeleniumConfig.CreateAction;
using SeleniumConfig.CreateAction.Entity;
using SeleniumConfig.DeparmentUser;
using SeleniumConfig.DeparmentUser.Entity;
using SeleniumConfig.Forms.Entity;
using SeleniumConfig.ProInfo;
using SeleniumConfig.ProInfo.Entity;
using SeleniumConfig.SeleniumSchema;
using SeleniumConfig.SQLConfig;
using Timer = System.Timers.Timer;

namespace SeleniumConfig.MainForms
{
    public partial class FrmSeleuiumConfig : Office2007Form,
        IDepartmentInterface,
        IBizdefInterface,
        IChildProdefInterface,
        ISqlSchemaSelectInterface
    {
        private readonly OpaqueCommand _opaqueCommand = new OpaqueCommand();

        private Timer _timer;


        private FrmDepartmentUser departmentUser;
        private Rectangle dragBoxFromMouseDown;

        private FrmBizdef frmBizdef;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public FrmSeleuiumConfig()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance
                                                                      | BindingFlags.NonPublic)
                .SetValue(tableLayoutPanel1, true, null);
        }

        /// <summary>
        ///     用于TableLayoutPanel自动布局
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        /// <summary>
        ///     获取所有需要保存的控件
        /// </summary>
        public List<TextBox> GetAllTextBox
        {

            


            get
            {
                List<Control> controls
                    = groupServicePath.Controls.ToList<Control>();

                List<TextBox> allText
                    = controls.OfType<TextBox>().ToList();

                return allText;
                /*return new List<TextBox>
                {
                    txtUserName,
                    txtPassWord,
                    txtPropackageUrl,
                    txtProdefUrl,
                    txtActdefUrl,
                    txtChromeDriver,
                    txtLoginUrl,
                    txtDepartmentPath,
                    txtDepartmentUserPath,
                    txtFirstPageIframName,
                    txtCreateProIframeName,
                    txtWorkFlowIframeName,
                    txtBizdef,
                    txtBizdefForm,
                    txtDataCategoryPath,
                    txtLoginUserName,
                    txtLoginPassWord,
                    txtSeriviceIP,
                    txtRestServicePath,
                    txtDbName,
                    txtDbUserName,
                    txtDbPassWord,
                };*/
            }
        }

        /// <summary>
        ///     业务定制回调函数
        /// </summary>
        /// <param name="bizdefForm"></param>
        public void BizdefCallBack(BizdefFormEntity bizdefForm)
        {
            try
            {
                var actdef = new ActdefEntity();
                actdef.Task_id = txtActdefId.Text;
                actdef.Task_name = txtActdefName.Text;

                var prodef = new ProdefEntity();
                prodef.Key = txtProdefId.Text;
                prodef.Name = txtProdefName.Text;

                var iframe = new IFrameEntity();
                iframe.Id = bizdefForm.Id;
                iframe.Name = bizdefForm.DisplayText;
                iframe.UrlPath = bizdefForm.LinkUrl.Replace("{cptPath}/", "");
                CreateActionUtil.AddIframeToXML(iframe, actdef, prodef, txtSecondPropackageId.Text, txtChildProdefId.Text);

                CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ChildProdefCallBack(ChildProdefEntity childProdefEntity)
        {
            LoadChildProdef(childProdefEntity.ChildProdefId);
        }

        /// <summary>
        ///     部门用户树回调函数
        /// </summary>
        /// <param name="departmentUser"></param>
        /// <param name="department"></param>
        public void DepartmentCallBack(DepartmentUserEntity departmentUser, DepartmentEntity department)
        {
            var actdef = new ActdefEntity();
            actdef.Task_id = txtActdefId.Text;
            actdef.Task_name = txtActdefName.Text;

            var prodef = new ProdefEntity();
            prodef.Key = txtProdefId.Text;
            prodef.Name = txtProdefName.Text;

            txtLoginUserName.Text = departmentUser.Name;
            txtLoginUserName.Tag = departmentUser.Id;
            txtLoginUserName.AccessibleDescription = department.Id;
            //IframeUtil.AddUserToXML(departmentUser,department,actdef,prodef);
        }

        private void frmSeleuiumConfig_Load(object sender, EventArgs e)
        {
            try
            {
                _opaqueCommand.ShowOpaqueLayer(this, 125, true);
                LoadServicePath();
                Application.DoEvents();
                LoadProdefTree();
                StaticValue.LoadLocationElementType(cmbLocationType);
                StaticValue.LocadLocationOpearateType(cmbOperateType, true);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     加载流程树
        /// </summary>
        private void LoadProdefTree()
        {
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Elapsed += AnsyLoadProdefs;
            _timer.Enabled = true;

            _timer.Start();
        }

        private void AnsyLoadProdefs(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            var backWorkerSelect = new BackgroundWorker();
            backWorkerSelect.WorkerReportsProgress = true;
            backWorkerSelect.WorkerSupportsCancellation = false;

            backWorkerSelect.DoWork += GetProdefDoWork;
            //backWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress)
            backWorkerSelect.RunWorkerCompleted += GetProdefCompleteWork;
            backWorkerSelect.RunWorkerAsync(this);
        }

        private void GetProdefDoWork(object sender, DoWorkEventArgs e)
        {
            //用代理解决子线程访问主线程控件
            Invoke(new InvokeHandler(delegate
            {
                treeProInfo.Nodes.Clear();
                Application.DoEvents();
                var nodeRoot = new Node("所有流程");
                nodeRoot.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\package.png");
                nodeRoot.Name = "ROOT_" + Guid.NewGuid();
                nodeRoot.Expanded = true;
                ProTree.CreateProPackage(nodeRoot, "");
                treeProInfo.Nodes.Add(nodeRoot);
                _opaqueCommand.HideOpaqueLayer();
            }));
        }

        private void GetProdefCompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        /// <summary>
        ///     把控件
        /// </summary>
        private void LoadServicePath()
        {
            var servicePath = StaticValue.ServicePath;
            servicePath.IsOrginal = true;
            txtUserName.Text = servicePath.UserName;
            txtPassWord.Text = servicePath.PassWord;
            txtPropackageUrl.Text = servicePath.PackagePath;
            txtProdefUrl.Text = servicePath.ProdefPath;
            txtActdefUrl.Text = servicePath.ActdefPath;
            txtLoginUrl.Text = servicePath.LoginUrl;
            txtChromeDriver.Text = servicePath.ChromeDriverPath;
            txtDepartmentPath.Text = servicePath.DepartmentPath;
            txtDepartmentUserPath.Text = servicePath.DeparmentUserPath;
            txtFirstPageIframName.Text = servicePath.FirstPageIframeName;
            txtCreateProIframeName.Text = servicePath.CreateProIframeName;
            txtWorkFlowIframeName.Text = servicePath.WorkFlowFrameIfram;
            txtBizdef.Text = servicePath.BizdefPath;
            txtBizdefForm.Text = servicePath.BizdefFormPath;
            txtDataCategoryPath.Text = servicePath.DataCategoryPath;
            txtLoginUserName.Text = servicePath.LoginUserName;
            txtLoginPassWord.Text = servicePath.LoginPassWord;
            txtSeriviceIP.Text = servicePath.ServiceIP;
            txtRestServicePath.Text = servicePath.BizRestServicePath;
            txtDbName.Text = servicePath.DbName;
            txtDbUserName.Text = servicePath.DbUserName;
            txtDbPassWord.Text = servicePath.DbPassWord;
            servicePath.IsOrginal = false;
        }


        private void treeProInfo_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                var nodeSelect = treeProInfo.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("PROPACKAGE_") > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            var propackage = (PropackageEntity) nodeSelect.Tag;
                            ProTree.CreateProDef(nodeSelect, propackage.Id);
                        }
                    }
                    else if (nodeSelect.Name.IndexOf("PRODEF_") > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            var prodef = (ProdefEntity) nodeSelect.Tag;
                            ProTree.CreateActdef(nodeSelect, prodef.Key);
                        }
                    }
                    else if (nodeSelect.Name.IndexOf("ACTDEF_") > -1)
                    {
                        CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                    }
                    setSelectText(nodeSelect);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     保存服务等参数信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveServicePath_Click(object sender, EventArgs e)
        {
            try
            {
                var listHaveEmptyValue = GetAllTextBox
                    .Where(o => string.IsNullOrEmpty(o.Text))
                    .Select(p => p.Tag == null ? "" : p.Tag.ToString())
                    .ToList();
                if (listHaveEmptyValue.Count > 0)
                {
                    var errorText = string.Join("不能为空\r\n", listHaveEmptyValue.ToArray());
                    MessageBox.Show(errorText
                        , "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var servicePath = new ServicePath();
                servicePath.IsOrginal = true;
                servicePath.UserName = txtUserName.Text;
                servicePath.PassWord = txtPassWord.Text;
                servicePath.PackagePath = txtPropackageUrl.Text;
                servicePath.ProdefPath = txtProdefUrl.Text;
                servicePath.ActdefPath = txtActdefUrl.Text;
                servicePath.ChromeDriverPath = txtChromeDriver.Text;
                servicePath.LoginUrl = txtLoginUrl.Text;
                servicePath.DepartmentPath = txtDepartmentPath.Text;
                servicePath.DeparmentUserPath = txtDepartmentUserPath.Text;
                servicePath.FirstPageIframeName = txtFirstPageIframName.Text;
                servicePath.CreateProIframeName = txtCreateProIframeName.Text;
                servicePath.WorkFlowFrameIfram = txtWorkFlowIframeName.Text;
                servicePath.BizdefPath = txtBizdef.Text;
                servicePath.BizdefFormPath = txtBizdefForm.Text;
                servicePath.DataCategoryPath = txtDataCategoryPath.Text;
                servicePath.LoginUserName = txtLoginUserName.Text;
                servicePath.LoginPassWord = txtLoginPassWord.Text;
                servicePath.ServiceIP = txtSeriviceIP.Text;
                servicePath.BizRestServicePath = txtRestServicePath.Text;
                servicePath.DbName = txtDbName.Text;
                servicePath.DbUserName = txtDbUserName.Text;
                servicePath.DbPassWord = txtDbPassWord.Text;
                StaticValue.saveServicePath(servicePath);
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     选中节点以后赋值
        /// </summary>
        /// <param name="node"></param>
        private void setSelectText(Node node)
        {
            if (node.Name.IndexOf("PROPACKAGE_") > -1)
            {
                var propackage = (PropackageEntity) node.Tag;
                if (node.Level == 2)
                {
                    txtSecondPropackageId.Text = propackage.Id;
                    txtSecondPropackageName.Text = propackage.Caption;
                }
                txtPropackageId.Text = propackage.Id;
                txtPropackageName.Text = propackage.Caption;
            }
            else if (node.Name.IndexOf("PRODEF_") > -1)
            {
                var prodef = (ProdefEntity) node.Tag;
                txtProdefId.Text = prodef.Id;
                txtProdefName.Text = prodef.Name;
                LoadChildProdef("");
            }
            else if (node.Name.IndexOf("ACTDEF_") > -1)
            {
                var actdef = (ActdefEntity) node.Tag;
                txtActdefId.Text = actdef.Task_id;
                txtActdefName.Text = actdef.Task_name;
            }
        }

        private void treeProInfo_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                var nodeSelect = treeProInfo.SelectedNode;
                if (nodeSelect != null)
                {
                    var flag = "";

                    if (nodeSelect.Name.IndexOf("ACTDEF_") > -1)
                        flag = "ACTDEF";
                    else if (nodeSelect.Name.IndexOf("PRODEF_") > -1)
                        flag = "PRODEF";
                    else if (nodeSelect.Name.IndexOf("PROPACKAGE_") > -1)
                        flag = "PROPACKAGE";
                    LoadInfo(flag, nodeSelect);
                    setSelectText(nodeSelect);

                    if (nodeSelect.Name.IndexOf("ACTDEF_") > -1)
                    {
                        CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                        btnAddElement_Click(null, null);
                        CreateActionUtil.ReadLocationElement("", txtProdefId.Text, txtActdefId.Text, "", dgvLoactionElement,
                            txtChildProdefId.Text);
                        var selectChildProdefId = "";
                        if (dgvChildProdef.CurrentRow != null)
                            selectChildProdefId = dgvChildProdef.CurrentRow.Cells["ChildProdefID"].Value.ToString();
                        //IframeUtil.ReadUser(txtProdefId.Text,txtActdefId.Text,txtLoginUserName);
                    }
                    else if (nodeSelect.Name.IndexOf("PRODEF_") > -1)
                    {
                        CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                        btnAddElement_Click(null, null);
                        CreateActionUtil.ReadLocationElement("", txtProdefId.Text, txtActdefId.Text, "", dgvLoactionElement,
                            txtChildProdefId.Text);
                    }
                    else if (nodeSelect.Name.IndexOf("PROPACKAGE_") > -1)
                    {
                        CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                        btnAddElement_Click(null, null);
                        CreateActionUtil.ReadLocationElement("", txtProdefId.Text, txtActdefId.Text, "", dgvLoactionElement,
                            txtChildProdefId.Text);
                        LoadChildProdef("");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadInfo(string flag, Node node)
        {
            switch (flag)
            {
                case "PROPACKAGE":
                    txtChildProdefId.Text = "";
                    txtChildProdefName.Text = "";
                    txtProdefId.Text = "";
                    txtProdefName.Text = "";
                    txtActdefName.Text = "";
                    txtActdefId.Text = "";
                    var propackage2 = (PropackageEntity) node.Tag;
                    txtPropackageId.Text = propackage2.Id;
                    txtPropackageName.Text = propackage2.Caption;
                    LoadPropakage(node);
                    break;
                case "PRODEF":
                    if (!((ProdefEntity) node.Tag).Id.Equals(txtProdefId.Text))
                    {
                        txtChildProdefId.Text = "";
                        txtChildProdefName.Text = "";
                        LoadChildProdef("");
                    }
                    txtActdefId.Text = "";
                    txtActdefName.Text = "";
                    var nodePropackage1 = node.Parent;
                    var propackage1 = (PropackageEntity) nodePropackage1.Tag;
                    txtPropackageId.Text = propackage1.Id;
                    txtPropackageName.Text = propackage1.Caption;
                    LoadPropakage(nodePropackage1);
                    break;
                case "ACTDEF":
                    var nodeProdef = node.Parent;
                    var prodef = (ProdefEntity) nodeProdef.Tag;
                    if (!prodef.Id.Equals(txtProdefId.Text))
                    {
                        txtChildProdefId.Text = "";
                        txtChildProdefName.Text = "";
                        txtProdefId.Text = prodef.Id;
                        txtProdefName.Text = prodef.Name;
                        var nodePropackage = nodeProdef.Parent;
                        var propackage = (PropackageEntity) nodePropackage.Tag;
                        txtPropackageId.Text = propackage.Id;
                        txtPropackageName.Text = propackage.Caption;
                        LoadPropakage(nodePropackage);
                        LoadChildProdef("");
                    }
                    break;
            }
        }


        private void LoadPropakage(Node node)
        {
            if (node != null)
                if (node.Level == 2)
                {
                    var propackage = (PropackageEntity) node.Tag;
                    txtSecondPropackageId.Text = propackage.Id;
                    txtSecondPropackageName.Text = propackage.Caption;
                }
                else
                {
                    LoadPropakage(node.Parent);
                }
        }


        private void treeProInfo_AfterExpand(object sender, AdvTreeNodeEventArgs e)
        {
            try
            {
                var nodeSelect = e.Node;
                if (nodeSelect == null)
                    setSelectText(nodeSelect);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (departmentUser == null)
            {
                departmentUser = new FrmDepartmentUser();
                departmentUser.SelectParentNode = "";
                departmentUser.SelectUserNode = "";
            }
            departmentUser.TreeInterface = this;
            departmentUser.ShowDialog();
        }

        private void btnAddIframe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSecondPropackageId.Text == "")
                {
                    MessageBox.Show("请选择二级包", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtActdefId.Text == "")
                {
                    MessageBox.Show("请选择环节", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtChildProdefId.Text == "")
                {
                    MessageBox.Show("请先选择或配置方案！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (frmBizdef == null)
                    frmBizdef = new FrmBizdef();
                frmBizdef.BizdefIntserface = this;
                frmBizdef.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     删除指定Iframe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIframe_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIframes.CurrentRow != null)
                {
                    var iframeId = dgvIframes.CurrentRow.Cells["ID"].Value.ToString();
                    if (
                        MessageBox.Show("确定删除当前配置的iframe信息？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        DialogResult.OK)
                        CreateActionUtil.DeleteIframe(txtProdefId.Text, txtActdefId.Text, iframeId, false, dgvIframes,
                            txtChildProdefId.Text);
                }
                else
                {
                    MessageBox.Show("请先选择要删除的iframe！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     删除所有Iframe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllIframe_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    MessageBox.Show("确定删除当前配置的iframe信息？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                    CreateActionUtil.DeleteIframe(txtProdefId.Text, txtActdefId.Text, "", true, dgvIframes,
                        txtChildProdefId.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelEx4_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     新增元素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddElement_Click(object sender, EventArgs e)
        {
            cmbLocationType.Text = "";
            txtLocationPath.Text = "";
            lblLacationGUID.Text = Guid.NewGuid().ToString();
            cmbOperateType.Text = "";
            txtLocationDefaultValue.Text = "";
            txtLocationOrder.Text = "";
            btnAddLoactionElementInfo.Enabled = false;
            txtLocationIntroduce.Text = "";
            chkLocationRandom.Checked = false;
            txtOperateTime.Text = "";
            txtLocationDefaultValue.Tag = null;
            SetOrder();
        }

        private void dgvIframes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvIframes.CurrentRow != null)
                {
                    var selectIframId = dgvIframes.CurrentRow.Cells["ID"].Value.ToString();
                    CreateActionUtil.ReadLocationElement(selectIframId, txtProdefId.Text, txtActdefId.Text, "",
                        dgvLoactionElement, txtChildProdefId.Text);
                    btnAddElement_Click(null, null);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIframes.CurrentRow == null)
                {
                    MessageBox.Show("请先选择要操作的Iframe表单", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((cmbLocationType.SelectedValue == null) || (cmbLocationType.Text == ""))
                {
                    MessageBox.Show("请选择定位方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtLocationPath.Text == "")
                {
                    MessageBox.Show("请输入定位路径", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((cmbOperateType.SelectedValue == null) || (cmbOperateType.Text == ""))
                {
                    MessageBox.Show("请选择操作方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtLocationOrder.Text.Trim() == "")
                {
                    MessageBox.Show("请输入操作顺序", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtLocationIntroduce.Text.Trim() == "")
                {
                    MessageBox.Show("请输入操作说明", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbOperateType.SelectedValue.ToString().Equals("SENDKEYS") ||
                    cmbOperateType.SelectedValue.ToString().Equals("FR") ||
                    cmbOperateType.SelectedValue.ToString().Equals("CIRCLESENDKEYS"))
                {
                    if (txtLocationDefaultValue.Text == "")
                    {
                        MessageBox.Show("请输入操作默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (cmbOperateType.SelectedValue.ToString().Equals("QT"))
                {
                    if (txtLocationDefaultValue.Text == "")
                    {
                        MessageBox.Show("请输入操作默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                var selectIframId = dgvIframes.CurrentRow.Cells["ID"].Value.ToString();
                var dataGridViewRows
                    = dgvLoactionElement.Rows.ToList<DataGridViewRow>();
                var rowSelcet =
                    dataGridViewRows.Where(o => o.Cells["Order"].Value.ToString().Equals(txtLocationOrder.Text))
                        .FirstOrDefault();
                if (rowSelcet != null)
                    if (!rowSelcet.Cells["LocationID"].Value.ToString().Equals(lblLacationGUID.Text))
                        if (
                            MessageBox.Show("当前操作顺序已存在，是否插入添加？", "询问", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) ==
                            DialogResult.OK)
                        {
                            dataGridViewRows.ForEach(p =>
                            {
                                var order = TypeConvert.ToConvert<object, int>(p.Cells["Order"].Value, false);
                                if (order >= TypeConvert.ToConvert<object, int>(txtLocationOrder.Text))
                                    p.Cells["Order"].Value = order + 1;
                            });

                            CreateActionUtil.UpdateElementOrder(dataGridViewRows, txtProdefId.Text, txtChildProdefId.Text,
                                txtActdefId.Text, selectIframId);
                        }
                        else
                        {
                            return;
                        }


                if (lblLacationGUID.Text == "") lblLacationGUID.Text = Guid.NewGuid().ToString();

                var element = new LocationElementEntity();
                element.Id = lblLacationGUID.Text;
                element.LocationType = cmbLocationType.SelectedValue.ToString();
                element.LocationPath = txtLocationPath.Text;
                element.OperateType = cmbOperateType.SelectedValue.ToString();
                element.LocationDefaultValue = txtLocationDefaultValue.Text;
                if (txtLocationDefaultValue.Tag != null)
                {
                    element.SqlSchemaId = txtLocationDefaultValue.Tag.ToString();
                }
                element.Order = txtLocationOrder.Text;
                element.Introduce = txtLocationIntroduce.Text;
              
                element.IsRanddom = chkLocationRandom.Checked;
                element.WaitSecond = string.IsNullOrEmpty(txtOperateTime.Text)
                    ? 0
                    : Convert.ToInt32(txtOperateTime.Text);
                CreateActionUtil.AddElementToXML(selectIframId, element, txtProdefId.Text, txtActdefId.Text,
                    dgvLoactionElement, txtChildProdefId.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbOperateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbOperateType.SelectedValue != null)
                    if (cmbOperateType.SelectedValue.ToString().Equals("SENDKEYS") ||
                        cmbOperateType.SelectedValue.ToString().Equals("FR") ||
                        cmbOperateType.SelectedValue.ToString().Equals("CIRCLESENDKEYS"))
                    {
                        lblOperateText.Text = "赋默认值";
                        btnAddLoactionElementInfo.Enabled = false;
                    }
                    else if (cmbOperateType.SelectedValue.ToString().Equals("QT"))
                    {
                        lblOperateText.Text = "操作脚本";
                        btnAddLoactionElementInfo.Enabled = false;
                    }
                    else if (cmbOperateType.SelectedValue.ToString().Equals("IFRAME"))
                    {
                        btnAddLoactionElementInfo.Enabled = true;
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLoactionElement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLoactionElement.CurrentRow != null)
                {
                    lblLacationGUID.Text = dgvLoactionElement.CurrentRow.Cells["LocationID"].Value.ToString();
                    cmbLocationType.Text = dgvLoactionElement.CurrentRow.Cells["LocationType"].Value.ToString();
                    txtLocationPath.Text = dgvLoactionElement.CurrentRow.Cells["LocationPath"].Value.ToString();
                    cmbOperateType.Text = dgvLoactionElement.CurrentRow.Cells["OperateType"].Value.ToString();
                    txtLocationDefaultValue.Text = dgvLoactionElement.CurrentRow.Cells["DefaultValue"].Value.ToString();
                    txtLocationDefaultValue.Tag = dgvLoactionElement.CurrentRow.Cells["LocationSqlSchemaId"].Value.ToString();
                    txtLocationOrder.Text = dgvLoactionElement.CurrentRow.Cells["Order"].Value.ToString();
                    txtLocationIntroduce.Text = dgvLoactionElement.CurrentRow.Cells["Introduce"].Value.ToString();
                    txtOperateTime.Text = dgvLoactionElement.CurrentRow.Cells["WaitSecond"].Value.ToString();
                    if (dgvLoactionElement.CurrentRow.Cells["IsRandom"].Value.ToString().ToUpper().Equals("TRUE"))
                        chkLocationRandom.Checked = true;
                    else
                        chkLocationRandom.Checked = false;

                    txtLocationDefaultValue_TextChanged(null,null);
                    
                    
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLoactionElement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        ///     添加iframe操作元素
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLoactionElementInfo_Click(object sender, EventArgs e)
        {
            btnSaveElement_Click(sender, e);
            var addChildElement = new FrmAddChildElementInfo();
            addChildElement.ProdefId = txtProdefId.Text;
            addChildElement.ActdefId = txtActdefId.Text;
            addChildElement.ChildProdefId = txtChildProdefId.Text;
            addChildElement.SelectIframeId = dgvIframes.CurrentRow.Cells["ID"].Value.ToString();
            addChildElement.LocationElementId = lblLacationGUID.Text;
            addChildElement.ShowDialog();
        }

        private void txtOperateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
                e.Handled = true;
        }

        private void txtLocationOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == '\b')))
                e.Handled = true;
        }

        private void btnDeleteLocationElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoactionElement.CurrentRow != null)
                    if (MessageBox.Show("确定删除当前操作元素?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        DialogResult.OK)
                    {
                        var iframeId = dgvIframes.CurrentRow.Cells["ID"].Value.ToString();
                        var locationElementId = dgvLoactionElement.CurrentRow.Cells["LocationID"].Value.ToString();
                        CreateActionUtil.DeleteLocationElement(txtProdefId.Text, txtActdefId.Text, iframeId, locationElementId,
                            dgvLoactionElement, txtChildProdefId.Text);
                        btnAddElement_Click(null, null);
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvChildProdef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChildProdef.CurrentRow != null)
                {
                    txtChildProdefId.Text = dgvChildProdef.CurrentRow.Cells["ChildProdefID"].Value.ToString();
                    txtChildProdefName.Text = dgvChildProdef.CurrentRow.Cells["ChildProdefName"].Value.ToString();

                    CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                    btnAddElement_Click(null, null);
                    CreateActionUtil.ReadLocationElement("", txtProdefId.Text, txtActdefId.Text, "", dgvLoactionElement,
                        txtChildProdefId.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeProInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var node = treeProInfo.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    treeProInfo.SelectNode(node, eTreeAction.Mouse);
                    treeProInfo_NodeClick(node, null);
                    if (node.Name.IndexOf("PRODEF_") > -1)
                        menuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        public void LoadChildProdef(string selectChildProdefId)
        {
            try
            {
                StaticValue.LoadProdefList(txtProdefId.Text, dgvChildProdef, selectChildProdefId);
                dgvChildProdef_CellClick(null,null);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 添加方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChildProdef = new FrmAddChildProdef();
            var childProdef = new ChildProdefEntity();
            childProdef.PropackageName = txtPropackageName.Text;
            childProdef.ProdefId = txtProdefId.Text;
            childProdef.ProdefName = txtProdefName.Text;
            childProdef.ChildProdefId = "";
            childProdef.ChildProdefName = "";
            frmChildProdef.ChildProdefInterface = this;
            frmChildProdef.ChildProdef = childProdef;
            frmChildProdef.ShowDialog();
        }

        private void dgvChildProdef_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvChildProdef.Rows[e.RowIndex].Selected = true;
                dgvChildProdef.CurrentCell = dgvChildProdef.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvChildProdef_CellClick(null, null);
                menuSchema.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 修改方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChildProdef = new FrmAddChildProdef();
            var childProdef = new ChildProdefEntity();
            childProdef.PropackageName = txtPropackageName.Text;
            childProdef.ProdefId = txtProdefId.Text;
            childProdef.ProdefName = txtProdefName.Text;
            childProdef.ChildProdefId = dgvChildProdef.CurrentRow.Cells["ChildProdefID"].Value.ToString();
            childProdef.ChildProdefName = dgvChildProdef.CurrentRow.Cells["ChildProdefName"].Value.ToString();
            frmChildProdef.ChildProdefInterface = this;
            frmChildProdef.ChildProdef = childProdef;
            frmChildProdef.ShowDialog();
        }

        private void 删除方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var childProdefId = dgvChildProdef.CurrentRow.Cells["ChildProdefID"].Value.ToString();
                var childProdefName = dgvChildProdef.CurrentRow.Cells["ChildProdefName"].Value.ToString();
                StaticValue.DeleteChildProdefList(txtProdefId.Text, childProdefId);
                LoadChildProdef("");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfigSeleniumSchema_Click(object sender, EventArgs e)
        {
            var seleniumSchemacs = new FrmSeleniumSchemacs();
            seleniumSchemacs.ShowDialog();
        }

        private void btnInhertAdd_Click(object sender, EventArgs e)
        {
            lblLacationGUID.Text = Guid.NewGuid().ToString();
            SetOrder();
        }

        private void SetOrder()
        {
            var dataGridViewRowList
                = dgvLoactionElement.Rows.ToList<DataGridViewRow>();
            if ((dataGridViewRowList != null) && (dataGridViewRowList.Count > 0))
            {
                dataGridViewRowList = dataGridViewRowList.OrderByDescending(
                    t =>
                            TypeConvert.ToConvert<object, int>(t.Cells["Order"].Value, false)
                ).ToList();
                var order = TypeConvert.ToConvert<object, int>(dataGridViewRowList[0].Cells["Order"].Value, false);
                txtLocationOrder.Text = (order + 1).ToString();
            }
            else
            {
                txtLocationOrder.Text = "1";
            }
        }

        private void btnRefreshProdef_Click(object sender, EventArgs e)
        {
            try
            {
                _opaqueCommand.ShowOpaqueLayer(this, 125, true);
                LoadProdefTree();
                txtChildProdefId.Text = "";
                txtChildProdefName.Text = "";
                txtSecondPropackageId.Text = "";
                txtSecondPropackageName.Text = "";
                txtPropackageId.Text = "";
                txtPropackageName.Text = "";
                txtProdefId.Text = "";
                txtProdefName.Text = "";
                txtActdefId.Text = "";
                txtActdefName.Text = "";
                CreateActionUtil.ReadIframe(txtProdefId.Text, txtActdefId.Text, dgvIframes, txtChildProdefId.Text);
                btnAddElement_Click(null, null);
                CreateActionUtil.ReadLocationElement("", txtProdefId.Text, txtActdefId.Text, "", dgvLoactionElement,
                    txtChildProdefId.Text);
                LoadChildProdef("");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLoactionElement_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvLoactionElement.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                var dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - dragSize.Width/2,
                        e.Y - dragSize.Height/2),
                    dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvLoactionElement_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                if ((dragBoxFromMouseDown != Rectangle.Empty) &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    var dropEffect = dgvLoactionElement.DoDragDrop(
                        dgvLoactionElement.Rows[rowIndexFromMouseDown],
                        DragDropEffects.Move);
                }
        }

        private void dgvLoactionElement_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvLoactionElement_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be
            // converted to client coordinates.
            var clientPoint = dgvLoactionElement.PointToClient(new Point(e.X, e.Y));
            var t = rowIndexFromMouseDown;
            // Get the row index of the item the mouse is below.
            rowIndexOfItemUnderMouseToDrop =
                dgvLoactionElement.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexFromMouseDown == rowIndexOfItemUnderMouseToDrop)
                return;
            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                var rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                var id = rowToMove.Cells["LocationID"].Value.ToString();
                var dt = (DataTable) dgvLoactionElement.DataSource;
                var drSelect = dt.AsEnumerable().FirstOrDefault(p => p["LocationID"].ToString().Equals(id));

                var dtNew = dt.Clone();
                try
                {
                    var recCount = dt.Rows.Count;
                    if (rowIndexFromMouseDown < rowIndexOfItemUnderMouseToDrop)
                    {
                        recCount += 1;
                        rowIndexOfItemUnderMouseToDrop += 1;
                    }
                    for (var i = 0; i < recCount; i++)
                    {
                        if (i < dt.Rows.Count)
                            if (dt.Rows[i]["LocationID"].ToString().Equals(id))
                                continue;
                        if (rowIndexOfItemUnderMouseToDrop == i)
                            dtNew.ImportRow(drSelect);
                        if (i < dt.Rows.Count)
                            dtNew.ImportRow(dt.Rows[i]);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dgvLoactionElement.DataSource = dtNew;
                var count = 1;
                dtNew.AsEnumerable().ToList().ForEach(p =>
                {
                    p["Order"] = count;
                    count++;
                });
                if (dtNew.Rows.Count > 0)
                {
                    //默认选中行
                    var dataGridViewRowList
                        = dgvLoactionElement.Rows.ToList<DataGridViewRow>();
                    var dgvSelectRow =
                        dataGridViewRowList
                            .FirstOrDefault(o => o.Cells["LocationID"].Value.ToString().Equals(id));
                    if (dgvSelectRow != null)
                    {
                        dgvSelectRow.Selected = true;
                        dgvLoactionElement.CurrentCell = dgvSelectRow.Cells[0];
                        dgvLoactionElement_CellClick(null, null);
                    }
                    CreateActionUtil.UpdateElementOrder(dataGridViewRowList, txtProdefId.Text, txtChildProdefId.Text,
                        txtActdefId.Text,
                        dgvIframes.CurrentRow.Cells["ID"].Value.ToString());
                }
            }
        }

        private delegate void InvokeHandler();

        private void btnConnection_Click(object sender, EventArgs e)
        {
            var temp = StaticValue.MObjDataSource;
            MessageBox.Show("连接成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void SqlSchemaSelectCallBack(String schemaId, String columnName)
        {
            txtLocationDefaultValue.Text = columnName;
            txtLocationDefaultValue.Tag = schemaId;
            txtLocationDefaultValue_TextChanged(null, null);
        }

        private void txtLocationDefaultValue_DoubleClick(object sender, EventArgs e)
        {
            FrmSelectSchema selectSchema = new FrmSelectSchema();
            selectSchema.SqlSchemaSelectInterface = this;
            selectSchema.OutSqlSchemaId = txtLocationDefaultValue.Tag==null?"":txtLocationDefaultValue.Tag.ToString();
            selectSchema.OutColumnName = txtLocationDefaultValue.Text;
            selectSchema.ShowDialog();
        }

        private void txtLocationDefaultValue_TextChanged(object sender, EventArgs e)
        {
           
            if (txtLocationDefaultValue.Tag != null && txtLocationDefaultValue.Tag!="")
            {
                txtLocationDefaultValue.ForeColor = Color.Red;
                if (sender == null)
                {
                    checkSqlSchema.Checked = true;
                }
            }
            else
            {
                txtLocationDefaultValue.ForeColor = Color.Black;
                if (sender == null)
                {
                    checkSqlSchema.Checked = false; 
                }
            }
        }

        private void checkSqlSchema_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkSqlSchema.Checked)
            {
                txtLocationDefaultValue.Tag = null;
            }
            txtLocationDefaultValue_TextChanged(checkSqlSchema, null);
        }

        private void 复制方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChildProdef.CurrentRow != null)
                {
                    String childProdefId = dgvChildProdef.CurrentRow.Cells["ChildProdefID"].Value.ToString();
                    String selectChildProdefId = StaticValue.CopyProdefSchema(txtProdefId.Text,childProdefId);
                    LoadChildProdef(selectChildProdefId);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 复制到其他流程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Node nodeSelect = treeProInfo.SelectedNode;
                if (nodeSelect != null)
                {
                    ProdefEntity prodefEntity = (ProdefEntity) nodeSelect.Tag;
                    FrmCopyProdefSchema copy=new FrmCopyProdefSchema();
                    copy.ProdefId = prodefEntity.Id;
                    copy.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {

        }

        private void btnCHM_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\操作手册\自动化测试配置工具操作手册.chm");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\操作手册\自动化测试配置工具操作手册.doc");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}