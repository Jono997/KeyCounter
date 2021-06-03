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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.counter_startLabel = new System.Windows.Forms.Label();
            this.counter_startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.counter_positionLabel = new System.Windows.Forms.Label();
            this.counter_position_xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.counter_position_yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.testButton = new System.Windows.Forms.Button();
            this.keysListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.counter_startNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_position_xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_position_yNumericUpDown)).BeginInit();
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
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(344, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
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
            this.modifyButton.Text = "Modify";
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
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // counter_startLabel
            // 
            this.counter_startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_startLabel.AutoSize = true;
            this.counter_startLabel.Location = new System.Drawing.Point(341, 113);
            this.counter_startLabel.Name = "counter_startLabel";
            this.counter_startLabel.Size = new System.Drawing.Size(113, 13);
            this.counter_startLabel.TabIndex = 4;
            this.counter_startLabel.Text = "Counter starting value:";
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
            // 
            // counter_positionLabel
            // 
            this.counter_positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_positionLabel.AutoSize = true;
            this.counter_positionLabel.Location = new System.Drawing.Point(368, 152);
            this.counter_positionLabel.Name = "counter_positionLabel";
            this.counter_positionLabel.Size = new System.Drawing.Size(86, 13);
            this.counter_positionLabel.TabIndex = 6;
            this.counter_positionLabel.Text = "Counter position:";
            // 
            // counter_position_xNumericUpDown
            // 
            this.counter_position_xNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_position_xNumericUpDown.Location = new System.Drawing.Point(344, 168);
            this.counter_position_xNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.counter_position_xNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.counter_position_xNumericUpDown.Name = "counter_position_xNumericUpDown";
            this.counter_position_xNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.counter_position_xNumericUpDown.TabIndex = 7;
            // 
            // counter_position_yNumericUpDown
            // 
            this.counter_position_yNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_position_yNumericUpDown.Location = new System.Drawing.Point(409, 168);
            this.counter_position_yNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.counter_position_yNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.counter_position_yNumericUpDown.Name = "counter_position_yNumericUpDown";
            this.counter_position_yNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.counter_position_yNumericUpDown.TabIndex = 8;
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Location = new System.Drawing.Point(344, 324);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(110, 23);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "Test";
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
            this.keysListBox.SelectedIndexChanged += new System.EventHandler(this.keysListBox_SelectedIndexChanged);
            // 
            // ConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keysListBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.counter_position_yNumericUpDown);
            this.Controls.Add(this.counter_position_xNumericUpDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.counter_position_xNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_position_yNumericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown counter_position_xNumericUpDown;
        private System.Windows.Forms.NumericUpDown counter_position_yNumericUpDown;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ListBox keysListBox;
    }
}
