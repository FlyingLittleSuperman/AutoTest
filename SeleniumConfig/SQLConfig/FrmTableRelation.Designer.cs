namespace SeleniumConfig.SQLConfig
{
    partial class FrmTableRelation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableRelation));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbLColumnName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLTableName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLTableSpaceName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cmbFTableSpaceName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbFTableName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbFColumnName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.dgvTableRealtion = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TableRelationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTableSpaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTableSpaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableRelationValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.lblGUID = new DevComponents.DotNetBar.LabelItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRealtion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.tableLayoutPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(826, 71);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33553F));
            this.tableLayoutPanel1.Controls.Add(this.cmbLColumnName, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLTableName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLTableSpaceName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFTableSpaceName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFTableName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFColumnName, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbLColumnName
            // 
            this.cmbLColumnName.DisplayMember = "Text";
            this.cmbLColumnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLColumnName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLColumnName.FormattingEnabled = true;
            this.cmbLColumnName.ItemHeight = 16;
            this.cmbLColumnName.Location = new System.Drawing.Point(633, 33);
            this.cmbLColumnName.Name = "cmbLColumnName";
            this.cmbLColumnName.Size = new System.Drawing.Size(190, 22);
            this.cmbLColumnName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbLColumnName.TabIndex = 11;
            // 
            // cmbLTableName
            // 
            this.cmbLTableName.DisplayMember = "Text";
            this.cmbLTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLTableName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLTableName.FormattingEnabled = true;
            this.cmbLTableName.ItemHeight = 16;
            this.cmbLTableName.Location = new System.Drawing.Point(358, 33);
            this.cmbLTableName.Name = "cmbLTableName";
            this.cmbLTableName.Size = new System.Drawing.Size(189, 22);
            this.cmbLTableName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbLTableName.TabIndex = 10;
            this.cmbLTableName.SelectedIndexChanged += new System.EventHandler(this.cmbLTableName_SelectedIndexChanged);
            // 
            // cmbLTableSpaceName
            // 
            this.cmbLTableSpaceName.DisplayMember = "Text";
            this.cmbLTableSpaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLTableSpaceName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLTableSpaceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLTableSpaceName.FormattingEnabled = true;
            this.cmbLTableSpaceName.ItemHeight = 16;
            this.cmbLTableSpaceName.Location = new System.Drawing.Point(83, 33);
            this.cmbLTableSpaceName.Name = "cmbLTableSpaceName";
            this.cmbLTableSpaceName.Size = new System.Drawing.Size(189, 22);
            this.cmbLTableSpaceName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbLTableSpaceName.TabIndex = 9;
            this.cmbLTableSpaceName.SelectedIndexChanged += new System.EventHandler(this.cmbLTableSpaceName_SelectedIndexChanged);
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
            this.labelX1.Text = "前表空间";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Location = new System.Drawing.Point(278, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "前表名";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Location = new System.Drawing.Point(553, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(74, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "前字段名";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX4.Location = new System.Drawing.Point(3, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(74, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "后表空间";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX5.Location = new System.Drawing.Point(278, 33);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(74, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "后表名";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX6.Location = new System.Drawing.Point(553, 33);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(74, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "后字段名";
            // 
            // cmbFTableSpaceName
            // 
            this.cmbFTableSpaceName.DisplayMember = "Text";
            this.cmbFTableSpaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFTableSpaceName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFTableSpaceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFTableSpaceName.FormattingEnabled = true;
            this.cmbFTableSpaceName.ItemHeight = 16;
            this.cmbFTableSpaceName.Location = new System.Drawing.Point(83, 3);
            this.cmbFTableSpaceName.Name = "cmbFTableSpaceName";
            this.cmbFTableSpaceName.Size = new System.Drawing.Size(189, 22);
            this.cmbFTableSpaceName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFTableSpaceName.TabIndex = 6;
            this.cmbFTableSpaceName.SelectedIndexChanged += new System.EventHandler(this.cmbFTableSpaceName_SelectedIndexChanged);
            // 
            // cmbFTableName
            // 
            this.cmbFTableName.DisplayMember = "Text";
            this.cmbFTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFTableName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFTableName.FormattingEnabled = true;
            this.cmbFTableName.ItemHeight = 16;
            this.cmbFTableName.Location = new System.Drawing.Point(358, 3);
            this.cmbFTableName.Name = "cmbFTableName";
            this.cmbFTableName.Size = new System.Drawing.Size(189, 22);
            this.cmbFTableName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFTableName.TabIndex = 7;
            this.cmbFTableName.SelectedIndexChanged += new System.EventHandler(this.cmbFTableName_SelectedIndexChanged);
            // 
            // cmbFColumnName
            // 
            this.cmbFColumnName.DisplayMember = "Text";
            this.cmbFColumnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFColumnName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFColumnName.FormattingEnabled = true;
            this.cmbFColumnName.ItemHeight = 16;
            this.cmbFColumnName.Location = new System.Drawing.Point(633, 3);
            this.cmbFColumnName.Name = "cmbFColumnName";
            this.cmbFColumnName.Size = new System.Drawing.Size(190, 22);
            this.cmbFColumnName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFColumnName.TabIndex = 8;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dgvTableRealtion);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 97);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(826, 436);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // dgvTableRealtion
            // 
            this.dgvTableRealtion.AllowUserToAddRows = false;
            this.dgvTableRealtion.AllowUserToDeleteRows = false;
            this.dgvTableRealtion.AllowUserToResizeColumns = false;
            this.dgvTableRealtion.AllowUserToResizeRows = false;
            this.dgvTableRealtion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTableRealtion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableRealtion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableRelationID,
            this.FTableSpaceName,
            this.FTableName,
            this.FColumnName,
            this.LTableSpaceName,
            this.LTableName,
            this.LColumnName,
            this.TableRelationValue});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableRealtion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableRealtion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableRealtion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTableRealtion.Location = new System.Drawing.Point(0, 0);
            this.dgvTableRealtion.Name = "dgvTableRealtion";
            this.dgvTableRealtion.ReadOnly = true;
            this.dgvTableRealtion.RowHeadersVisible = false;
            this.dgvTableRealtion.RowTemplate.Height = 23;
            this.dgvTableRealtion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableRealtion.Size = new System.Drawing.Size(826, 436);
            this.dgvTableRealtion.TabIndex = 0;
            this.dgvTableRealtion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableRealtion_CellClick);
            // 
            // TableRelationID
            // 
            this.TableRelationID.DataPropertyName = "TableRelationID";
            this.TableRelationID.HeaderText = "内码";
            this.TableRelationID.Name = "TableRelationID";
            this.TableRelationID.ReadOnly = true;
            // 
            // FTableSpaceName
            // 
            this.FTableSpaceName.DataPropertyName = "FTableSpaceName";
            this.FTableSpaceName.HeaderText = "FTableSpaceName";
            this.FTableSpaceName.Name = "FTableSpaceName";
            this.FTableSpaceName.ReadOnly = true;
            this.FTableSpaceName.Visible = false;
            // 
            // FTableName
            // 
            this.FTableName.DataPropertyName = "FTableName";
            this.FTableName.HeaderText = "FTableName";
            this.FTableName.Name = "FTableName";
            this.FTableName.ReadOnly = true;
            this.FTableName.Visible = false;
            // 
            // FColumnName
            // 
            this.FColumnName.DataPropertyName = "FColumnName";
            this.FColumnName.HeaderText = "FColumnName";
            this.FColumnName.Name = "FColumnName";
            this.FColumnName.ReadOnly = true;
            this.FColumnName.Visible = false;
            // 
            // LTableSpaceName
            // 
            this.LTableSpaceName.DataPropertyName = "LTableSpaceName";
            this.LTableSpaceName.HeaderText = "LTableSpaceName";
            this.LTableSpaceName.Name = "LTableSpaceName";
            this.LTableSpaceName.ReadOnly = true;
            this.LTableSpaceName.Visible = false;
            // 
            // LTableName
            // 
            this.LTableName.DataPropertyName = "LTableName";
            this.LTableName.HeaderText = "LTableName";
            this.LTableName.Name = "LTableName";
            this.LTableName.ReadOnly = true;
            this.LTableName.Visible = false;
            // 
            // LColumnName
            // 
            this.LColumnName.DataPropertyName = "LColumnName";
            this.LColumnName.HeaderText = "LColumnName";
            this.LColumnName.Name = "LColumnName";
            this.LColumnName.ReadOnly = true;
            this.LColumnName.Visible = false;
            // 
            // TableRelationValue
            // 
            this.TableRelationValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableRelationValue.DataPropertyName = "TableRelationValue";
            this.TableRelationValue.HeaderText = "表达式";
            this.TableRelationValue.Name = "TableRelationValue";
            this.TableRelationValue.ReadOnly = true;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblGUID,
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnClose});
            this.bar1.Location = new System.Drawing.Point(0, 71);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(826, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 11;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // lblGUID
            // 
            this.lblGUID.Name = "lblGUID";
            this.lblGUID.Stretch = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = global::SeleniumConfig.Properties.Resources.add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = global::SeleniumConfig.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = global::SeleniumConfig.Properties.Resources.delete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Image = global::SeleniumConfig.Properties.Resources.decline;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTableRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 533);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTableRelation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "表关联关系创建";
            this.Load += new System.EventHandler(this.FrmTableRelation_Load);
            this.panelEx1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRealtion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLColumnName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLTableName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLTableSpaceName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFTableSpaceName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFTableName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFColumnName;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTableRealtion;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem lblGUID;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableRelationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTableSpaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LTableSpaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableRelationValue;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
    }
}