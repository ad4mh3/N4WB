namespace N4WB_Browser.gui
{
    partial class settings
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
            this.mainContentContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.appearanceContainer = new System.Windows.Forms.GroupBox();
            this.blackM = new System.Windows.Forms.RadioButton();
            this.darkM = new System.Windows.Forms.RadioButton();
            this.lightM = new System.Windows.Forms.RadioButton();
            this.performanceContainer = new System.Windows.Forms.GroupBox();
            this.compattextT = new System.Windows.Forms.CheckBox();
            this.autofreezetabsT = new System.Windows.Forms.CheckBox();
            this.tasksContainer = new System.Windows.Forms.GroupBox();
            this.tasksT = new System.Windows.Forms.CheckBox();
            this.pluginsContainer = new System.Windows.Forms.GroupBox();
            this.imagesT = new System.Windows.Forms.CheckBox();
            this.javascriptT = new System.Windows.Forms.CheckBox();
            this.useragentContainer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.useragentTxt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveSettings = new System.Windows.Forms.Button();
            this.exitWithoutSaving = new System.Windows.Forms.Button();
            this.saveThenExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openTasksInfo = new System.Windows.Forms.LinkLabel();
            this.mainContentContainer.SuspendLayout();
            this.appearanceContainer.SuspendLayout();
            this.performanceContainer.SuspendLayout();
            this.tasksContainer.SuspendLayout();
            this.pluginsContainer.SuspendLayout();
            this.useragentContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContentContainer
            // 
            this.mainContentContainer.ColumnCount = 2;
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.Controls.Add(this.label2, 1, 2);
            this.mainContentContainer.Controls.Add(this.appearanceContainer, 1, 1);
            this.mainContentContainer.Controls.Add(this.performanceContainer, 0, 1);
            this.mainContentContainer.Controls.Add(this.tasksContainer, 2, 0);
            this.mainContentContainer.Controls.Add(this.pluginsContainer, 1, 0);
            this.mainContentContainer.Controls.Add(this.useragentContainer, 0, 0);
            this.mainContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentContainer.Location = new System.Drawing.Point(15, 15);
            this.mainContentContainer.Name = "mainContentContainer";
            this.mainContentContainer.RowCount = 3;
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainContentContainer.Size = new System.Drawing.Size(488, 445);
            this.mainContentContainer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(247, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 149);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please note some settings may require a restart of your browser.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appearanceContainer
            // 
            this.appearanceContainer.Controls.Add(this.blackM);
            this.appearanceContainer.Controls.Add(this.darkM);
            this.appearanceContainer.Controls.Add(this.lightM);
            this.appearanceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appearanceContainer.Location = new System.Drawing.Point(3, 299);
            this.appearanceContainer.Name = "appearanceContainer";
            this.appearanceContainer.Padding = new System.Windows.Forms.Padding(10);
            this.appearanceContainer.Size = new System.Drawing.Size(238, 143);
            this.appearanceContainer.TabIndex = 4;
            this.appearanceContainer.TabStop = false;
            this.appearanceContainer.Text = "Appearance";
            // 
            // blackM
            // 
            this.blackM.AutoSize = true;
            this.blackM.Dock = System.Windows.Forms.DockStyle.Top;
            this.blackM.Location = new System.Drawing.Point(10, 73);
            this.blackM.Name = "blackM";
            this.blackM.Size = new System.Drawing.Size(218, 22);
            this.blackM.TabIndex = 2;
            this.blackM.Text = "Pitch-black";
            this.blackM.UseVisualStyleBackColor = true;
            this.blackM.CheckedChanged += new System.EventHandler(this.lightM_CheckedChanged);
            // 
            // darkM
            // 
            this.darkM.AutoSize = true;
            this.darkM.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkM.Location = new System.Drawing.Point(10, 51);
            this.darkM.Name = "darkM";
            this.darkM.Size = new System.Drawing.Size(218, 22);
            this.darkM.TabIndex = 1;
            this.darkM.Text = "Dark";
            this.darkM.UseVisualStyleBackColor = true;
            this.darkM.CheckedChanged += new System.EventHandler(this.lightM_CheckedChanged);
            // 
            // lightM
            // 
            this.lightM.AutoSize = true;
            this.lightM.Checked = true;
            this.lightM.Dock = System.Windows.Forms.DockStyle.Top;
            this.lightM.Location = new System.Drawing.Point(10, 29);
            this.lightM.Name = "lightM";
            this.lightM.Size = new System.Drawing.Size(218, 22);
            this.lightM.TabIndex = 0;
            this.lightM.TabStop = true;
            this.lightM.Text = "Light";
            this.lightM.UseVisualStyleBackColor = true;
            this.lightM.CheckedChanged += new System.EventHandler(this.lightM_CheckedChanged);
            // 
            // performanceContainer
            // 
            this.performanceContainer.Controls.Add(this.compattextT);
            this.performanceContainer.Controls.Add(this.autofreezetabsT);
            this.performanceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceContainer.Location = new System.Drawing.Point(247, 151);
            this.performanceContainer.Name = "performanceContainer";
            this.performanceContainer.Padding = new System.Windows.Forms.Padding(10);
            this.performanceContainer.Size = new System.Drawing.Size(238, 142);
            this.performanceContainer.TabIndex = 3;
            this.performanceContainer.TabStop = false;
            this.performanceContainer.Text = "Performance";
            // 
            // compattextT
            // 
            this.compattextT.AutoSize = true;
            this.compattextT.Dock = System.Windows.Forms.DockStyle.Top;
            this.compattextT.Location = new System.Drawing.Point(10, 51);
            this.compattextT.Name = "compattextT";
            this.compattextT.Size = new System.Drawing.Size(218, 22);
            this.compattextT.TabIndex = 2;
            this.compattextT.Text = "Use compatible text rendering";
            this.compattextT.UseVisualStyleBackColor = true;
            this.compattextT.CheckedChanged += new System.EventHandler(this.javascriptT_CheckedChanged);
            // 
            // autofreezetabsT
            // 
            this.autofreezetabsT.AutoSize = true;
            this.autofreezetabsT.Dock = System.Windows.Forms.DockStyle.Top;
            this.autofreezetabsT.Location = new System.Drawing.Point(10, 29);
            this.autofreezetabsT.Name = "autofreezetabsT";
            this.autofreezetabsT.Size = new System.Drawing.Size(218, 22);
            this.autofreezetabsT.TabIndex = 1;
            this.autofreezetabsT.Text = "Auto-freeze tabs";
            this.autofreezetabsT.UseVisualStyleBackColor = true;
            this.autofreezetabsT.CheckedChanged += new System.EventHandler(this.javascriptT_CheckedChanged);
            // 
            // tasksContainer
            // 
            this.tasksContainer.Controls.Add(this.label3);
            this.tasksContainer.Controls.Add(this.openTasksInfo);
            this.tasksContainer.Controls.Add(this.tasksT);
            this.tasksContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksContainer.Location = new System.Drawing.Point(3, 151);
            this.tasksContainer.Name = "tasksContainer";
            this.tasksContainer.Padding = new System.Windows.Forms.Padding(10);
            this.tasksContainer.Size = new System.Drawing.Size(238, 142);
            this.tasksContainer.TabIndex = 2;
            this.tasksContainer.TabStop = false;
            this.tasksContainer.Text = "Tasks";
            // 
            // tasksT
            // 
            this.tasksT.AutoSize = true;
            this.tasksT.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksT.Location = new System.Drawing.Point(10, 29);
            this.tasksT.Name = "tasksT";
            this.tasksT.Size = new System.Drawing.Size(218, 22);
            this.tasksT.TabIndex = 1;
            this.tasksT.Text = "Use tasks";
            this.tasksT.UseVisualStyleBackColor = true;
            this.tasksT.CheckedChanged += new System.EventHandler(this.javascriptT_CheckedChanged);
            // 
            // pluginsContainer
            // 
            this.pluginsContainer.Controls.Add(this.imagesT);
            this.pluginsContainer.Controls.Add(this.javascriptT);
            this.pluginsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginsContainer.Location = new System.Drawing.Point(247, 3);
            this.pluginsContainer.Name = "pluginsContainer";
            this.pluginsContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pluginsContainer.Size = new System.Drawing.Size(238, 142);
            this.pluginsContainer.TabIndex = 1;
            this.pluginsContainer.TabStop = false;
            this.pluginsContainer.Text = "Plugins";
            // 
            // imagesT
            // 
            this.imagesT.AutoSize = true;
            this.imagesT.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesT.Location = new System.Drawing.Point(10, 51);
            this.imagesT.Name = "imagesT";
            this.imagesT.Size = new System.Drawing.Size(218, 22);
            this.imagesT.TabIndex = 1;
            this.imagesT.Text = "Images";
            this.imagesT.UseVisualStyleBackColor = true;
            this.imagesT.CheckedChanged += new System.EventHandler(this.javascriptT_CheckedChanged);
            // 
            // javascriptT
            // 
            this.javascriptT.AutoSize = true;
            this.javascriptT.Dock = System.Windows.Forms.DockStyle.Top;
            this.javascriptT.Location = new System.Drawing.Point(10, 29);
            this.javascriptT.Name = "javascriptT";
            this.javascriptT.Size = new System.Drawing.Size(218, 22);
            this.javascriptT.TabIndex = 0;
            this.javascriptT.Text = "Javascript";
            this.javascriptT.UseVisualStyleBackColor = true;
            this.javascriptT.CheckedChanged += new System.EventHandler(this.javascriptT_CheckedChanged);
            // 
            // useragentContainer
            // 
            this.useragentContainer.Controls.Add(this.label1);
            this.useragentContainer.Controls.Add(this.useragentTxt);
            this.useragentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useragentContainer.Location = new System.Drawing.Point(3, 3);
            this.useragentContainer.Name = "useragentContainer";
            this.useragentContainer.Padding = new System.Windows.Forms.Padding(10);
            this.useragentContainer.Size = new System.Drawing.Size(238, 142);
            this.useragentContainer.TabIndex = 0;
            this.useragentContainer.TabStop = false;
            this.useragentContainer.Text = "Useragent";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is used by websites to identify your browser.";
            // 
            // useragentTxt
            // 
            this.useragentTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.useragentTxt.Location = new System.Drawing.Point(10, 29);
            this.useragentTxt.Name = "useragentTxt";
            this.useragentTxt.Size = new System.Drawing.Size(218, 26);
            this.useragentTxt.TabIndex = 1;
            this.useragentTxt.TextChanged += new System.EventHandler(this.useragentTxt_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.saveSettings);
            this.flowLayoutPanel2.Controls.Add(this.exitWithoutSaving);
            this.flowLayoutPanel2.Controls.Add(this.saveThenExit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 460);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(488, 33);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // saveSettings
            // 
            this.saveSettings.AutoSize = true;
            this.saveSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveSettings.Location = new System.Drawing.Point(427, 3);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(58, 27);
            this.saveSettings.TabIndex = 1;
            this.saveSettings.Text = "Apply";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // exitWithoutSaving
            // 
            this.exitWithoutSaving.AutoSize = true;
            this.exitWithoutSaving.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitWithoutSaving.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitWithoutSaving.Location = new System.Drawing.Point(358, 3);
            this.exitWithoutSaving.Name = "exitWithoutSaving";
            this.exitWithoutSaving.Size = new System.Drawing.Size(63, 27);
            this.exitWithoutSaving.TabIndex = 2;
            this.exitWithoutSaving.Text = "Cancel";
            this.exitWithoutSaving.UseVisualStyleBackColor = true;
            this.exitWithoutSaving.Click += new System.EventHandler(this.exitWithoutSaving_Click);
            // 
            // saveThenExit
            // 
            this.saveThenExit.AutoSize = true;
            this.saveThenExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveThenExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveThenExit.Location = new System.Drawing.Point(313, 3);
            this.saveThenExit.Name = "saveThenExit";
            this.saveThenExit.Size = new System.Drawing.Size(39, 27);
            this.saveThenExit.TabIndex = 3;
            this.saveThenExit.Text = "Ok";
            this.saveThenExit.UseVisualStyleBackColor = true;
            this.saveThenExit.Click += new System.EventHandler(this.saveThenExit_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 63);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tasks allow you to perform quick-actions using specific button presses whilst foc" +
    "used on the web address box.";
            // 
            // openTasksInfo
            // 
            this.openTasksInfo.AutoSize = true;
            this.openTasksInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openTasksInfo.Location = new System.Drawing.Point(10, 114);
            this.openTasksInfo.Name = "openTasksInfo";
            this.openTasksInfo.Size = new System.Drawing.Size(78, 18);
            this.openTasksInfo.TabIndex = 4;
            this.openTasksInfo.TabStop = true;
            this.openTasksInfo.Text = "Learn more";
            this.openTasksInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openTasksInfo_LinkClicked);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(518, 508);
            this.Controls.Add(this.mainContentContainer);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "N4WB Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.mainContentContainer.ResumeLayout(false);
            this.appearanceContainer.ResumeLayout(false);
            this.appearanceContainer.PerformLayout();
            this.performanceContainer.ResumeLayout(false);
            this.performanceContainer.PerformLayout();
            this.tasksContainer.ResumeLayout(false);
            this.tasksContainer.PerformLayout();
            this.pluginsContainer.ResumeLayout(false);
            this.pluginsContainer.PerformLayout();
            this.useragentContainer.ResumeLayout(false);
            this.useragentContainer.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContentContainer;
        private System.Windows.Forms.GroupBox appearanceContainer;
        private System.Windows.Forms.GroupBox performanceContainer;
        private System.Windows.Forms.GroupBox tasksContainer;
        private System.Windows.Forms.GroupBox pluginsContainer;
        private System.Windows.Forms.GroupBox useragentContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.RadioButton blackM;
        private System.Windows.Forms.RadioButton darkM;
        private System.Windows.Forms.RadioButton lightM;
        private System.Windows.Forms.CheckBox compattextT;
        private System.Windows.Forms.CheckBox autofreezetabsT;
        private System.Windows.Forms.CheckBox tasksT;
        private System.Windows.Forms.CheckBox imagesT;
        private System.Windows.Forms.CheckBox javascriptT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox useragentTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitWithoutSaving;
        private System.Windows.Forms.Button saveThenExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel openTasksInfo;
    }
}