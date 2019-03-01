using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.SeleniumSchema.Entity;

namespace SeleniumConfig.SeleniumSchema
{
    public delegate void DelReadStdOutput(string result);

    public delegate void DelReadErrOutput(string result);

    public partial class FrmSeleniumSchemacs : Office2007Form, ISeleniumSchemaInterface
    {
        public FrmSeleniumSchemacs()
        {
            InitializeComponent();
        }


        public void SeleniumSchemaCallBack(SeleniumSchemaEntity seleniumSchemaEntity)
        {
            StaticValue.GetAllSeleniumSchema(treeSchemas, seleniumSchemaEntity.Id);
            LoadSchema(seleniumSchemaEntity);
        }

        private void frmSeleniumSchemacs_Load(object sender, EventArgs e)
        {
            try
            {
                //StaticValue.LoadSeleniumSchema(dgvSelenium);
                StaticValue.GetAllSeleniumSchema(treeSchemas, "");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSelenium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSelenium.CurrentRow != null)
                {
                    var dgvCheck = (DataGridViewCheckBoxCell) dgvSelenium.CurrentRow.Cells["SELECT"];
                    if (dgvCheck.Value.ToString().ToUpper().Equals("TRUE"))
                        dgvCheck.Value = false;
                    else
                        dgvCheck.Value = true;
                }
                ;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeSchemas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var node = treeSchemas.GetNodeAt(e.X, e.Y);
                if (node != null)
                    if ((node.Name.IndexOf("ROOT_") > -1) || (node.Name.IndexOf("SCHEMA_") > -1))
                    {
                        treeSchemas.SelectNode(node, eTreeAction.Mouse);
                        if (node.Name.IndexOf("ROOT_") > -1)
                        {
                            修改方案ToolStripMenuItem.Enabled = false;
                            添加方案ToolStripMenuItem.Enabled = true;
                            设为执行方案ToolStripMenuItem.Enabled = false;
                        }
                        else
                        {
                            修改方案ToolStripMenuItem.Enabled = true;
                            添加方案ToolStripMenuItem.Enabled = false;
                            设为执行方案ToolStripMenuItem.Enabled = true;
                        }
                        SeleniumSchemaEntity seleniumSchemaEntity = null;
                        if (node.Tag != null)
                            seleniumSchemaEntity
                                = (SeleniumSchemaEntity) node.Tag;
                        LoadSchema(seleniumSchemaEntity);

                        menuStrip.Show(MousePosition.X, MousePosition.Y);
                    }
            }
        }

        private void 添加方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addSchema = new FrmAddChildSchema();
                addSchema.SchemaId = "";
                addSchema.SchemaName = "";
                addSchema.ISeleniumSchemaInterface = this;
                addSchema.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 修改方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var nodeSelect = treeSchemas.SelectedNode;
                if (nodeSelect != null)
                    if (nodeSelect.Name.IndexOf("SCHEMA_") > -1)
                    {
                        var seleniumSchemaEntity
                            = (SeleniumSchemaEntity) nodeSelect.Tag;
                        var addSchema = new FrmAddChildSchema();
                        addSchema.SchemaId = seleniumSchemaEntity.Id;
                        addSchema.SchemaName = seleniumSchemaEntity.Name;
                        addSchema.ISeleniumSchemaInterface = this;
                        addSchema.ShowDialog();
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeSchemas_Click(object sender, EventArgs e)
        {
        }

        private void treeSchemas_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                var nodeSelect = treeSchemas.SelectedNode;
                if (nodeSelect != null)
                    if (nodeSelect.Name.IndexOf("SCHEMA_") > -1)
                    {
                        var seleniumSchemaEntity
                            = (SeleniumSchemaEntity) nodeSelect.Tag;
                        LoadSchema(seleniumSchemaEntity);
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadSchema(SeleniumSchemaEntity seleniumSchemaEntity)
        {
            if (seleniumSchemaEntity != null)
            {
                txtSchemaID.Text = seleniumSchemaEntity.Id;
                txtSchemaName.Text = seleniumSchemaEntity.Name;
                StaticValue.LoadSeleniumSchema(dgvSelenium, seleniumSchemaEntity);
            }
            else
            {
                txtSchemaID.Text = "";
                txtSchemaName.Text = "";
            }
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            try
            {
                var dataGridViewRowLists
                    = dgvSelenium.Rows.ToList<DataGridViewRow>();
                dataGridViewRowLists.ForEach(o => { o.Cells["SELECT"].Value = chkAll.Checked; });
                dgvSelenium.Rows[0].Selected = false;
                dgvSelenium.CurrentCell = null;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSchemaID.Text.Trim() == "")
                {
                    MessageBox.Show(@"请先选择方案！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var dataGridViewRowList
                    = dgvSelenium.Rows.ToList<DataGridViewRow>();
                var seleniumSchemaEntityList = new List<SeleniumSchemaEntity>();
                dataGridViewRowList.ForEach(p =>
                {
                    seleniumSchemaEntityList.Add(new SeleniumSchemaEntity
                    {
                        Id = txtSchemaID.Text,
                        Name = txtSchemaName.Text,
                        ProdefId = p.Cells["ProdefID"].Value.ToString(),
                        ProdefName = p.Cells["ProdefName"].Value.ToString(),
                        PropackageName = p.Cells["PropackageName"].Value.ToString(),
                        ChildProdefId = p.Cells["ChildProdefID"].Value.ToString(),
                        ChildProdefName = p.Cells["ChildProdefName"].Value.ToString(),
                        IsSelect =
                            Convert.ToBoolean(p.Cells["SELECT"].Value == DBNull.Value
                                ? "false"
                                : p.Cells["SELECT"].Value)
                    });
                });
                StaticValue.SaveSeleniumSchemaProdef(txtSchemaID.Text, seleniumSchemaEntityList);
                MessageBox.Show(@"保存成功!", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 设为执行方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var nodeSelect = treeSchemas.SelectedNode;
                if (nodeSelect != null)
                    if (nodeSelect.Name.IndexOf("SCHEMA_") > -1)
                    {
                        var seleniumSchemaEntity = (SeleniumSchemaEntity) nodeSelect.Tag;
                        StaticValue.SetExecuteSeleniumSchema(seleniumSchemaEntity);
                        StaticValue.GetAllSeleniumSchema(treeSchemas, seleniumSchemaEntity.Id);
                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var haveExecuteSchema = false;
                if (treeSchemas.Nodes.Count > 0)
                {
                    var nodeRoot = treeSchemas.Nodes[0];
                    foreach (Node node in nodeRoot.Nodes)
                        if (node.Tag != null)
                        {
                            var seleniumSchemaEntity
                                = (SeleniumSchemaEntity) node.Tag;
                            if (seleniumSchemaEntity.IsExecute)
                                haveExecuteSchema = true;
                        }
                }

                if (!haveExecuteSchema)
                {
                    MessageBox.Show("请先配置执行方案！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var javaOutPut = new FrmJAVASeleniumOutPut();
                javaOutPut.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Execute()
        {
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true; //重定向标准错误输出
            p.StartInfo.CreateNoWindow = false; //不显示程序窗口
            p.Start(); //启动程序

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var diskName = path.Substring(0, 1);
            var jarFilePath = path + @"\SeleniumJAVA\Selenium.jar";

            p.StandardInput.AutoFlush = true;
            p.OutputDataReceived += OutputHandler;
            p.BeginOutputReadLine();
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!string.IsNullOrEmpty(outLine.Data))
                Logger.Log.Info(outLine.Data);
        }
    }
}