namespace KeyCounter
{
    partial class ConfigureKeyForm
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
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.triggerComboBox = new System.Windows.Forms.ComboBox();
            this.triggerLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.actionValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.actionValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actionValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 12);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(46, 13);
            this.keyLabel.TabIndex = 0;
            this.keyLabel.Text = "keylabel";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(58, 9);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(278, 20);
            this.keyTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.keyTextBox, "The key being assigned\r\nPress the key to assign it");
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(12, 65);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(58, 13);
            this.actionLabel.TabIndex = 2;
            this.actionLabel.Text = "actionlabel";
            this.toolTip1.SetToolTip(this.actionLabel, "actiontooltip");
            // 
            // actionComboBox
            // 
            this.actionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(58, 62);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(278, 21);
            this.actionComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.actionComboBox, "actiontooltip");
            this.actionComboBox.SelectedIndexChanged += new System.EventHandler(this.actionComboBox_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(12, 196);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(156, 35);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(174, 196);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(162, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // triggerComboBox
            // 
            this.triggerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerComboBox.FormattingEnabled = true;
            this.triggerComboBox.Location = new System.Drawing.Point(58, 35);
            this.triggerComboBox.Name = "triggerComboBox";
            this.triggerComboBox.Size = new System.Drawing.Size(278, 21);
            this.triggerComboBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.triggerComboBox, "triggertooltip");
            this.triggerComboBox.SelectedIndexChanged += new System.EventHandler(this.triggerComboBox_SelectedIndexChanged);
            // 
            // triggerLabel
            // 
            this.triggerLabel.AutoSize = true;
            this.triggerLabel.Location = new System.Drawing.Point(12, 38);
            this.triggerLabel.Name = "triggerLabel";
            this.triggerLabel.Size = new System.Drawing.Size(58, 13);
            this.triggerLabel.TabIndex = 7;
            this.triggerLabel.Text = "triggerlabel";
            this.toolTip1.SetToolTip(this.triggerLabel, "triggertooltip");
            // 
            // actionValueNumericUpDown
            // 
            this.actionValueNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionValueNumericUpDown.Location = new System.Drawing.Point(58, 89);
            this.actionValueNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.actionValueNumericUpDown.Name = "actionValueNumericUpDown";
            this.actionValueNumericUpDown.Size = new System.Drawing.Size(278, 20);
            this.actionValueNumericUpDown.TabIndex = 8;
            this.toolTip1.SetToolTip(this.actionValueNumericUpDown, "How much the counter increments by when triggered");
            this.actionValueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // actionValueLabel
            // 
            this.actionValueLabel.AutoSize = true;
            this.actionValueLabel.Location = new System.Drawing.Point(12, 91);
            this.actionValueLabel.Name = "actionValueLabel";
            this.actionValueLabel.Size = new System.Drawing.Size(43, 13);
            this.actionValueLabel.TabIndex = 9;
            this.actionValueLabel.Text = "Amount";
            // 
            // ConfigureKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 243);
            this.Controls.Add(this.actionValueLabel);
            this.Controls.Add(this.actionValueNumericUpDown);
            this.Controls.Add(this.triggerLabel);
            this.Controls.Add(this.triggerComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.actionComboBox);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Name = "ConfigureKeyForm";
            this.Text = "Configure key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureKeyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.actionValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox triggerComboBox;
        private System.Windows.Forms.Label triggerLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown actionValueNumericUpDown;
        private System.Windows.Forms.Label actionValueLabel;
    }
}