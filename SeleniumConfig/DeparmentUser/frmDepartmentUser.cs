using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.AdvTree;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.DeparmentUser.Entity;

namespace SeleniumConfig.DeparmentUser
{
    public partial class FrmDepartmentUser : DevComponents.DotNetBar.Office2007Form
    {
        public FrmDepartmentUser()
        {
            InitializeComponent();
        }

        public IDepartmentInterface DepartmentInterface;
        public IDepartmentInterface TreeInterface
        {
            get { return DepartmentInterface; }
            set { DepartmentInterface = value; }
        }

        public string SelectParentNode
        {
            get { return selectParentNode; }
            set { selectParentNode = value; }
        }

        public string SelectUserNode
        {
            get { return selectUserNode; }
            set { selectUserNode = value; }
        }

        private string selectParentNode;
        
        private string selectUserNode;


        private void frmDepartmentUser_Load(object sender, EventArgs e)
        {
            try
            {
                Node nodeRoot=new Node("所有部门");
                nodeRoot.Name = Guid.NewGuid().ToString();
                nodeRoot.Expanded = true;
                nodeRoot.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\folder.png");
                DepartmentTree.CreateDepartment(treeDepartment, nodeRoot, selectParentNode, selectUserNode);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeDepartment_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            Select();
        }

        private void Select()
        {
            try
            {
                Node nodeSelect = treeDepartment.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("DEPARTMENT_") > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            DepartmentEntity department = (DepartmentEntity)nodeSelect.Tag;
                            DepartmentTree.CreateDepartmentUser(nodeSelect, department.Id,"");
                        }
                    }
                    if (nodeSelect.Name.IndexOf("DEPARTMENTUSER_") > -1)
                    {
                        if (DepartmentInterface != null)
                        {
                            DepartmentUserEntity departmentUser = (DepartmentUserEntity) nodeSelect.Tag;
                            DepartmentEntity department = (DepartmentEntity) nodeSelect.Parent.Tag;
                            DepartmentInterface.DepartmentCallBack(departmentUser, department);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("调用界面没有定义DepartmentCallBack接口,请联系系统管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
