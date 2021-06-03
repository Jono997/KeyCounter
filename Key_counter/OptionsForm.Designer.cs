namespace Key_counter
{
    partial class OptionsForm
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
            this.keyListBox = new System.Windows.Forms.ListBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.add_keyButton = new System.Windows.Forms.Button();
            this.remove_keyButton = new System.Windows.Forms.Button();
            this.key_roleComboBox = new System.Windows.Forms.ComboBox();
            this.counter_startLabel = new System.Windows.Forms.Label();
            this.counter_startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.counter_startNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // keyListBox
            // 
            this.keyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyListBox.FormattingEnabled = true;
            this.keyListBox.Location = new System.Drawing.Point(12, 12);
            this.keyListBox.Name = "keyListBox";
            this.keyListBox.Size = new System.Drawing.Size(321, 316);
            this.keyListBox.TabIndex = 0;
            this.keyListBox.SelectedIndexChanged += new System.EventHandler(this.keyListBox_SelectedIndexChanged);
            // 
            // keyLabel
            // 
            this.keyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(336, 12);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.keyTextBox.Location = new System.Drawing.Point(339, 29);
            this.keyTextBox.MaxLength = 100;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(107, 20);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // add_keyButton
            // 
            this.add_keyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_keyButton.Enabled = false;
            this.add_keyButton.Location = new System.Drawing.Point(339, 84);
            this.add_keyButton.Name = "add_keyButton";
            this.add_keyButton.Size = new System.Drawing.Size(107, 23);
            this.add_keyButton.TabIndex = 3;
            this.add_keyButton.Text = "Add";
            this.add_keyButton.UseVisualStyleBackColor = true;
            this.add_keyButton.Click += new System.EventHandler(this.add_keyButton_Click);
            // 
            // remove_keyButton
            // 
            this.remove_keyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_keyButton.Enabled = false;
            this.remove_keyButton.Location = new System.Drawing.Point(339, 113);
            this.remove_keyButton.Name = "remove_keyButton";
            this.remove_keyButton.Size = new System.Drawing.Size(107, 23);
            this.remove_keyButton.TabIndex = 4;
            this.remove_keyButton.Text = "Remove";
            this.remove_keyButton.UseVisualStyleBackColor = true;
            this.remove_keyButton.Click += new System.EventHandler(this.remove_keyButton_Click);
            // 
            // key_roleComboBox
            // 
            this.key_roleComboBox.FormattingEnabled = true;
            this.key_roleComboBox.Location = new System.Drawing.Point(339, 57);
            this.key_roleComboBox.Name = "key_roleComboBox";
            this.key_roleComboBox.Size = new System.Drawing.Size(107, 21);
            this.key_roleComboBox.TabIndex = 5;
            this.key_roleComboBox.SelectedIndexChanged += new System.EventHandler(this.key_roleComboBox_SelectedIndexChanged);
            // 
            // counter_startLabel
            // 
            this.counter_startLabel.AutoSize = true;
            this.counter_startLabel.Location = new System.Drawing.Point(336, 139);
            this.counter_startLabel.Name = "counter_startLabel";
            this.counter_startLabel.Size = new System.Drawing.Size(110, 13);
            this.counter_startLabel.TabIndex = 6;
            this.counter_startLabel.Text = "Counter starting value";
            // 
            // counter_startNumericUpDown
            // 
            this.counter_startNumericUpDown.Location = new System.Drawing.Point(339, 155);
            this.counter_startNumericUpDown.Name = "counter_startNumericUpDown";
            this.counter_startNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.counter_startNumericUpDown.TabIndex = 7;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 336);
            this.Controls.Add(this.counter_startNumericUpDown);
            this.Controls.Add(this.counter_startLabel);
            this.Controls.Add(this.key_roleComboBox);
            this.Controls.Add(this.remove_keyButton);
            this.Controls.Add(this.add_keyButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyListBox);
            this.Name = "OptionsForm";
            this.Text = "KeyCounter options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.counter_startNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox keyListBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button add_keyButton;
        private System.Windows.Forms.Button remove_keyButton;
        private System.Windows.Forms.ComboBox key_roleComboBox;
        private System.Windows.Forms.Label counter_startLabel;
        private System.Windows.Forms.NumericUpDown counter_startNumericUpDown;
    }
}

