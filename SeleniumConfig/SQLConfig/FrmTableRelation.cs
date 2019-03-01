using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.SQLConfig
{
    public partial class FrmTableRelation : DevComponents.DotNetBar.Office2007Form
    {
        public FrmTableRelation()
        {
            InitializeComponent();
        }

        private string sqlSchemaId;

        public string SqlSchemaId
        {
            get { return sqlSchemaId; }
            set { sqlSchemaId = value; }
        }


        private void FrmTableRelation_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConfig.LoadHaveSelectTableSpace(sqlSchemaId, cmbFTableSpaceName);
                SqlConfig.LoadHaveSelectTableSpace(sqlSchemaId, cmbLTableSpaceName);
                SqlConfig.LoadSchemaTableRelation(sqlSchemaId,dgvTableRealtion,"");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbFTableSpaceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectTableSpaceName = cmbFTableSpaceName.Text;
                SqlConfig.LoadHaveSelectTable(sqlSchemaId, selectTableSpaceName, cmbFTableName);
               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbLTableSpaceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectTableSpaceName = cmbLTableSpaceName.Text;
                SqlConfig.LoadHaveSelectTable(sqlSchemaId, selectTableSpaceName, cmbLTableName);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbFTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectTableSpaceName = cmbFTableSpaceName.Text;
                String selectTableName = cmbFTableName.Text;
                SqlConfig.LoadHaveSelectColumn(selectTableSpaceName, selectTableName, cmbFColumnName);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbLTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectTableSpaceName = cmbLTableSpaceName.Text;
                String selectTableName = cmbLTableName.Text;
                SqlConfig.LoadHaveSelectColumn(selectTableSpaceName, selectTableName, cmbLColumnName);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFColumnName.Text == "")
                {
                    MessageBox.Show(@"请选择关联前字段信息", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbLColumnName.Text == "")
                {
                    MessageBox.Show(@"请选择关联后字段信息", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TableRelationEntity tableRelationEntity
                    = new TableRelationEntity();
                if (lblGUID.Text == "")
                    lblGUID.Text = Guid.NewGuid().ToString();

                tableRelationEntity.Id = lblGUID.Text;
                tableRelationEntity.FTableSpaceName = cmbFTableSpaceName.SelectedValue.ToString();
                tableRelationEntity.FTableName = cmbFTableName.SelectedValue.ToString();
                tableRelationEntity.FColumnName = cmbFColumnName.SelectedValue.ToString();
                tableRelationEntity.LTableSpaceName = cmbLTableSpaceName.SelectedValue.ToString();
                tableRelationEntity.LTableName = cmbLTableName.SelectedValue.ToString();
                tableRelationEntity.LColumnName = cmbLColumnName.SelectedValue.ToString();

                if (tableRelationEntity.FTableSpaceName.Equals(tableRelationEntity.LTableSpaceName)
                    && tableRelationEntity.FTableName.Equals(tableRelationEntity.LTableName)
                    && tableRelationEntity.FColumnName.Equals(tableRelationEntity.LColumnName))
                {
                    MessageBox.Show("不同关联相同的字段！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tableRelationEntity.FTableSpaceName.Equals(tableRelationEntity.LTableSpaceName)
                    && tableRelationEntity.FTableName.Equals(tableRelationEntity.LTableName))
                {
                    MessageBox.Show("不能关联同一张表的字段！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConfig.saveTableRelation(sqlSchemaId, tableRelationEntity,dgvTableRealtion,lblGUID.Text);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lblGUID.Text = Guid.NewGuid().ToString();
                cmbFTableSpaceName.Text = "";
                cmbLTableSpaceName.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTableRealtion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvSelectRow = dgvTableRealtion.CurrentRow;
                if (dgvSelectRow != null)
                {
                    lblGUID.Text = dgvSelectRow.Cells["TableRelationID"].Value.ToString();

                    String fTableSpaceName =dgvSelectRow.Cells["FTableSpaceName"].Value.ToString();
                    String fTableName = dgvSelectRow.Cells["FTableName"].Value.ToString();
                    String fColumnName = dgvSelectRow.Cells["FColumnName"].Value.ToString();

                    String lTableSpaceName = dgvSelectRow.Cells["LTableSpaceName"].Value.ToString();
                    String lTableName = dgvSelectRow.Cells["LTableName"].Value.ToString();
                    String lColumnName = dgvSelectRow.Cells["LColumnName"].Value.ToString();

                    cmbFTableSpaceName.SelectedValue = fTableSpaceName;
                    cmbLTableSpaceName.SelectedValue = lTableSpaceName;

                    SqlConfig.LoadHaveSelectTable(sqlSchemaId,fTableSpaceName,cmbFTableName);
                    cmbFTableName.SelectedValue = fTableName;
                    SqlConfig.LoadHaveSelectTable(sqlSchemaId, lTableSpaceName, cmbLTableName);
                    cmbLTableName.SelectedValue = lTableName;

                    SqlConfig.LoadHaveSelectColumn(fTableSpaceName, fTableName,cmbFColumnName);
                    cmbFColumnName.SelectedValue = fColumnName;
                    SqlConfig.LoadHaveSelectColumn(lTableSpaceName, lTableName, cmbLColumnName);
                    cmbLColumnName.SelectedValue = lColumnName;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTableRealtion.CurrentRow == null)
                {
                    MessageBox.Show("请先选择要删除的记录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("确定删除当前关联关系？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    String tableRelationId = dgvTableRealtion.CurrentRow.Cells["TableRelationID"].Value.ToString();
                    SqlConfig.deleteTableRelation(sqlSchemaId, tableRelationId, dgvTableRealtion);
                    btnAdd_Click(null,null);
                }
              
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
