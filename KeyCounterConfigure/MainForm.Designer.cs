namespace KeyCounter
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCurrentCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCounterOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPollingRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setChangedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.configsTabControl = new System.Windows.Forms.TabControl();
            this.exampleTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.configsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(658, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "newconfig";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "openconfig";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "saveconfig";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "saveconfigas";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewCounterToolStripMenuItem,
            this.removeCurrentCounterToolStripMenuItem,
            this.editCounterOpacityToolStripMenuItem,
            this.editPollingRateToolStripMenuItem,
            this.testToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // createNewCounterToolStripMenuItem
            // 
            this.createNewCounterToolStripMenuItem.Name = "createNewCounterToolStripMenuItem";
            this.createNewCounterToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.createNewCounterToolStripMenuItem.Text = "newcounter";
            this.createNewCounterToolStripMenuItem.Click += new System.EventHandler(this.createNewCounterToolStripMenuItem_Click);
            // 
            // removeCurrentCounterToolStripMenuItem
            // 
            this.removeCurrentCounterToolStripMenuItem.Name = "removeCurrentCounterToolStripMenuItem";
            this.removeCurrentCounterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCurrentCounterToolStripMenuItem.Text = "removecounter";
            this.removeCurrentCounterToolStripMenuItem.Click += new System.EventHandler(this.removeCurrentCounterToolStripMenuItem_Click);
            // 
            // editCounterOpacityToolStripMenuItem
            // 
            this.editCounterOpacityToolStripMenuItem.Name = "editCounterOpacityToolStripMenuItem";
            this.editCounterOpacityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCounterOpacityToolStripMenuItem.Text = "opacity";
            this.editCounterOpacityToolStripMenuItem.Click += new System.EventHandler(this.editCounterOpacityToolStripMenuItem_Click);
            // 
            // editPollingRateToolStripMenuItem
            // 
            this.editPollingRateToolStripMenuItem.Name = "editPollingRateToolStripMenuItem";
            this.editPollingRateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editPollingRateToolStripMenuItem.Text = "pollingrate";
            this.editPollingRateToolStripMenuItem.Click += new System.EventHandler(this.editPollingRateToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "testconfig";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.changelogToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.aboutToolStripMenuItem.Text = "menuabout";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changelogToolStripMenuItem.Text = "changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setChangedToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // setChangedToolStripMenuItem
            // 
            this.setChangedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem,
            this.falseToolStripMenuItem});
            this.setChangedToolStripMenuItem.Name = "setChangedToolStripMenuItem";
            this.setChangedToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.setChangedToolStripMenuItem.Text = "Set changed";
            // 
            // trueToolStripMenuItem
            // 
            this.trueToolStripMenuItem.Name = "trueToolStripMenuItem";
            this.trueToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.trueToolStripMenuItem.Text = "True";
            this.trueToolStripMenuItem.Click += new System.EventHandler(this.trueToolStripMenuItem_Click);
            // 
            // falseToolStripMenuItem
            // 
            this.falseToolStripMenuItem.Name = "falseToolStripMenuItem";
            this.falseToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.falseToolStripMenuItem.Text = "False";
            this.falseToolStripMenuItem.Click += new System.EventHandler(this.falseToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            // 
            // configsTabControl
            // 
            this.configsTabControl.Controls.Add(this.exampleTabPage);
            this.configsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configsTabControl.Location = new System.Drawing.Point(0, 24);
            this.configsTabControl.Name = "configsTabControl";
            this.configsTabControl.SelectedIndex = 0;
            this.configsTabControl.Size = new System.Drawing.Size(658, 342);
            this.configsTabControl.TabIndex = 1;
            // 
            // exampleTabPage
            // 
            this.exampleTabPage.Location = new System.Drawing.Point(4, 22);
            this.exampleTabPage.Name = "exampleTabPage";
            this.exampleTabPage.Size = new System.Drawing.Size(650, 316);
            this.exampleTabPage.TabIndex = 0;
            this.exampleTabPage.Text = "tabPage1";
            this.exampleTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 366);
            this.Controls.Add(this.configsTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "KeyCounter configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.configsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl configsTabControl;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setChangedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCurrentCounterToolStripMenuItem;
        private System.Windows.Forms.TabPage exampleTabPage;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPollingRateToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem editCounterOpacityToolStripMenuItem;
    }
}

