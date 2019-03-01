namespace SeleniumConfig.MainForms
{
    partial class FrmCopyProdefSchema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCopyProdefSchema));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cheAll = new System.Windows.Forms.CheckBox();
            this.dgvChildProdef = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ChildProdefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChildProdefName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.treeProdef = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildProdef)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeProdef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cheAll);
            this.panelEx1.Controls.Add(this.dgvChildProdef);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(298, 552);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // cheAll
            // 
            this.cheAll.AutoSize = true;
            this.cheAll.Location = new System.Drawing.Point(20, 3);
            this.cheAll.Name = "cheAll";
            this.cheAll.Size = new System.Drawing.Size(15, 14);
            this.cheAll.TabIndex = 1;
            this.cheAll.UseVisualStyleBackColor = true;
            this.cheAll.CheckedChanged += new System.EventHandler(this.cheAll_CheckedChanged);
            // 
            // dgvChildProdef
            // 
            this.dgvChildProdef.AllowUserToAddRows = false;
            this.dgvChildProdef.AllowUserToDeleteRows = false;
            this.dgvChildProdef.AllowUserToResizeColumns = false;
            this.dgvChildProdef.AllowUserToResizeRows = false;
            this.dgvChildProdef.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChildProdef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildProdef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChildProdefID,
            this.Check,
            this.ChildProdefName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChildProdef.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChildProdef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChildProdef.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChildProdef.Location = new System.Drawing.Point(0, 0);
            this.dgvChildProdef.Name = "dgvChildProdef";
            this.dgvChildProdef.RowHeadersVisible = false;
            this.dgvChildProdef.RowTemplate.Height = 23;
            this.dgvChildProdef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildProdef.Size = new System.Drawing.Size(298, 552);
            this.dgvChildProdef.TabIndex = 0;
            this.dgvChildProdef.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildProdef_CellClick);
            // 
            // ChildProdefID
            // 
            this.ChildProdefID.DataPropertyName = "ChildProdefID";
            this.ChildProdefID.HeaderText = "内码";
            this.ChildProdefID.Name = "ChildProdefID";
            this.ChildProdefID.Visible = false;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.Width = 50;
            // 
            // ChildProdefName
            // 
            this.ChildProdefName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChildProdefName.DataPropertyName = "ChildProdefName";
            this.ChildProdefName.HeaderText = "方案名称";
            this.ChildProdefName.Name = "ChildProdefName";
            this.ChildProdefName.ReadOnly = true;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.treeProdef);
            this.panelEx2.Controls.Add(this.bar1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(298, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(426, 552);
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
            // treeProdef
            // 
            this.treeProdef.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeProdef.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeProdef.BackgroundStyle.Class = "TreeBorderKey";
            this.treeProdef.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeProdef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProdef.Location = new System.Drawing.Point(0, 26);
            this.treeProdef.Name = "treeProdef";
            this.treeProdef.NodesConnector = this.nodeConnector1;
            this.treeProdef.NodeStyle = this.elementStyle1;
            this.treeProdef.PathSeparator = ";";
            this.treeProdef.Size = new System.Drawing.Size(426, 526);
            this.treeProdef.Styles.Add(this.elementStyle1);
            this.treeProdef.TabIndex = 5;
            this.treeProdef.Text = "advTree1";
            this.treeProdef.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeProdef_NodeClick);
            this.treeProdef.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeProdef_NodeDoubleClick);
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
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.btnSave,
            this.btnClose});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(426, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
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
            this.btnSave.Text = "复制";
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
            // FrmCopyProdefSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 552);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCopyProdefSchema";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "复制流程方案";
            this.Load += new System.EventHandler(this.FrmCopyProdefSchema_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildProdef)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeProdef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChildProdef;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.AdvTree.AdvTree treeProdef;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildProdefID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildProdefName;
        private System.Windows.Forms.CheckBox cheAll;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}