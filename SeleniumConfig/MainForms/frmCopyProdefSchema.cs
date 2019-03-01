using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using DevComponents.AdvTree;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.loading;
using SeleniumConfig.ProInfo;
using SeleniumConfig.ProInfo.Entity;
using Timer = System.Timers.Timer;

namespace SeleniumConfig.MainForms
{
    public partial class FrmCopyProdefSchema : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCopyProdefSchema()
        {
            InitializeComponent();
        }

        private string _prodefId;

        public string ProdefId
        {
            get { return _prodefId; }
            set { _prodefId = value; }
        }

        private Timer _timer;
        private OpaqueCommand _opaqueCommand = new OpaqueCommand();
        private void FrmCopyProdefSchema_Load(object sender, EventArgs e)
        {
            try
            {
                _opaqueCommand.ShowOpaqueLayer(this, 125, true);
               /* _prodefId = "2d107839-0de3-11e6-b878-000c2984e60c";
                var temp = StaticValue.ServicePath;*/
                StaticValue.LoadProdefList(_prodefId, dgvChildProdef, "");
                LoadProdefTree();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
        private delegate void InvokeHandler();
        private void GetProdefDoWork(object sender, DoWorkEventArgs e)
        {
            //用代理解决子线程访问主线程控件
            Invoke(new InvokeHandler(delegate
            {
                treeProdef.Nodes.Clear();
                Application.DoEvents();
                var nodeRoot = new Node("所有流程");
                nodeRoot.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\package.png");
                nodeRoot.Name = "ROOT_" + Guid.NewGuid();
                nodeRoot.Expanded = true;
                ProTree.CreateProPackage(nodeRoot, "");
                treeProdef.Nodes.Add(nodeRoot);
                _opaqueCommand.HideOpaqueLayer();
            }));
        }

        private void GetProdefCompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void treeProdef_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                Node nodeSelect = treeProdef.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.Name.IndexOf("PROPACKAGE_") > -1)
                    {
                        if (!nodeSelect.HasChildNodes)
                        {
                            PropackageEntity propackageEntity
                                = (PropackageEntity) nodeSelect.Tag;
                            ProTree.CreateProDef(nodeSelect, propackageEntity.Id,true);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private object _obj1;
        private TreeNodeMouseEventArgs _e1;
        private void treeProdef_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            _e1 = e;
            _obj1 = sender;



            try
            {
                Node nodeSelect = treeProdef.SelectedNode;
                if (nodeSelect != null)
                {
                    if (nodeSelect.CheckBoxVisible)
                    {
                        /*if (nodeSelect.Name.IndexOf("PROPACKAGE_") > -1)
                        {
                            bool IsChecked = !nodeSelect.Checked;
                            nodeSelect.Checked = IsChecked;
                            nodeSelect.Nodes.ToList<Node>().ForEach(p =>
                            {
                                p.Checked = IsChecked;
                            });
                        }
                        else if (nodeSelect.Name.IndexOf("PRODEF_") > -1)
                        {
                            bool IsChecked = !nodeSelect.Checked;
                            nodeSelect.Checked = IsChecked;
                            if (!nodeSelect.Checked)
                            {
                                nodeSelect.Parent.Checked = false;
                            }
                        }*/
                    }
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
                    DataGridViewCheckBoxCell
                        cell = (DataGridViewCheckBoxCell)dgvChildProdef.CurrentRow.Cells["Check"];
                    bool isSelect = cell.Value != null && Convert.ToBoolean(cell.Value == DBNull.Value
                                        ? "false"
                                        : cell.Value.ToString());

                    cell.Value = !isSelect;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cheAll_CheckedChanged(object sender, EventArgs e)
        {
            List<DataGridViewRow> dataGridViewRowList
                = dgvChildProdef.Rows.ToList<DataGridViewRow>();
            dataGridViewRowList.ForEach(p =>
            {
                p.Cells["Check"].Value = cheAll.Checked;
            });

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("确定复制方案到指定流程？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.Cancel)
                {
                    return;
                }

                List<DataGridViewRow> dataGridViewRowList
                    = dgvChildProdef.Rows.ToList<DataGridViewRow>();
                dataGridViewRowList =
                    dataGridViewRowList.Where(o => o.Cells["Check"].Value != null && Convert.ToBoolean(o.Cells["Check"].Value == DBNull.Value
                                                       ? "false"
                                                       : o.Cells["Check"].Value.ToString())).ToList();

                if (dataGridViewRowList.Count==0)
                {
                    MessageBox.Show(@"请先选择要复制的方案！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StringBuilder sbError=new StringBuilder();
                String dictoryPath = AppDomain.CurrentDomain.BaseDirectory + @"\XML\";
                dataGridViewRowList.ForEach(p =>
                {
                    String childProdefId = p.Cells["ChildProdefID"].Value.ToString();
                    String filePath = dictoryPath +
                                      string.Format("Prodef_{0}_{1}.xml", _prodefId, childProdefId);
                    if (!File.Exists(filePath))
                    {
                        sbError.AppendFormat("方案{0}还未配置自动化测试信息！\r\n", p.Cells["ChildProdefName"].Value.ToString());

                    }
                });

                if (sbError.Length > 0)
                {
                    MessageBox.Show(sbError.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                List<String> lstSchemaId =
                    dataGridViewRowList.Select(p => p.Cells["ChildProdefID"].Value.ToString()).ToList();

                List<Node> nodeSelectList=new List<Node>();
                foreach (Node node in treeProdef.Nodes)
                {
                    GetAllSelectNode(node, nodeSelectList);
                }

                if (nodeSelectList.Count == 0)
                {
                    MessageBox.Show(@"请选择要复制的流程", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Node nodeOrdinal = nodeSelectList.FirstOrDefault(p => ((ProdefEntity) p.Tag).Id.Equals(_prodefId));
                if (nodeOrdinal != null)
                {
                    MessageBox.Show(string.Format("{0}-{1}流程是被复制对象，请去除勾选！",
                        nodeOrdinal.Text,nodeOrdinal.Parent.Text), @"警告", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }

                StaticValue.CopyProdefSchemaToOtherProdef(_prodefId,lstSchemaId,nodeSelectList);

                MessageBox.Show(@"复制成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 获取所有被勾选的节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="nodeList"></param>
        private void GetAllSelectNode(Node node,List<Node> nodeList )
        {
            if (node.HasChildNodes)
            {
                List<Node> lstChildNodes = node.Nodes.ToList<Node>();
              lstChildNodes.ForEach(p =>
              {
                  if (p.Checked)
                  {
                      if (p.Name.IndexOf("PRODEF_", StringComparison.Ordinal) > -1)
                      {
                          nodeList.Add(p);
                      }
                  }
                  GetAllSelectNode(p,nodeList);
              });
            }
        }
    }
}
