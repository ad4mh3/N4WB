namespace N4WB_Browser.gui
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tabUI = new System.Windows.Forms.TabControl();
            this.tabOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.invkCloseCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.invkOpenNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.invkFreezeCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.invkUnfreezeCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.goBack = new System.Windows.Forms.Button();
            this.goFrwd = new System.Windows.Forms.Button();
            this.currentTabWebpageTxt = new System.Windows.Forms.TextBox();
            this.newTab = new System.Windows.Forms.Button();
            this.loadNew = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.openSettings = new System.Windows.Forms.Button();
            this.mainTopUIContainer = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.newTabWorker = new System.Windows.Forms.Timer(this.components);
            this.tabOptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.mainTopUIContainer.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUI
            // 
            this.tabUI.ContextMenuStrip = this.tabOptions;
            this.tabUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUI.Location = new System.Drawing.Point(0, 42);
            this.tabUI.Name = "tabUI";
            this.tabUI.SelectedIndex = 0;
            this.tabUI.Size = new System.Drawing.Size(1283, 623);
            this.tabUI.TabIndex = 0;
            this.tabUI.SelectedIndexChanged += new System.EventHandler(this.tabUI_SelectedIndexChanged);
            // 
            // tabOptions
            // 
            this.tabOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invkCloseCurrent,
            this.invkOpenNew,
            this.toolStripSeparator1,
            this.invkFreezeCurrent,
            this.invkUnfreezeCurrent});
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(182, 98);
            // 
            // invkCloseCurrent
            // 
            this.invkCloseCurrent.Name = "invkCloseCurrent";
            this.invkCloseCurrent.Size = new System.Drawing.Size(181, 22);
            this.invkCloseCurrent.Text = "Close current tab";
            this.invkCloseCurrent.Click += new System.EventHandler(this.invkCloseCurrent_Click);
            // 
            // invkOpenNew
            // 
            this.invkOpenNew.Name = "invkOpenNew";
            this.invkOpenNew.Size = new System.Drawing.Size(181, 22);
            this.invkOpenNew.Text = "Open new tab";
            this.invkOpenNew.Click += new System.EventHandler(this.invkOpenNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // invkFreezeCurrent
            // 
            this.invkFreezeCurrent.Name = "invkFreezeCurrent";
            this.invkFreezeCurrent.Size = new System.Drawing.Size(181, 22);
            this.invkFreezeCurrent.Text = "Freeze current tab";
            this.invkFreezeCurrent.Click += new System.EventHandler(this.invkFreezeCurrent_Click);
            // 
            // invkUnfreezeCurrent
            // 
            this.invkUnfreezeCurrent.Name = "invkUnfreezeCurrent";
            this.invkUnfreezeCurrent.Size = new System.Drawing.Size(181, 22);
            this.invkUnfreezeCurrent.Text = "Unfreeze current tab";
            this.invkUnfreezeCurrent.Click += new System.EventHandler(this.invkUnfreezeCurrent_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.goBack);
            this.flowLayoutPanel1.Controls.Add(this.goFrwd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(72, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // goBack
            // 
            this.goBack.AutoSize = true;
            this.goBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goBack.Image = ((System.Drawing.Image)(resources.GetObject("goBack.Image")));
            this.goBack.Location = new System.Drawing.Point(3, 3);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(30, 30);
            this.goBack.TabIndex = 3;
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // goFrwd
            // 
            this.goFrwd.AutoSize = true;
            this.goFrwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goFrwd.Image = ((System.Drawing.Image)(resources.GetObject("goFrwd.Image")));
            this.goFrwd.Location = new System.Drawing.Point(39, 3);
            this.goFrwd.Name = "goFrwd";
            this.goFrwd.Size = new System.Drawing.Size(30, 30);
            this.goFrwd.TabIndex = 4;
            this.goFrwd.UseVisualStyleBackColor = true;
            this.goFrwd.Click += new System.EventHandler(this.goFrwd_Click);
            // 
            // currentTabWebpageTxt
            // 
            this.currentTabWebpageTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTabWebpageTxt.Location = new System.Drawing.Point(50, 5);
            this.currentTabWebpageTxt.Name = "currentTabWebpageTxt";
            this.currentTabWebpageTxt.Size = new System.Drawing.Size(546, 23);
            this.currentTabWebpageTxt.TabIndex = 0;
            this.currentTabWebpageTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentTabWebpageTxt_KeyDown);
            // 
            // newTab
            // 
            this.newTab.AutoSize = true;
            this.newTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newTab.Location = new System.Drawing.Point(59, 3);
            this.newTab.Name = "newTab";
            this.newTab.Size = new System.Drawing.Size(110, 24);
            this.newTab.TabIndex = 1;
            this.newTab.Text = "Open in new tab";
            this.newTab.UseVisualStyleBackColor = true;
            this.newTab.Click += new System.EventHandler(this.newTab_Click);
            // 
            // loadNew
            // 
            this.loadNew.AutoSize = true;
            this.loadNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadNew.Location = new System.Drawing.Point(3, 3);
            this.loadNew.Name = "loadNew";
            this.loadNew.Size = new System.Drawing.Size(50, 24);
            this.loadNew.TabIndex = 2;
            this.loadNew.Text = "Open";
            this.loadNew.UseVisualStyleBackColor = true;
            this.loadNew.Click += new System.EventHandler(this.loadNew_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.openSettings);
            this.flowLayoutPanel2.Controls.Add(this.newTab);
            this.flowLayoutPanel2.Controls.Add(this.loadNew);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1038, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 36);
            this.flowLayoutPanel2.TabIndex = 5;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // openSettings
            // 
            this.openSettings.AutoSize = true;
            this.openSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openSettings.Location = new System.Drawing.Point(175, 3);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(64, 24);
            this.openSettings.TabIndex = 3;
            this.openSettings.Text = "Options";
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // mainTopUIContainer
            // 
            this.mainTopUIContainer.AutoSize = true;
            this.mainTopUIContainer.ColumnCount = 3;
            this.mainTopUIContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTopUIContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTopUIContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTopUIContainer.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.mainTopUIContainer.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.mainTopUIContainer.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.mainTopUIContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopUIContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainTopUIContainer.Location = new System.Drawing.Point(0, 0);
            this.mainTopUIContainer.Name = "mainTopUIContainer";
            this.mainTopUIContainer.RowCount = 1;
            this.mainTopUIContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTopUIContainer.Size = new System.Drawing.Size(1283, 42);
            this.mainTopUIContainer.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.currentTabWebpageTxt);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(257, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(599, 31);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "N4WB";
            // 
            // newTabWorker
            // 
            this.newTabWorker.Enabled = true;
            this.newTabWorker.Tick += new System.EventHandler(this.newTabWorker_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 665);
            this.Controls.Add(this.tabUI);
            this.Controls.Add(this.mainTopUIContainer);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N4WB - Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Shown += new System.EventHandler(this.main_Shown);
            this.tabOptions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.mainTopUIContainer.ResumeLayout(false);
            this.mainTopUIContainer.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox currentTabWebpageTxt;
        private System.Windows.Forms.Button newTab;
        private System.Windows.Forms.ContextMenuStrip tabOptions;
        private System.Windows.Forms.ToolStripMenuItem invkCloseCurrent;
        private System.Windows.Forms.ToolStripMenuItem invkFreezeCurrent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem invkOpenNew;
        private System.Windows.Forms.Button loadNew;
        private System.Windows.Forms.ToolStripMenuItem invkUnfreezeCurrent;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button goFrwd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel mainTopUIContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Timer newTabWorker;
    }
}