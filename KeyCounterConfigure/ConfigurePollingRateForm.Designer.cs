namespace KeyCounter
{
    partial class ConfigurePollingRateForm
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
            this.polling_rateLabel = new System.Windows.Forms.Label();
            this.polling_rateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.demonstrateButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.demonstratePictureBox = new System.Windows.Forms.PictureBox();
            this.demonstrationTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.polling_rateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demonstratePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // polling_rateLabel
            // 
            this.polling_rateLabel.AutoSize = true;
            this.polling_rateLabel.Location = new System.Drawing.Point(12, 16);
            this.polling_rateLabel.Name = "polling_rateLabel";
            this.polling_rateLabel.Size = new System.Drawing.Size(77, 13);
            this.polling_rateLabel.TabIndex = 0;
            this.polling_rateLabel.Text = "pollingratelabel";
            // 
            // polling_rateNumericUpDown
            // 
            this.polling_rateNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polling_rateNumericUpDown.Location = new System.Drawing.Point(77, 14);
            this.polling_rateNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.polling_rateNumericUpDown.Name = "polling_rateNumericUpDown";
            this.polling_rateNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.polling_rateNumericUpDown.TabIndex = 1;
            this.polling_rateNumericUpDown.ValueChanged += new System.EventHandler(this.polling_rateNumericUpDown_ValueChanged);
            // 
            // demonstrateButton
            // 
            this.demonstrateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demonstrateButton.Location = new System.Drawing.Point(12, 76);
            this.demonstrateButton.Name = "demonstrateButton";
            this.demonstrateButton.Size = new System.Drawing.Size(159, 23);
            this.demonstrateButton.TabIndex = 2;
            this.demonstrateButton.Text = "pollingratedemonstrate";
            this.toolTip1.SetToolTip(this.demonstrateButton, "pollingratedemonstratetooltip");
            this.demonstrateButton.UseVisualStyleBackColor = true;
            this.demonstrateButton.Click += new System.EventHandler(this.demonstrateButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(177, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(106, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // demonstratePictureBox
            // 
            this.demonstratePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demonstratePictureBox.Location = new System.Drawing.Point(177, 14);
            this.demonstratePictureBox.Name = "demonstratePictureBox";
            this.demonstratePictureBox.Size = new System.Drawing.Size(106, 56);
            this.demonstratePictureBox.TabIndex = 4;
            this.demonstratePictureBox.TabStop = false;
            // 
            // demonstrationTimer
            // 
            this.demonstrationTimer.Tick += new System.EventHandler(this.demonstrationTimer_Tick);
            // 
            // ConfigurePollingRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(295, 111);
            this.Controls.Add(this.demonstratePictureBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.demonstrateButton);
            this.Controls.Add(this.polling_rateNumericUpDown);
            this.Controls.Add(this.polling_rateLabel);
            this.Name = "ConfigurePollingRateForm";
            this.Text = "pollingratetitle";
            ((System.ComponentModel.ISupportInitialize)(this.polling_rateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demonstratePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label polling_rateLabel;
        private System.Windows.Forms.NumericUpDown polling_rateNumericUpDown;
        private System.Windows.Forms.Button demonstrateButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.PictureBox demonstratePictureBox;
        private System.Windows.Forms.Timer demonstrationTimer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}