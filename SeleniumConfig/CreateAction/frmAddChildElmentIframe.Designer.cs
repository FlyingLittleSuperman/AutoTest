namespace SeleniumConfig.CreateAction
{
    partial class FrmAddChildElementInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddChildElementInfo));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvChildElement = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ChildLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildIntroduce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildLocationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildLocationPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildOperateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildLocationSqlSchemaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildIsRandom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildWaitSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.lblChildLocationID = new DevComponents.DotNetBar.LabelItem();
            this.btnChildAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnInhertAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnChildSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeleteChildElement = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbChildOperateType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtChildLocationOrder = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChildLacationPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChildLocationDefaultValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbChildLoactionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtChildLocationIntroduce = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkChildLocationRandom = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtChildOperateTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkChildSqlSchema = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvChildElement);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.Controls.Add(this.tableLayoutPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(882, 732);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // dgvChildElement
            // 
            this.dgvChildElement.AllowDrop = true;
            this.dgvChildElement.AllowUserToAddRows = false;
            this.dgvChildElement.AllowUserToDeleteRows = false;
            this.dgvChildElement.AllowUserToResizeColumns = false;
            this.dgvChildElement.AllowUserToResizeRows = false;
            this.dgvChildElement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChildElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChildLocationID,
            this.ChildOrder,
            this.ChildIntroduce,
            this.ChildLocationType,
            this.ChildLocationPath,
            this.ChildOperateType,
            this.ChildDefaultValue,
            this.ChildLocationSqlSchemaId,
            this.ChildIsRandom,
            this.ChildWaitSecond});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChildElement.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChildElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChildElement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChildElement.Location = new System.Drawing.Point(0, 176);
            this.dgvChildElement.Name = "dgvChildElement";
            this.dgvChildElement.RowHeadersVisible = false;
            this.dgvChildElement.RowTemplate.Height = 23;
            this.dgvChildElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildElement.Size = new System.Drawing.Size(882, 556);
            this.dgvChildElement.TabIndex = 3;
            this.dgvChildElement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildElement_CellClick);
            this.dgvChildElement.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvChildElement_DragDrop);
            this.dgvChildElement.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvChildElement_DragOver);
            this.dgvChildElement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvChildElement_MouseDown);
            this.dgvChildElement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvChildElement_MouseMove);
            // 
            // ChildLocationID
            // 
            this.ChildLocationID.DataPropertyName = "ChildLocationID";
            this.ChildLocationID.HeaderText = "内码";
            this.ChildLocationID.Name = "ChildLocationID";
            this.ChildLocationID.Width = 250;
            // 
            // ChildOrder
            // 
            this.ChildOrder.DataPropertyName = "ChildOrder";
            this.ChildOrder.HeaderText = "顺序";
            this.ChildOrder.Name = "ChildOrder";
            // 
            // ChildIntroduce
            // 
            this.ChildIntroduce.DataPropertyName = "ChildIntroduce";
            this.ChildIntroduce.HeaderText = "操作说明";
            this.ChildIntroduce.Name = "ChildIntroduce";
            this.ChildIntroduce.Width = 200;
            // 
            // ChildLocationType
            // 
            this.ChildLocationType.DataPropertyName = "ChildLocationType";
            this.ChildLocationType.HeaderText = "定位方式";
            this.ChildLocationType.Name = "ChildLocationType";
            // 
            // ChildLocationPath
            // 
            this.ChildLocationPath.DataPropertyName = "ChildLocationPath";
            this.ChildLocationPath.HeaderText = "定位路径";
            this.ChildLocationPath.Name = "ChildLocationPath";
            // 
            // ChildOperateType
            // 
            this.ChildOperateType.DataPropertyName = "ChildOperateType";
            this.ChildOperateType.HeaderText = "操作方式";
            this.ChildOperateType.Name = "ChildOperateType";
            // 
            // ChildDefaultValue
            // 
            this.ChildDefaultValue.DataPropertyName = "ChildDefaultValue";
            this.ChildDefaultValue.HeaderText = "默认信息";
            this.ChildDefaultValue.Name = "ChildDefaultValue";
            this.ChildDefaultValue.Width = 250;
            // 
            // ChildLocationSqlSchemaId
            // 
            this.ChildLocationSqlSchemaId.DataPropertyName = "ChildLocationSqlSchemaId";
            this.ChildLocationSqlSchemaId.HeaderText = "SQL方案内码";
            this.ChildLocationSqlSchemaId.Name = "ChildLocationSqlSchemaId";
            // 
            // ChildIsRandom
            // 
            this.ChildIsRandom.DataPropertyName = "ChildIsRandom";
            this.ChildIsRandom.HeaderText = "默认值随机数";
            this.ChildIsRandom.Name = "ChildIsRandom";
            // 
            // ChildWaitSecond
            // 
            this.ChildWaitSecond.DataPropertyName = "ChildWaitSecond";
            this.ChildWaitSecond.HeaderText = "等待时间";
            this.ChildWaitSecond.Name = "ChildWaitSecond";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblChildLocationID,
            this.btnChildAdd,
            this.btnInhertAdd,
            this.btnChildSave,
            this.btnDeleteChildElement});
            this.bar1.Location = new System.Drawing.Point(0, 150);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(882, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // lblChildLocationID
            // 
            this.lblChildLocationID.Name = "lblChildLocationID";
            this.lblChildLocationID.Stretch = true;
            // 
            // btnChildAdd
            // 
            this.btnChildAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChildAdd.Image = global::SeleniumConfig.Properties.Resources.add;
            this.btnChildAdd.Name = "btnChildAdd";
            this.btnChildAdd.Text = "添加元素";
            this.btnChildAdd.Click += new System.EventHandler(this.btnChildAdd_Click);
            // 
            // btnInhertAdd
            // 
            this.btnInhertAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInhertAdd.Image = global::SeleniumConfig.Properties.Resources.application_edit;
            this.btnInhertAdd.Name = "btnInhertAdd";
            this.btnInhertAdd.Text = "继承添加";
            this.btnInhertAdd.Click += new System.EventHandler(this.btnInhertAdd_Click);
            // 
            // btnChildSave
            // 
            this.btnChildSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChildSave.Image = global::SeleniumConfig.Properties.Resources.disk;
            this.btnChildSave.Name = "btnChildSave";
            this.btnChildSave.Text = "保存元素";
            this.btnChildSave.Click += new System.EventHandler(this.btnChildSave_Click);
            // 
            // btnDeleteChildElement
            // 
            this.btnDeleteChildElement.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDeleteChildElement.Image = global::SeleniumConfig.Properties.Resources.delete;
            this.btnDeleteChildElement.Name = "btnDeleteChildElement";
            this.btnDeleteChildElement.Text = "删除元素";
            this.btnDeleteChildElement.Click += new System.EventHandler(this.btnDeleteChildElement_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbChildOperateType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtChildLocationOrder, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtChildLacationPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtChildLocationDefaultValue, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbChildLoactionType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtChildLocationIntroduce, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkChildLocationRandom, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelX7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtChildOperateTime, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkChildSqlSchema, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmbChildOperateType
            // 
            this.cmbChildOperateType.DisplayMember = "Text";
            this.cmbChildOperateType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChildOperateType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChildOperateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChildOperateType.FormattingEnabled = true;
            this.cmbChildOperateType.ItemHeight = 16;
            this.cmbChildOperateType.Location = new System.Drawing.Point(83, 63);
            this.cmbChildOperateType.Name = "cmbChildOperateType";
            this.cmbChildOperateType.Size = new System.Drawing.Size(355, 22);
            this.cmbChildOperateType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbChildOperateType.TabIndex = 13;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(74, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "定位方式";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Location = new System.Drawing.Point(3, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "定位路径";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Location = new System.Drawing.Point(3, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(74, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "操作方式";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX4.Location = new System.Drawing.Point(444, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(74, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "操作顺序";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX6.Location = new System.Drawing.Point(444, 63);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(74, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "默认值";
            // 
            // txtChildLocationOrder
            // 
            // 
            // 
            // 
            this.txtChildLocationOrder.Border.Class = "TextBoxBorder";
            this.txtChildLocationOrder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChildLocationOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChildLocationOrder.Location = new System.Drawing.Point(524, 3);
            this.txtChildLocationOrder.Name = "txtChildLocationOrder";
            this.txtChildLocationOrder.PreventEnterBeep = true;
            this.txtChildLocationOrder.Size = new System.Drawing.Size(355, 21);
            this.txtChildLocationOrder.TabIndex = 7;
            this.txtChildLocationOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChildLocationOrder_KeyPress);
            // 
            // txtChildLacationPath
            // 
            // 
            // 
            // 
            this.txtChildLacationPath.Border.Class = "TextBoxBorder";
            this.txtChildLacationPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.txtChildLacationPath, 3);
            this.txtChildLacationPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChildLacationPath.Location = new System.Drawing.Point(83, 33);
            this.txtChildLacationPath.Name = "txtChildLacationPath";
            this.txtChildLacationPath.PreventEnterBeep = true;
            this.txtChildLacationPath.Size = new System.Drawing.Size(796, 21);
            this.txtChildLacationPath.TabIndex = 8;
            // 
            // txtChildLocationDefaultValue
            // 
            // 
            // 
            // 
            this.txtChildLocationDefaultValue.Border.Class = "TextBoxBorder";
            this.txtChildLocationDefaultValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChildLocationDefaultValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChildLocationDefaultValue.Location = new System.Drawing.Point(524, 63);
            this.txtChildLocationDefaultValue.Name = "txtChildLocationDefaultValue";
            this.txtChildLocationDefaultValue.PreventEnterBeep = true;
            this.txtChildLocationDefaultValue.Size = new System.Drawing.Size(355, 21);
            this.txtChildLocationDefaultValue.TabIndex = 11;
            this.txtChildLocationDefaultValue.DoubleClick += new System.EventHandler(this.txtChildLocationDefaultValue_DoubleClick);
            // 
            // cmbChildLoactionType
            // 
            this.cmbChildLoactionType.DisplayMember = "Text";
            this.cmbChildLoactionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChildLoactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChildLoactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChildLoactionType.FormattingEnabled = true;
            this.cmbChildLoactionType.ItemHeight = 16;
            this.cmbChildLoactionType.Location = new System.Drawing.Point(83, 3);
            this.cmbChildLoactionType.Name = "cmbChildLoactionType";
            this.cmbChildLoactionType.Size = new System.Drawing.Size(355, 22);
            this.cmbChildLoactionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbChildLoactionType.TabIndex = 12;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX5.Location = new System.Drawing.Point(3, 93);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(74, 23);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "操作说明";
            // 
            // txtChildLocationIntroduce
            // 
            // 
            // 
            // 
            this.txtChildLocationIntroduce.Border.Class = "TextBoxBorder";
            this.txtChildLocationIntroduce.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChildLocationIntroduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChildLocationIntroduce.Location = new System.Drawing.Point(83, 93);
            this.txtChildLocationIntroduce.Name = "txtChildLocationIntroduce";
            this.txtChildLocationIntroduce.PreventEnterBeep = true;
            this.txtChildLocationIntroduce.Size = new System.Drawing.Size(355, 21);
            this.txtChildLocationIntroduce.TabIndex = 15;
            // 
            // chkChildLocationRandom
            // 
            // 
            // 
            // 
            this.chkChildLocationRandom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkChildLocationRandom.Location = new System.Drawing.Point(83, 123);
            this.chkChildLocationRandom.Name = "chkChildLocationRandom";
            this.chkChildLocationRandom.Size = new System.Drawing.Size(310, 23);
            this.chkChildLocationRandom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkChildLocationRandom.TabIndex = 16;
            this.chkChildLocationRandom.Text = "默认值是都加随机数";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX7.Location = new System.Drawing.Point(444, 93);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(74, 23);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "等待时间";
            // 
            // txtChildOperateTime
            // 
            // 
            // 
            // 
            this.txtChildOperateTime.Border.Class = "TextBoxBorder";
            this.txtChildOperateTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChildOperateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtChildOperateTime.Location = new System.Drawing.Point(524, 93);
            this.txtChildOperateTime.Name = "txtChildOperateTime";
            this.txtChildOperateTime.PreventEnterBeep = true;
            this.txtChildOperateTime.Size = new System.Drawing.Size(355, 21);
            this.txtChildOperateTime.TabIndex = 18;
            this.txtChildOperateTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChildOperateTime_KeyPress);
            // 
            // chkChildSqlSchema
            // 
            // 
            // 
            // 
            this.chkChildSqlSchema.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkChildSqlSchema.Location = new System.Drawing.Point(3, 123);
            this.chkChildSqlSchema.Name = "chkChildSqlSchema";
            this.chkChildSqlSchema.Size = new System.Drawing.Size(74, 23);
            this.chkChildSqlSchema.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkChildSqlSchema.TabIndex = 19;
            this.chkChildSqlSchema.Text = "SQL方案";
            this.chkChildSqlSchema.CheckedChanged += new System.EventHandler(this.chkChildSqlSchema_CheckedChanged);
            // 
            // FrmAddChildElementInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 732);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddChildElementInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "子页面添加元素";
            this.Load += new System.EventHandler(this.frmAddElementInfo_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChildLocationOrder;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChildLacationPath;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChildLocationDefaultValue;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbChildOperateType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbChildLoactionType;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChildElement;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnChildAdd;
        private DevComponents.DotNetBar.ButtonItem btnChildSave;
        private DevComponents.DotNetBar.LabelItem lblChildLocationID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChildLocationIntroduce;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkChildLocationRandom;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChildOperateTime;
        private DevComponents.DotNetBar.ButtonItem btnDeleteChildElement;
        private DevComponents.DotNetBar.ButtonItem btnInhertAdd;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkChildSqlSchema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildIntroduce;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildLocationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildLocationPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildOperateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildDefaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildLocationSqlSchemaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildIsRandom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildWaitSecond;
    }
}