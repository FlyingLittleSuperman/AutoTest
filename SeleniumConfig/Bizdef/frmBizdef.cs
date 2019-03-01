using System;
using System.Windows.Forms;
using DevComponents.AdvTree;
using SeleniumConfig.Bizdef.Entity;
using SeleniumConfig.CommonClass.@interface;

namespace SeleniumConfig.Bizdef
{
    public partial class FrmBizdef : DevComponents.DotNetBar.Office2007Form
    {

        public IBizdefInterface BizdefIntserface;

        public FrmBizdef()
        {
            InitializeComponent();
        }

        public IBizdefInterface Interface
        {
            get { return BizdefIntserface; }
            set { BizdefIntserface = value; }
        }

        private void frmBizdef_Load(object sender, EventArgs e)
        {
            try
            {
                BizdefTree.CreateBizdef(treeBizdef);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeBizdef_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            SelectNode();
        }

        private void SelectNode()
        {
            try
            {
                Node nodeSelect = treeBizdef.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("BIZDEF_") > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            BizdefTree.CreateBizdefForm(nodeSelect, ((Bizdef.Entity.BizdefEntity)nodeSelect.Tag).Id);
                        }
                    }
                    else if (nodeSelect.Name.IndexOf("FORMS_") > -1)
                    {
                        if (BizdefIntserface != null)
                        {
                            BizdefFormEntity bizdefForm = (BizdefFormEntity) nodeSelect.Tag;
                            txtURL.Text = bizdefForm.LinkUrl;
                            BizdefIntserface.BizdefCallBack(bizdefForm);
                        }
                        else
                        {
                            MessageBox.Show("调用界面没有定义BizdefCallBack,请联系系统管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeBizdef_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectNode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeBizdef_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeBizdef.SelectedNode;
                if (nodeSelect == null) return;
                 if (nodeSelect.Name.IndexOf("FORMS_") > -1)
                    {
                        if (BizdefIntserface != null)
                        {
                            BizdefFormEntity bizdefForm = (BizdefFormEntity) nodeSelect.Tag;
                            txtURL.Text = bizdefForm.LinkUrl;
                        }
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
