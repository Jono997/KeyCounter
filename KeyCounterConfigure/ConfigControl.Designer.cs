namespace KeyCounter
{
    partial class ConfigControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.counter_startLabel = new System.Windows.Forms.Label();
            this.counter_startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.counter_positionLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.keysListBox = new System.Windows.Forms.ListBox();
            this.counter_positionButton = new System.Windows.Forms.Button();
            this.counter_colourLabel = new System.Windows.Forms.Label();
            this.counter_colourPanel = new System.Windows.Forms.Panel();
            this.counter_colourButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.counter_startNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(451, 20);
            this.nameTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.nameTextBox, "nametooltip");
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(344, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "addkey";
            this.toolTip1.SetToolTip(this.addButton, "addkeytooltip");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(344, 58);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(110, 23);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "modifykey";
            this.toolTip1.SetToolTip(this.modifyButton, "modifykeytooltip");
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(344, 87);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "removekey";
            this.toolTip1.SetToolTip(this.removeButton, "removekeytooltip");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // counter_startLabel
            // 
            this.counter_startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_startLabel.AutoSize = true;
            this.counter_startLabel.Location = new System.Drawing.Point(341, 113);
            this.counter_startLabel.Name = "counter_startLabel";
            this.counter_startLabel.Size = new System.Drawing.Size(53, 13);
            this.counter_startLabel.TabIndex = 4;
            this.counter_startLabel.Text = "startvalue";
            this.toolTip1.SetToolTip(this.counter_startLabel, "startvaluetooltip");
            // 
            // counter_startNumericUpDown
            // 
            this.counter_startNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_startNumericUpDown.Location = new System.Drawing.Point(344, 129);
            this.counter_startNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.counter_startNumericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.counter_startNumericUpDown.Name = "counter_startNumericUpDown";
            this.counter_startNumericUpDown.Size = new System.Drawing.Size(110, 20);
            this.counter_startNumericUpDown.TabIndex = 5;
            this.toolTip1.SetToolTip(this.counter_startNumericUpDown, "startvaluetooltip");
            // 
            // counter_positionLabel
            // 
            this.counter_positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_positionLabel.AutoSize = true;
            this.counter_positionLabel.Location = new System.Drawing.Point(344, 152);
            this.counter_positionLabel.Name = "counter_positionLabel";
            this.counter_positionLabel.Size = new System.Drawing.Size(43, 13);
            this.counter_positionLabel.TabIndex = 6;
            this.counter_positionLabel.Text = "position";
            this.toolTip1.SetToolTip(this.counter_positionLabel, "positiontooltip");
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Location = new System.Drawing.Point(344, 324);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(110, 23);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "testcounter";
            this.toolTip1.SetToolTip(this.testButton, "testcountertooltip");
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // keysListBox
            // 
            this.keysListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keysListBox.FormattingEnabled = true;
            this.keysListBox.Location = new System.Drawing.Point(3, 29);
            this.keysListBox.Name = "keysListBox";
            this.keysListBox.Size = new System.Drawing.Size(335, 316);
            this.keysListBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.keysListBox, "keystooltip");
            this.keysListBox.SelectedIndexChanged += new System.EventHandler(this.keysListBox_SelectedIndexChanged);
            // 
            // counter_positionButton
            // 
            this.counter_positionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_positionButton.Location = new System.Drawing.Point(344, 168);
            this.counter_positionButton.Name = "counter_positionButton";
            this.counter_positionButton.Size = new System.Drawing.Size(110, 23);
            this.counter_positionButton.TabIndex = 11;
            this.counter_positionButton.Text = "configureposition";
            this.toolTip1.SetToolTip(this.counter_positionButton, "positiontooltip");
            this.counter_positionButton.UseVisualStyleBackColor = true;
            this.counter_positionButton.Click += new System.EventHandler(this.counter_positionButton_Click);
            // 
            // counter_colourLabel
            // 
            this.counter_colourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_colourLabel.AutoSize = true;
            this.counter_colourLabel.Location = new System.Drawing.Point(344, 194);
            this.counter_colourLabel.Name = "counter_colourLabel";
            this.counter_colourLabel.Size = new System.Drawing.Size(36, 13);
            this.counter_colourLabel.TabIndex = 12;
            this.counter_colourLabel.Text = "colour";
            this.toolTip1.SetToolTip(this.counter_colourLabel, "colourtooltip");
            // 
            // counter_colourPanel
            // 
            this.counter_colourPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_colourPanel.Location = new System.Drawing.Point(347, 210);
            this.counter_colourPanel.Name = "counter_colourPanel";
            this.counter_colourPanel.Size = new System.Drawing.Size(25, 24);
            this.counter_colourPanel.TabIndex = 13;
            this.toolTip1.SetToolTip(this.counter_colourPanel, "colourtooltip");
            // 
            // counter_colourButton
            // 
            this.counter_colourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_colourButton.Location = new System.Drawing.Point(378, 211);
            this.counter_colourButton.Name = "counter_colourButton";
            this.counter_colourButton.Size = new System.Drawing.Size(76, 23);
            this.counter_colourButton.TabIndex = 14;
            this.counter_colourButton.Text = "configurecolour";
            this.toolTip1.SetToolTip(this.counter_colourButton, "colourtooltip");
            this.counter_colourButton.UseVisualStyleBackColor = true;
            this.counter_colourButton.Click += new System.EventHandler(this.counter_colourButton_Click);
            // 
            // ConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counter_colourButton);
            this.Controls.Add(this.counter_colourPanel);
            this.Controls.Add(this.counter_colourLabel);
            this.Controls.Add(this.counter_positionButton);
            this.Controls.Add(this.keysListBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.counter_positionLabel);
            this.Controls.Add(this.counter_startNumericUpDown);
            this.Controls.Add(this.counter_startLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ConfigControl";
            this.Size = new System.Drawing.Size(457, 350);
            ((System.ComponentModel.ISupportInitialize)(this.counter_startNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label counter_startLabel;
        private System.Windows.Forms.NumericUpDown counter_startNumericUpDown;
        private System.Windows.Forms.Label counter_positionLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ListBox keysListBox;
        private System.Windows.Forms.Button counter_positionButton;
        private System.Windows.Forms.Label counter_colourLabel;
        private System.Windows.Forms.Panel counter_colourPanel;
        private System.Windows.Forms.Button counter_colourButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
