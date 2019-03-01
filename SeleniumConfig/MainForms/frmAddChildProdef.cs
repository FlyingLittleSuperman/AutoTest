using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.Forms.Entity;

namespace SeleniumConfig.MainForms
{
    public partial class FrmAddChildProdef : Office2007Form
    {
        public FrmAddChildProdef()
        {
            InitializeComponent();
        }

        public ChildProdefEntity ChildProdef { get; set; }

        public IChildProdefInterface ChildProdefInterface { get; set; }


        private void frmAddChildProdef_Load(object sender, EventArgs e)
        {
            try
            {
                txtPropackageName.Text = ChildProdef.PropackageName;
                txtProdefId.Text = ChildProdef.ProdefId;
                txtProdefName.Text = ChildProdef.ProdefName;
                txtChildProdefId.Text = ChildProdef.ChildProdefId;
                txtChildProdefName.Text = ChildProdef.ChildProdefName;
                if (string.IsNullOrEmpty(txtChildProdefId.Text))
                    txtChildProdefId.Text = Guid.NewGuid().ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChildProdefId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("请输入方案名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChildProdef.ChildProdefId = txtChildProdefId.Text;
                ChildProdef.ChildProdefName = txtChildProdefName.Text;
                StaticValue.SaveChildProdefList(ChildProdef);
                if (ChildProdefInterface != null)
                    ChildProdefInterface.ChildProdefCallBack(ChildProdef);
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtChildProdefId.Text = Guid.NewGuid().ToString();
            txtChildProdefName.Text = "";
        }
    }
}