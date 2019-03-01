using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.SQLConfig
{
    public partial class FrmAddSqlSchema : DevComponents.DotNetBar.Office2007Form
    {
        public FrmAddSqlSchema()
        {
            InitializeComponent();
        }


        private ISqlSchemaInterface _sqlSchemaInterface;

        public ISqlSchemaInterface SqlSchemaInterface
        {
            get { return _sqlSchemaInterface; }
            set { _sqlSchemaInterface = value; }
        }

        public SqlSchemaEntity SchemaEntity
        {
            get { return sqlSchemaEntity; }
            set { sqlSchemaEntity = value; }
        }

        public SqlSchemaEntity sqlSchemaEntity;



        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtSqlSchemaId.Text = Guid.NewGuid().ToString();
            this.txtSqlSchemaName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSqlSchemaName.Text == "")
                {
                    MessageBox.Show("方案名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(sqlSchemaEntity==null)
                    sqlSchemaEntity=new SqlSchemaEntity();
                sqlSchemaEntity.ID = txtSqlSchemaId.Text;
                sqlSchemaEntity.Name = txtSqlSchemaName.Text;

                SqlConfig.saveSqlSchema(sqlSchemaEntity);

                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_sqlSchemaInterface != null)
                {
                    _sqlSchemaInterface.SqlSchemaCallBack(sqlSchemaEntity);
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

        private void FrmAddSqlSchema_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlSchemaEntity != null)
                {
                    txtSqlSchemaId.Text = sqlSchemaEntity.ID;
                    txtSqlSchemaName.Text = sqlSchemaEntity.Name;
                }
                else
                {
                    txtSqlSchemaId.Text = Guid.NewGuid().ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
