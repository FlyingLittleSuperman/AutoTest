namespace SeleniumConfig.SQLConfig
{
    partial class FrmSqlConfig
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE_SJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_LENGTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_SCALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTableSpaceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTableName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.方案内码 = new DevComponents.DotNetBar.LabelX();
            this.方案名称 = new DevComponents.DotNetBar.LabelX();
            this.txtSqlSchemaID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSqlSchemaName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.treeTables = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dgvSelectTable = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TABLEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABLEHAVECOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABLESPACENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABLENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSelectTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加载表字段ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置关联关系ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.treeSchema = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.menuSchema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加载到已选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).BeginInit();
            this.menuSelectTable.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeSchema)).BeginInit();
            this.menuSchema.SuspendLayout();
            this.menuTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvColumns);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.Controls.Add(this.tableLayoutPanel1);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(225, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(965, 626);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AllowUserToOrderColumns = true;
            this.dgvColumns.AllowUserToResizeColumns = false;
            this.dgvColumns.AllowUserToResizeRows = false;
            this.dgvColumns.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_NAME,
            this.COMMENTS,
            this.DATA_TYPE,
            this.DATA_TYPE_SJ,
            this.DATA_LENGTH,
            this.DATA_SCALE,
            this.FZ});
            this.dgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumns.Location = new System.Drawing.Point(248, 83);
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowHeadersVisible = false;
            this.dgvColumns.RowTemplate.Height = 23;
            this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvColumns.Size = new System.Drawing.Size(717, 543);
            this.dgvColumns.TabIndex = 2;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "字段名称";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.Width = 80;
            // 
            // COMMENTS
            // 
            this.COMMENTS.DataPropertyName = "COMMENTS";
            this.COMMENTS.HeaderText = "字段描述";
            this.COMMENTS.Name = "COMMENTS";
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.DataPropertyName = "DATA_TYPE";
            this.DATA_TYPE.HeaderText = "字段类型";
            this.DATA_TYPE.Name = "DATA_TYPE";
            // 
            // DATA_TYPE_SJ
            // 
            this.DATA_TYPE_SJ.DataPropertyName = "DATA_TYPE_SJ";
            this.DATA_TYPE_SJ.HeaderText = "实际字段类型";
            this.DATA_TYPE_SJ.Name = "DATA_TYPE_SJ";
            this.DATA_TYPE_SJ.Visible = false;
            // 
            // DATA_LENGTH
            // 
            this.DATA_LENGTH.DataPropertyName = "DATA_LENGTH";
            this.DATA_LENGTH.HeaderText = "字段长度";
            this.DATA_LENGTH.Name = "DATA_LENGTH";
            this.DATA_LENGTH.Visible = false;
            // 
            // DATA_SCALE
            // 
            this.DATA_SCALE.DataPropertyName = "DATA_SCALE";
            this.DATA_SCALE.HeaderText = "字段精度";
            this.DATA_SCALE.Name = "DATA_SCALE";
            this.DATA_SCALE.Visible = false;
            // 
            // FZ
            // 
            this.FZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FZ.DataPropertyName = "FZ";
            this.FZ.HeaderText = "值编辑";
            this.FZ.Name = "FZ";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.btnSave});
            this.bar1.Location = new System.Drawing.Point(248, 57);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(717, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 8;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Stretch = true;
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = global::SeleniumConfig.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtTableSpaceName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTableName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.方案内码, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.方案名称, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSqlSchemaID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSqlSchemaName, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 57);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTableSpaceName
            // 
            // 
            // 
            // 
            this.txtTableSpaceName.Border.Class = "TextBoxBorder";
            this.txtTableSpaceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTableSpaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableSpaceName.Enabled = false;
            this.txtTableSpaceName.Location = new System.Drawing.Point(83, 33);
            this.txtTableSpaceName.Name = "txtTableSpaceName";
            this.txtTableSpaceName.PreventEnterBeep = true;
            this.txtTableSpaceName.Size = new System.Drawing.Size(272, 21);
            this.txtTableSpaceName.TabIndex = 1;
            // 
            // txtTableName
            // 
            // 
            // 
            // 
            this.txtTableName.Border.Class = "TextBoxBorder";
            this.txtTableName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableName.Enabled = false;
            this.txtTableName.Location = new System.Drawing.Point(441, 33);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PreventEnterBeep = true;
            this.txtTableName.Size = new System.Drawing.Size(273, 21);
            this.txtTableName.TabIndex = 3;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX4.Enabled = false;
            this.labelX4.Location = new System.Drawing.Point(361, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(74, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "表名";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Location = new System.Drawing.Point(3, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(74, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "表空间";
            // 
            // 方案内码
            // 
            // 
            // 
            // 
            this.方案内码.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.方案内码.Dock = System.Windows.Forms.DockStyle.Top;
            this.方案内码.Location = new System.Drawing.Point(3, 3);
            this.方案内码.Name = "方案内码";
            this.方案内码.Size = new System.Drawing.Size(74, 23);
            this.方案内码.TabIndex = 6;
            this.方案内码.Text = "方案内码";
            // 
            // 方案名称
            // 
            // 
            // 
            // 
            this.方案名称.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.方案名称.Dock = System.Windows.Forms.DockStyle.Top;
            this.方案名称.Location = new System.Drawing.Point(361, 3);
            this.方案名称.Name = "方案名称";
            this.方案名称.Size = new System.Drawing.Size(74, 23);
            this.方案名称.TabIndex = 7;
            this.方案名称.Text = "方案名称";
            // 
            // txtSqlSchemaID
            // 
            // 
            // 
            // 
            this.txtSqlSchemaID.Border.Class = "TextBoxBorder";
            this.txtSqlSchemaID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSqlSchemaID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSqlSchemaID.Enabled = false;
            this.txtSqlSchemaID.Location = new System.Drawing.Point(83, 3);
            this.txtSqlSchemaID.Name = "txtSqlSchemaID";
            this.txtSqlSchemaID.PreventEnterBeep = true;
            this.txtSqlSchemaID.Size = new System.Drawing.Size(272, 21);
            this.txtSqlSchemaID.TabIndex = 8;
            // 
            // txtSqlSchemaName
            // 
            // 
            // 
            // 
            this.txtSqlSchemaName.Border.Class = "TextBoxBorder";
            this.txtSqlSchemaName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSqlSchemaName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSqlSchemaName.Enabled = false;
            this.txtSqlSchemaName.Location = new System.Drawing.Point(441, 3);
            this.txtSqlSchemaName.Name = "txtSqlSchemaName";
            this.txtSqlSchemaName.PreventEnterBeep = true;
            this.txtSqlSchemaName.Size = new System.Drawing.Size(273, 21);
            this.txtSqlSchemaName.TabIndex = 9;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.treeTables);
            this.panelEx3.Controls.Add(this.dgvSelectTable);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(248, 626);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 10;
            this.panelEx3.Text = "panelEx3";
            // 
            // treeTables
            // 
            this.treeTables.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeTables.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeTables.BackgroundStyle.Class = "TreeBorderKey";
            this.treeTables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTables.Location = new System.Drawing.Point(0, 0);
            this.treeTables.Name = "treeTables";
            this.treeTables.NodesConnector = this.nodeConnector1;
            this.treeTables.NodeStyle = this.elementStyle1;
            this.treeTables.PathSeparator = ";";
            this.treeTables.Size = new System.Drawing.Size(248, 360);
            this.treeTables.Styles.Add(this.elementStyle1);
            this.treeTables.TabIndex = 1;
            this.treeTables.Text = "advTree1";
            this.treeTables.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeTables_NodeClick);
            this.treeTables.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeTables_NodeDoubleClick);
            this.treeTables.Click += new System.EventHandler(this.treeTables_Click);
            this.treeTables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeTables_MouseDown);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // dgvSelectTable
            // 
            this.dgvSelectTable.AllowUserToAddRows = false;
            this.dgvSelectTable.AllowUserToDeleteRows = false;
            this.dgvSelectTable.AllowUserToResizeColumns = false;
            this.dgvSelectTable.AllowUserToResizeRows = false;
            this.dgvSelectTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLEID,
            this.TABLEHAVECOLUMN,
            this.TABLESPACENAME,
            this.TABLENAME});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSelectTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSelectTable.Location = new System.Drawing.Point(0, 360);
            this.dgvSelectTable.Name = "dgvSelectTable";
            this.dgvSelectTable.ReadOnly = true;
            this.dgvSelectTable.RowHeadersVisible = false;
            this.dgvSelectTable.RowTemplate.Height = 23;
            this.dgvSelectTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectTable.Size = new System.Drawing.Size(248, 266);
            this.dgvSelectTable.TabIndex = 2;
            this.dgvSelectTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelectTable_CellMouseDown);
            // 
            // TABLEID
            // 
            this.TABLEID.DataPropertyName = "TABLEID";
            this.TABLEID.HeaderText = "TABLEID";
            this.TABLEID.Name = "TABLEID";
            this.TABLEID.ReadOnly = true;
            this.TABLEID.Visible = false;
            // 
            // TABLEHAVECOLUMN
            // 
            this.TABLEHAVECOLUMN.DataPropertyName = "TABLEHAVECOLUMN";
            this.TABLEHAVECOLUMN.HeaderText = "TABLEHAVECOLUMN";
            this.TABLEHAVECOLUMN.Name = "TABLEHAVECOLUMN";
            this.TABLEHAVECOLUMN.ReadOnly = true;
            this.TABLEHAVECOLUMN.Visible = false;
            // 
            // TABLESPACENAME
            // 
            this.TABLESPACENAME.DataPropertyName = "TABLESPACENAME";
            this.TABLESPACENAME.HeaderText = "表空间";
            this.TABLESPACENAME.Name = "TABLESPACENAME";
            this.TABLESPACENAME.ReadOnly = true;
            this.TABLESPACENAME.Width = 70;
            // 
            // TABLENAME
            // 
            this.TABLENAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TABLENAME.DataPropertyName = "TABLENAME";
            this.TABLENAME.HeaderText = "表名";
            this.TABLENAME.Name = "TABLENAME";
            this.TABLENAME.ReadOnly = true;
            // 
            // menuSelectTable
            // 
            this.menuSelectTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载表字段ToolStripMenuItem,
            this.设置关联关系ToolStripMenuItem,
            this.删除表ToolStripMenuItem});
            this.menuSelectTable.Name = "menuStrip";
            this.menuSelectTable.Size = new System.Drawing.Size(149, 70);
            // 
            // 加载表字段ToolStripMenuItem
            // 
            this.加载表字段ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_add;
            this.加载表字段ToolStripMenuItem.Name = "加载表字段ToolStripMenuItem";
            this.加载表字段ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加载表字段ToolStripMenuItem.Text = "加载表字段";
            this.加载表字段ToolStripMenuItem.Click += new System.EventHandler(this.加载表字段ToolStripMenuItem_Click);
            // 
            // 设置关联关系ToolStripMenuItem
            // 
            this.设置关联关系ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_osx_start;
            this.设置关联关系ToolStripMenuItem.Name = "设置关联关系ToolStripMenuItem";
            this.设置关联关系ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设置关联关系ToolStripMenuItem.Text = "设置关联关系";
            this.设置关联关系ToolStripMenuItem.Click += new System.EventHandler(this.设置关联关系ToolStripMenuItem_Click);
            // 
            // 删除表ToolStripMenuItem
            // 
            this.删除表ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.delete;
            this.删除表ToolStripMenuItem.Name = "删除表ToolStripMenuItem";
            this.删除表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除表ToolStripMenuItem.Text = "删除表";
            this.删除表ToolStripMenuItem.Click += new System.EventHandler(this.删除表ToolStripMenuItem_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.treeSchema);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(225, 626);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            this.panelEx2.Text = "panelEx2";
            // 
            // treeSchema
            // 
            this.treeSchema.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeSchema.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeSchema.BackgroundStyle.Class = "TreeBorderKey";
            this.treeSchema.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSchema.Location = new System.Drawing.Point(0, 0);
            this.treeSchema.Name = "treeSchema";
            this.treeSchema.NodesConnector = this.nodeConnector2;
            this.treeSchema.NodeStyle = this.elementStyle2;
            this.treeSchema.PathSeparator = ";";
            this.treeSchema.Size = new System.Drawing.Size(225, 626);
            this.treeSchema.Styles.Add(this.elementStyle2);
            this.treeSchema.TabIndex = 0;
            this.treeSchema.Text = "advTree1";
            this.treeSchema.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeSchema_NodeClick);
            this.treeSchema.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeSchema_MouseDown);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // menuSchema
            // 
            this.menuSchema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加方案ToolStripMenuItem,
            this.修改方案ToolStripMenuItem});
            this.menuSchema.Name = "menuSchema";
            this.menuSchema.Size = new System.Drawing.Size(125, 48);
            // 
            // 添加方案ToolStripMenuItem
            // 
            this.添加方案ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.add;
            this.添加方案ToolStripMenuItem.Name = "添加方案ToolStripMenuItem";
            this.添加方案ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加方案ToolStripMenuItem.Text = "添加方案";
            this.添加方案ToolStripMenuItem.Click += new System.EventHandler(this.添加方案ToolStripMenuItem_Click);
            // 
            // 修改方案ToolStripMenuItem
            // 
            this.修改方案ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_edit;
            this.修改方案ToolStripMenuItem.Name = "修改方案ToolStripMenuItem";
            this.修改方案ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改方案ToolStripMenuItem.Text = "修改方案";
            this.修改方案ToolStripMenuItem.Click += new System.EventHandler(this.修改方案ToolStripMenuItem_Click);
            // 
            // menuTable
            // 
            this.menuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载到已选中ToolStripMenuItem});
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(149, 26);
            // 
            // 加载到已选中ToolStripMenuItem
            // 
            this.加载到已选中ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_add;
            this.加载到已选中ToolStripMenuItem.Name = "加载到已选中ToolStripMenuItem";
            this.加载到已选中ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加载到已选中ToolStripMenuItem.Text = "加载到已选中";
            this.加载到已选中ToolStripMenuItem.Click += new System.EventHandler(this.加载到已选中ToolStripMenuItem_Click);
            // 
            // FrmSqlConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Name = "FrmSqlConfig";
            this.Size = new System.Drawing.Size(1190, 626);
            this.Load += new System.EventHandler(this.FrmSqlConfig_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).EndInit();
            this.menuSelectTable.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeSchema)).EndInit();
            this.menuSchema.ResumeLayout(false);
            this.menuTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTableName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTableSpaceName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ContextMenuStrip menuSelectTable;
        private System.Windows.Forms.ToolStripMenuItem 加载表字段ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvColumns;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.AdvTree.AdvTree treeSchema;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private System.Windows.Forms.ContextMenuStrip menuSchema;
        private System.Windows.Forms.ToolStripMenuItem 添加方案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改方案ToolStripMenuItem;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.AdvTree.AdvTree treeTables;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ContextMenuStrip menuTable;
        private System.Windows.Forms.ToolStripMenuItem 加载到已选中ToolStripMenuItem;
        private DevComponents.DotNetBar.LabelX 方案内码;
        private DevComponents.DotNetBar.LabelX 方案名称;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSqlSchemaID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSqlSchemaName;
        private System.Windows.Forms.ToolStripMenuItem 删除表ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSelectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE_SJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_LENGTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_SCALE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FZ;
        private System.Windows.Forms.ToolStripMenuItem 设置关联关系ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLEHAVECOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLESPACENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLENAME;
    }
}