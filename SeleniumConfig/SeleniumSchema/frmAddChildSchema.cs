using System;
using System.Windows.Forms;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.SeleniumSchema.Entity;

namespace SeleniumConfig.SeleniumSchema
{
    public partial class FrmAddChildSchema : DevComponents.DotNetBar.Office2007Form
    {
        public FrmAddChildSchema()
        {
            InitializeComponent();
        }
        public ISeleniumSchemaInterface ISeleniumSchemaInterface
        {
            get;
            set;
        }


        private String _schemaId;
        private String _schemaName;

        public string SchemaId
        {
            get { return _schemaId; }
            set { _schemaId = value; }
        }

        public string SchemaName
        {
            get { return _schemaName; }
            set { _schemaName = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void frmAddChildSchema_Load(object sender, EventArgs e)
        {
            try
            {
                txtSchemaID.Text = _schemaId;
                txtSchemaName.Text = _schemaName;
                if (String.IsNullOrEmpty(txtSchemaID.Text))
                {
                    SchemaId = Guid.NewGuid().ToString();
                    txtSchemaID.Text = SchemaId;
                }
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
                if (String.IsNullOrEmpty(txtSchemaName.Text))
                {
                    MessageBox.Show("请输入自动化测试方案名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StaticValue.SaveSeleniumSchema(txtSchemaID.Text,txtSchemaName.Text);
                if (ISeleniumSchemaInterface != null)
                {
                    SeleniumSchemaEntity seleniumSchemaEntity = new SeleniumSchemaEntity();
                    seleniumSchemaEntity.Id = txtSchemaID.Text;
                    seleniumSchemaEntity.Name = txtSchemaName.Text;
                    ISeleniumSchemaInterface.SeleniumSchemaCallBack(seleniumSchemaEntity);
                }
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SchemaId = Guid.NewGuid().ToString();
            txtSchemaID.Text = SchemaId;
            txtSchemaName.Text = "";
        }
    }
}
