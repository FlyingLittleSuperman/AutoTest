using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.SQLConfig
{
    public partial class FrmSqlConfig : UserControl,ISqlSchemaInterface
    {
        public FrmSqlConfig()
        {
            InitializeComponent();
        }

        private void FrmSqlConfig_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConfig.LoadSqlSchema(treeSchema,"");
                SqlConfig.LoadTableSspacesToTree(treeTables);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setSelectText(DataGridView dgv)
        {
            txtTableSpaceName.Text = dgv.CurrentRow.Cells["TABLESPACENAME"].Value.ToString();
            txtTableName.Text = dgv.CurrentRow.Cells["TABLEID"].Value.ToString();
        }

        private void 加载表字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvColumns.AutoGenerateColumns = false;
                setSelectText(dgvSelectTable);
                SqlConfig.LoadColumnToDgv(txtSqlSchemaID.Text,txtTableSpaceName.Text, txtTableName.Text, dgvColumns);
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
                List<DataGridViewRow> dataGridViewRowList
                    = dgvColumns.Rows.ToList<DataGridViewRow>();
                dataGridViewRowList
                    = dataGridViewRowList.Where(p => !String.IsNullOrEmpty(p.Cells["FZ"].Value.ToString())).ToList();

                if (dataGridViewRowList.Count == 0)
                {
                    MessageBox.Show("请先编辑保存的信息", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringBuilder sbError=new StringBuilder();
                
                dataGridViewRowList.ForEach(p =>
                {
                    String verifyData = SqlConfig.verifyData(p);
                    if (!String.IsNullOrEmpty(verifyData))
                    {
                        sbError.AppendFormat("{0}\r\n", verifyData);
                    }
                });

                if (sbError.Length > 0)
                {
                    MessageBox.Show(sbError.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                List<SQLConfigEntity> sqlConfigEntities=new List<SQLConfigEntity>();


                dataGridViewRowList.ForEach(p =>
                {
                    sqlConfigEntities.Add(new SQLConfigEntity
                    {
                        ColumnName = p.Cells["COLUMN_NAME"].Value.ToString(),
                        ColumnType = p.Cells["DATA_TYPE_SJ"].Value.ToString(),
                        ColumnLength = p.Cells["DATA_LENGTH"].Value.ToString(),
                        ColumnScale = p.Cells["DATA_SCALE"].Value.ToString(),
                        ColumnValue = p.Cells["FZ"].Value.ToString(),
                        Comments = p.Cells["COMMENTS"].Value.ToString()
                    });
                });
                SqlConfig.saveSchemaColumnInfo(txtSqlSchemaID.Text,txtTableName.Text,sqlConfigEntities);

                dgvSelectTable.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;


                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeSchema_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Node node = treeSchema.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    treeSchema.SelectNode(node, eTreeAction.Mouse);
                    treeSchema_NodeClick(node, null);

                    if (node.Name.IndexOf("ROOT_") > -1)
                    {
                        添加方案ToolStripMenuItem.Enabled = true;
                        修改方案ToolStripMenuItem.Enabled = false;
                    }
                    
                    if (node.Name.IndexOf("SCHEMA_") > -1)
                    {
                        添加方案ToolStripMenuItem.Enabled = false;
                        修改方案ToolStripMenuItem.Enabled = true;
                    }

                    if (node.Name.IndexOf("ROOT_") > -1 || node.Name.IndexOf("SCHEMA_") > -1)
                    {
                        menuSchema.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }
        }

        private void treeSchema_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeSchema.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("SCHEMA_") > -1)
                    {
                        SqlSchemaEntity sqlSchemaEntity = (SqlSchemaEntity) nodeSelect.Tag;
                        txtSqlSchemaID.Text = sqlSchemaEntity.ID;
                        txtSqlSchemaName.Text = sqlSchemaEntity.Name;
                        SqlConfig.LoadSchemaTables(txtSqlSchemaID.Text,dgvSelectTable);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 添加方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSqlSchema addSqlSchema=new FrmAddSqlSchema();
            addSqlSchema.SqlSchemaInterface = this;
            addSqlSchema.ShowDialog();
        }

        private void 修改方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSqlSchema addSqlSchema=new FrmAddSqlSchema();
            Node nodeSelect = treeSchema.SelectedNode;
            if (nodeSelect != null)
            {
                addSqlSchema.SchemaEntity = (SqlSchemaEntity) nodeSelect.Tag;
                addSqlSchema.SqlSchemaInterface = this;
                addSqlSchema.ShowDialog();
            }
        }

        public void SqlSchemaCallBack(SqlSchemaEntity sqlSchemaEntity)
        {
            SqlConfig.LoadSqlSchema(treeSchema,sqlSchemaEntity.ID);
        }

        private void treeTables_Click(object sender, EventArgs e)
        {

        }

        private void treeTables_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeTables.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("TABLESPACE_", StringComparison.Ordinal) > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            SqlConfig.LoadTablesToTree(nodeSelect.Text, nodeSelect);
                        }
                    }

                    //setSelectText(nodeSelect);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void treeSelectTable_MouseDown(object sender, MouseEventArgs e)
        {
           /* if (e.Button == MouseButtons.Right)
            {
                Node node = treeTables.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    treeTables.SelectNode(node, eTreeAction.Mouse);
                    advTables_NodeClick(node, null);
                    if (node.Name.IndexOf("TABLE_") > -1)
                        menuSelectTable.Show(MousePosition.X, MousePosition.Y);
                }
            }*/
        }

        private void treeTables_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Node node = treeTables.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    treeTables.SelectNode(node, eTreeAction.Mouse);
                    if (node.Name.IndexOf("TABLE_") > -1)
                        menuTable.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void 加载到已选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Node nodeSelect = treeTables.SelectedNode;
                if (nodeSelect != null)
                {
                    SqlConfig.saveSchemaTable(txtSqlSchemaID.Text,(TableEntity)nodeSelect.Tag,dgvSelectTable);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeTables_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSelectTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvSelectTable.Rows[e.RowIndex].Selected = true;
                dgvSelectTable.CurrentCell = dgvSelectTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                setSelectText(dgvSelectTable);
                menuSelectTable.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 删除表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSelectTable.CurrentRow == null)
                {
                    MessageBox.Show("请先选择要删除的表！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("确定删除当前表信息？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    if (SqlConfig.deleteTable(txtSqlSchemaID.Text,txtTableSpaceName.Text,
                        txtTableName.Text, dgvSelectTable, dgvColumns))
                    {
                        txtTableName.Text = "";
                        txtTableSpaceName.Text = "";
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 设置关联关系ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTableRelation tableRelation=new FrmTableRelation();
            tableRelation.SqlSchemaId = txtSqlSchemaID.Text;
            tableRelation.ShowDialog();
        }

    }
}
