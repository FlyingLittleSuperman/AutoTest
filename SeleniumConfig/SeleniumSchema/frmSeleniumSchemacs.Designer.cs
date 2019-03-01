namespace SeleniumConfig.SeleniumSchema
{
    partial class FrmSeleniumSchemacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleniumSchemacs));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvSelenium = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtSchemaName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSchemaID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.treeSchemas = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SELECT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PropackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdefName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildProdefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildProdefName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.chkAll = new DevComponents.DotNetBar.CheckBoxItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnExecute = new DevComponents.DotNetBar.ButtonItem();
            this.添加方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设为执行方案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelenium)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeSchemas)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvSelenium);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.treeSchemas);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(810, 516);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgvSelenium
            // 
            this.dgvSelenium.AllowUserToAddRows = false;
            this.dgvSelenium.AllowUserToDeleteRows = false;
            this.dgvSelenium.AllowUserToResizeColumns = false;
            this.dgvSelenium.AllowUserToResizeRows = false;
            this.dgvSelenium.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelenium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelenium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.PropackageName,
            this.ProdefID,
            this.ProdefName,
            this.ChildProdefID,
            this.ChildProdefName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelenium.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelenium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelenium.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSelenium.Location = new System.Drawing.Point(242, 90);
            this.dgvSelenium.Name = "dgvSelenium";
            this.dgvSelenium.RowHeadersVisible = false;
            this.dgvSelenium.RowTemplate.Height = 23;
            this.dgvSelenium.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelenium.Size = new System.Drawing.Size(568, 426);
            this.dgvSelenium.TabIndex = 1;
            this.dgvSelenium.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelenium_CellClick);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtSchemaName);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.txtSchemaID);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(242, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(568, 64);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 3;
            // 
            // txtSchemaName
            // 
            // 
            // 
            // 
            this.txtSchemaName.Border.Class = "TextBoxBorder";
            this.txtSchemaName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchemaName.Enabled = false;
            this.txtSchemaName.Location = new System.Drawing.Point(77, 34);
            this.txtSchemaName.Name = "txtSchemaName";
            this.txtSchemaName.PreventEnterBeep = true;
            this.txtSchemaName.Size = new System.Drawing.Size(479, 21);
            this.txtSchemaName.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(7, 34);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "方案代码";
            // 
            // txtSchemaID
            // 
            // 
            // 
            // 
            this.txtSchemaID.Border.Class = "TextBoxBorder";
            this.txtSchemaID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchemaID.Enabled = false;
            this.txtSchemaID.Location = new System.Drawing.Point(77, 7);
            this.txtSchemaID.Name = "txtSchemaID";
            this.txtSchemaID.PreventEnterBeep = true;
            this.txtSchemaID.Size = new System.Drawing.Size(479, 21);
            this.txtSchemaID.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(7, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "方案名称";
            // 
            // treeSchemas
            // 
            this.treeSchemas.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeSchemas.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeSchemas.BackgroundStyle.Class = "TreeBorderKey";
            this.treeSchemas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeSchemas.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeSchemas.Location = new System.Drawing.Point(0, 0);
            this.treeSchemas.Name = "treeSchemas";
            this.treeSchemas.NodesConnector = this.nodeConnector1;
            this.treeSchemas.NodeStyle = this.elementStyle1;
            this.treeSchemas.PathSeparator = ";";
            this.treeSchemas.Size = new System.Drawing.Size(242, 516);
            this.treeSchemas.Styles.Add(this.elementStyle1);
            this.treeSchemas.TabIndex = 2;
            this.treeSchemas.Text = "advTree1";
            this.treeSchemas.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeSchemas_NodeClick);
            this.treeSchemas.Click += new System.EventHandler(this.treeSchemas_Click);
            this.treeSchemas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeSchemas_MouseDown);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加方案ToolStripMenuItem,
            this.修改方案ToolStripMenuItem,
            this.设为执行方案ToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(149, 70);
            // 
            // SELECT
            // 
            this.SELECT.DataPropertyName = "SELECT";
            this.SELECT.HeaderText = "选中";
            this.SELECT.Name = "SELECT";
            this.SELECT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECT.Width = 50;
            // 
            // PropackageName
            // 
            this.PropackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PropackageName.DataPropertyName = "PropackageName";
            this.PropackageName.HeaderText = "流程包名称";
            this.PropackageName.Name = "PropackageName";
            this.PropackageName.Width = 90;
            // 
            // ProdefID
            // 
            this.ProdefID.DataPropertyName = "ProdefID";
            this.ProdefID.HeaderText = "流程内码";
            this.ProdefID.Name = "ProdefID";
            this.ProdefID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdefID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdefID.Visible = false;
            this.ProdefID.Width = 180;
            // 
            // ProdefName
            // 
            this.ProdefName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProdefName.DataPropertyName = "ProdefName";
            this.ProdefName.HeaderText = "流程名称";
            this.ProdefName.Name = "ProdefName";
            this.ProdefName.ReadOnly = true;
            this.ProdefName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdefName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdefName.Width = 59;
            // 
            // ChildProdefID
            // 
            this.ChildProdefID.DataPropertyName = "ChildProdefID";
            this.ChildProdefID.HeaderText = "方案内码";
            this.ChildProdefID.Name = "ChildProdefID";
            this.ChildProdefID.Visible = false;
            this.ChildProdefID.Width = 180;
            // 
            // ChildProdefName
            // 
            this.ChildProdefName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChildProdefName.DataPropertyName = "ChildProdefName";
            this.ChildProdefName.HeaderText = "方案名称";
            this.ChildProdefName.Name = "ChildProdefName";
            this.ChildProdefName.ReadOnly = true;
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
            this.chkAll,
            this.labelItem2,
            this.btnSave,
            this.btnClose});
            this.bar1.Location = new System.Drawing.Point(242, 64);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(568, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // chkAll
            // 
            this.chkAll.Name = "chkAll";
            this.chkAll.Text = "全选";
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = " ";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Stretch = true;
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExecute});
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(810, 26);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 4;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = global::SeleniumConfig.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Image = global::SeleniumConfig.Properties.Resources.decline;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExecute.Image = global::SeleniumConfig.Properties.Resources.application_osx_start;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Text = "执行自动化测试";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // 添加方案ToolStripMenuItem
            // 
            this.添加方案ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.add;
            this.添加方案ToolStripMenuItem.Name = "添加方案ToolStripMenuItem";
            this.添加方案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加方案ToolStripMenuItem.Text = "添加方案";
            this.添加方案ToolStripMenuItem.Click += new System.EventHandler(this.添加方案ToolStripMenuItem_Click);
            // 
            // 修改方案ToolStripMenuItem
            // 
            this.修改方案ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_edit;
            this.修改方案ToolStripMenuItem.Name = "修改方案ToolStripMenuItem";
            this.修改方案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改方案ToolStripMenuItem.Text = "修改方案";
            this.修改方案ToolStripMenuItem.Click += new System.EventHandler(this.修改方案ToolStripMenuItem_Click);
            // 
            // 设为执行方案ToolStripMenuItem
            // 
            this.设为执行方案ToolStripMenuItem.Image = global::SeleniumConfig.Properties.Resources.application_osx_start;
            this.设为执行方案ToolStripMenuItem.Name = "设为执行方案ToolStripMenuItem";
            this.设为执行方案ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设为执行方案ToolStripMenuItem.Text = "设为执行方案";
            this.设为执行方案ToolStripMenuItem.Click += new System.EventHandler(this.设为执行方案ToolStripMenuItem_Click);
            // 
            // FrmSeleniumSchemacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 542);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.bar2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleniumSchemacs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动化测试方案配置";
            this.Load += new System.EventHandler(this.frmSeleniumSchemacs_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelenium)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeSchemas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSelenium;
        private DevComponents.AdvTree.AdvTree treeSchemas;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加方案ToolStripMenuItem;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchemaName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchemaID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripMenuItem 修改方案ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdefName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildProdefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildProdefName;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CheckBoxItem chkAll;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private System.Windows.Forms.ToolStripMenuItem 设为执行方案ToolStripMenuItem;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnExecute;

    }
}