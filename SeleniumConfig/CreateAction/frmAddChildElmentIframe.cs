using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CommonClass.@interface;
using SeleniumConfig.CreateAction.Entity;
using SeleniumConfig.SQLConfig;

namespace SeleniumConfig.CreateAction
{
    public partial class FrmAddChildElementInfo : DevComponents.DotNetBar.Office2007Form,ISqlSchemaSelectInterface
    {
        public FrmAddChildElementInfo()
        {
            InitializeComponent();
        }

        private String _selectIframeId;

        public string SelectIframeId
        {
            get { return _selectIframeId; }
            set { _selectIframeId = value; }
        }

        public string ProdefId
        {
            get { return prodefId; }
            set { prodefId = value; }
        }

        public string LocationElementId
        {
            get { return locationElementId; }
            set { locationElementId = value; }
        }

        public string ActdefId
        {
            get { return actdefId; }
            set { actdefId = value; }
        }

        public string ChildProdefId
        {
            get { return childProdefId; }
            set { childProdefId = value; }
        }

        private String prodefId;
        private String locationElementId;

        private String actdefId;

        private String childProdefId;





        private void btnChildAdd_Click(object sender, EventArgs e)
        {
            cmbChildLoactionType.Text = "";
            cmbChildOperateType.Text = "";
            txtChildLacationPath.Text = "";
            txtChildLocationDefaultValue.Text = "";
            txtChildLocationOrder.Text = "";
            lblChildLocationID.Text = Guid.NewGuid().ToString();
            txtChildLocationIntroduce.Text = "";
            chkChildLocationRandom.Checked = false;
            txtChildOperateTime.Text = "";
            txtChildLocationDefaultValue.Tag = null;
            SetOrder();
        }

        private void frmAddElementInfo_Load(object sender, EventArgs e)
        {
            try
            {
                StaticValue.LoadLocationElementType(cmbChildLoactionType);
                StaticValue.LocadLocationOpearateType(cmbChildOperateType, false);

                //selectIframe = "1c8dd507-0790-4338-9173-0fe90c3df281";
                //childElementId = "6ca7a031-b933-4af3-8360-a1e48539bb7e";
                //prodefId = "pid-ccce3e0a-89e2-453b-a271-1a9f376f8a9b";
                CreateActionUtil.ReadChildLocationElement(_selectIframeId, locationElementId, prodefId, "", dgvChildElement,
                    childProdefId);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChildSave_Click(object sender, EventArgs e)
        {
            try
            {
                //selectIframe = "1c8dd507-0790-4338-9173-0fe90c3df281";
                //childElementId = "6ca7a031-b933-4af3-8360-a1e48539bb7e";
                //prodefId = "pid-ccce3e0a-89e2-453b-a271-1a9f376f8a9b";
                if (cmbChildLoactionType.SelectedValue == null || cmbChildLoactionType.Text == "")
                {
                    MessageBox.Show("请选择定位方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtChildLacationPath.Text == "")
                {
                    MessageBox.Show("请输入定位路径", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbChildOperateType.SelectedValue == null || cmbChildOperateType.Text == "")
                {
                    MessageBox.Show("请选择操作方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtChildLocationOrder.Text.Trim() == "")
                {
                    MessageBox.Show("请输入操作顺序", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtChildLocationIntroduce.Text.Trim() == "")
                {
                    MessageBox.Show("请输入操作说明", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbChildOperateType.SelectedValue.ToString().Equals("SENDKEYS")
                    || cmbChildOperateType.SelectedValue.ToString().Equals("FR") ||
                    cmbChildOperateType.SelectedValue.ToString().Equals("CIRCLESENDKEYS"))
                {
                    if (txtChildLocationDefaultValue.Text == "")
                    {
                        MessageBox.Show("请输入操作默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (cmbChildOperateType.SelectedValue.ToString().Equals("QT"))
                {
                    if (txtChildLocationDefaultValue.Text == "")
                    {
                        MessageBox.Show("请输入操作默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                List<DataGridViewRow> dataGridViewRows
                    = dgvChildElement.Rows.ToList<DataGridViewRow>();
                DataGridViewRow rowSelcet =
                    dataGridViewRows.Where(o => o.Cells["ChildOrder"].Value.ToString().Equals(txtChildLocationOrder.Text))
                        .FirstOrDefault();
                if (rowSelcet != null)
                {

                    

                    if (!rowSelcet.Cells["ChildLocationID"].Value.ToString().Equals(lblChildLocationID.Text))
                    {
                        if (
                            MessageBox.Show("当前操作顺序已存在，是否插入添加？", "询问", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) ==
                            DialogResult.OK)
                        {
                            dataGridViewRows.ForEach(p =>
                            {
                                int order = TypeConvert.ToConvert<object, int>(p.Cells["ChildOrder"].Value, false);
                                if (order >= TypeConvert.ToConvert<object, int>(txtChildLocationOrder.Text))
                                {
                                    p.Cells["ChildOrder"].Value = order + 1;
                                }
                            });

                            CreateActionUtil.UpdateChildElementOrder(dataGridViewRows, prodefId, childProdefId,
                                actdefId, _selectIframeId,locationElementId);
                        }
                        else
                        {
                            return;
                        }
                    }
                }


                if (lblChildLocationID.Text == "") lblChildLocationID.Text = Guid.NewGuid().ToString();
                LocationElementEntity element = new LocationElementEntity();
                element.Id = lblChildLocationID.Text;
                element.LocationType = cmbChildLoactionType.SelectedValue.ToString();
                element.LocationPath = txtChildLacationPath.Text;
                element.OperateType = cmbChildOperateType.SelectedValue.ToString();
                element.LocationDefaultValue = txtChildLocationDefaultValue.Text;
                if (txtChildLocationDefaultValue.Tag != null)
                {
                    element.SqlSchemaId = txtChildLocationDefaultValue.Tag.ToString();
                }
                element.Order = txtChildLocationOrder.Text;
                element.Introduce = txtChildLocationIntroduce.Text;
                element.IsRanddom = chkChildLocationRandom.Checked;
                element.WaitSecond = (String.IsNullOrEmpty(txtChildOperateTime.Text))
                    ? 0
                    : Convert.ToInt32(txtChildOperateTime.Text);
                CreateActionUtil.AddChildElementToXML(_selectIframeId, locationElementId, element, prodefId, actdefId,
                    dgvChildElement,childProdefId);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvChildElement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChildElement.CurrentRow != null)
                {
                    lblChildLocationID.Text = dgvChildElement.CurrentRow.Cells["ChildLocationID"].Value.ToString();
                    cmbChildLoactionType.Text = dgvChildElement.CurrentRow.Cells["ChildLocationType"].Value.ToString();
                    txtChildLacationPath.Text = dgvChildElement.CurrentRow.Cells["ChildLocationPath"].Value.ToString();
                    cmbChildOperateType.Text = dgvChildElement.CurrentRow.Cells["ChildOperateType"].Value.ToString();
                    txtChildLocationDefaultValue.Text = dgvChildElement.CurrentRow.Cells["ChildDefaultValue"].Value.ToString();
                    txtChildLocationOrder.Text = dgvChildElement.CurrentRow.Cells["ChildOrder"].Value.ToString();
                    txtChildLocationIntroduce.Text = dgvChildElement.CurrentRow.Cells["ChildIntroduce"].Value.ToString();
                    txtChildOperateTime.Text = dgvChildElement.CurrentRow.Cells["ChildWaitSecond"].Value.ToString();
                    txtChildLocationDefaultValue.Tag = dgvChildElement.CurrentRow.Cells["ChildLocationSqlSchemaId"].Value.ToString();
                    
                    if (dgvChildElement.CurrentRow.Cells["ChildIsRandom"].Value.ToString().ToUpper().Equals("TRUE"))
                    {
                        chkChildLocationRandom.Checked = true;
                    }
                    else
                    {
                        chkChildLocationRandom.Checked = false;
                    }
                    txtChildLocationDefaultValue_TextChanged(null, null);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtChildOperateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }   
        }

        private void txtChildLocationOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }   
        }

        private void btnDeleteChildElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChildElement.CurrentRow != null)
                {
                    if (MessageBox.Show("确定删除当前元素？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                        DialogResult.OK)
                    {
                        String childLocationElementId
                            = dgvChildElement.CurrentRow.Cells["ChildLocationID"].Value.ToString();
                        CreateActionUtil.DeleteChildLocationElement(prodefId,actdefId,_selectIframeId,locationElementId,childLocationElementId,dgvChildElement,childProdefId);
                        btnChildAdd_Click(null,null);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInhertAdd_Click(object sender, EventArgs e)
        {
            lblChildLocationID.Text = Guid.NewGuid().ToString();
            SetOrder();
        }

        private void SetOrder()
        {
            List<DataGridViewRow> dataGridViewRowList
             = dgvChildElement.Rows.ToList<DataGridViewRow>();
            if (dataGridViewRowList != null && dataGridViewRowList.Count > 0)
            {
                dataGridViewRowList = dataGridViewRowList.OrderByDescending(
                    t =>
                            TypeConvert.ToConvert<object, int>(t.Cells["ChildOrder"].Value, false)
                ).ToList();
                int order = TypeConvert.ToConvert<object, int>(dataGridViewRowList[0].Cells["ChildOrder"].Value, false);
                txtChildLocationOrder.Text = (order + 1).ToString();
            }
            else
            {
                txtChildLocationOrder.Text = "1";
            }
        }
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void dgvChildElement_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvChildElement.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                   dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvChildElement_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvChildElement.DoDragDrop(
                   dgvChildElement.Rows[rowIndexFromMouseDown],
                   DragDropEffects.Move);
                }
            }
        }

        private void dgvChildElement_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be
            // converted to client coordinates.
            Point clientPoint = dgvChildElement.PointToClient(new Point(e.X, e.Y));
            int t = rowIndexFromMouseDown;
            // Get the row index of the item the mouse is below.
            rowIndexOfItemUnderMouseToDrop =
                dgvChildElement.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexFromMouseDown == rowIndexOfItemUnderMouseToDrop)
                return;
            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                String id = rowToMove.Cells["ChildLocationID"].Value.ToString();
                DataTable dt = (DataTable)dgvChildElement.DataSource;
                DataRow drSelect = dt.AsEnumerable().FirstOrDefault(p => p["ChildLocationID"].ToString().Equals(id));

                DataTable dtNew = dt.Clone();
                try
                {
                    int recCount = dt.Rows.Count;
                    if (rowIndexFromMouseDown < rowIndexOfItemUnderMouseToDrop)
                    {
                        recCount += 1;
                        rowIndexOfItemUnderMouseToDrop += 1;
                    }
                    for (int i = 0; i < recCount; i++)
                    {
                        if (i < dt.Rows.Count)
                        {
                            if (dt.Rows[i]["ChildLocationID"].ToString().Equals(id))
                            {
                                continue;
                            }
                        }
                        if (rowIndexOfItemUnderMouseToDrop == i)
                        {
                            dtNew.ImportRow(drSelect);
                        }
                        if (i < dt.Rows.Count)
                        {
                            dtNew.ImportRow(dt.Rows[i]);
                        }

                        dgvChildElement.DataSource = dtNew;
                        int count = 1;
                        dtNew.AsEnumerable().ToList().ForEach(p =>
                        {
                            p["ChildOrder"] = count;
                            count++;
                        });
                        if (dtNew.Rows.Count > 0)
                        {
                            //默认选中行
                            List<DataGridViewRow> dataGridViewRowList
                                = dgvChildElement.Rows.ToList<DataGridViewRow>();
                            DataGridViewRow dgvSelectRow =
                                dataGridViewRowList
                                    .FirstOrDefault(o => o.Cells["ChildLocationID"].Value.ToString().Equals(id));
                            if (dgvSelectRow != null)
                            {
                                dgvSelectRow.Selected = true;
                                dgvChildElement.CurrentCell = dgvSelectRow.Cells[0];
                                dgvChildElement_CellClick(null, null);
                            }
                            CreateActionUtil.UpdateChildElementOrder(dataGridViewRowList, prodefId, childProdefId, actdefId, _selectIframeId, locationElementId);
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               

            }
        }

        private void dgvChildElement_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtChildLocationDefaultValue_DoubleClick(object sender, EventArgs e)
        {
            FrmSelectSchema selectSchema = new FrmSelectSchema();
            selectSchema.SqlSchemaSelectInterface = this;
            selectSchema.OutSqlSchemaId = txtChildLocationDefaultValue.Tag == null ? "" : txtChildLocationDefaultValue.Tag.ToString();
            selectSchema.OutColumnName = txtChildLocationDefaultValue.Text;
            selectSchema.ShowDialog();
        }

        public void SqlSchemaSelectCallBack(String schemaId, String columnName)
        {
            txtChildLocationDefaultValue.Text = columnName;
            txtChildLocationDefaultValue.Tag = schemaId;
            txtChildLocationDefaultValue_TextChanged(null, null);
        }

        private void txtChildLocationDefaultValue_TextChanged(object sender, EventArgs e)
        {

            if (txtChildLocationDefaultValue.Tag != null && txtChildLocationDefaultValue.Tag != "")
            {
                txtChildLocationDefaultValue.ForeColor = Color.Red;
                if (sender == null)
                {
                    chkChildSqlSchema.Checked = true;
                }
            }
            else
            {
                txtChildLocationDefaultValue.ForeColor = Color.Black;
                if (sender == null)
                {
                    chkChildSqlSchema.Checked = false;
                }
            }
        }

        private void chkChildSqlSchema_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkChildSqlSchema.Checked)
            {
                txtChildLocationDefaultValue.Tag = null;
            }
            txtChildLocationDefaultValue_TextChanged(chkChildSqlSchema, null);
        }
    }
}
