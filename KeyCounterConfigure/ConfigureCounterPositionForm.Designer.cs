namespace KeyCounter
{
    partial class ConfigureCounterPositionForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yLabel = new System.Windows.Forms.Label();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.coordinatePanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.yNumericUpDown);
            this.mainPanel.Controls.Add(this.yLabel);
            this.mainPanel.Controls.Add(this.xNumericUpDown);
            this.mainPanel.Controls.Add(this.xLabel);
            this.mainPanel.Controls.Add(this.coordinatePanel);
            this.mainPanel.Controls.Add(this.OKButton);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Location = new System.Drawing.Point(241, 111);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(365, 194);
            this.mainPanel.TabIndex = 0;
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yNumericUpDown.Location = new System.Drawing.Point(92, 168);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.yNumericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.yNumericUpDown.TabIndex = 6;
            // 
            // yLabel
            // 
            this.yLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(72, 170);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "Y";
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xNumericUpDown.Location = new System.Drawing.Point(23, 168);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.xNumericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.xNumericUpDown.TabIndex = 4;
            // 
            // xLabel
            // 
            this.xLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(3, 170);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X";
            // 
            // coordinatePanel
            // 
            this.coordinatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordinatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coordinatePanel.Location = new System.Drawing.Point(3, 3);
            this.coordinatePanel.Name = "coordinatePanel";
            this.coordinatePanel.Size = new System.Drawing.Size(359, 159);
            this.coordinatePanel.TabIndex = 2;
            this.coordinatePanel.Click += new System.EventHandler(this.coordinatePanel_Click);
            this.coordinatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.coordinatePanel_Paint);
            this.coordinatePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coordinatePanel_MouseMove);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(206, 168);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(287, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLabel.ForeColor = System.Drawing.Color.Lime;
            this.exampleLabel.Location = new System.Drawing.Point(12, 9);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(118, 42);
            this.exampleLabel.TabIndex = 1;
            this.exampleLabel.Text = "label1";
            // 
            // ConfigureCounterPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigureCounterPositionForm";
            this.Opacity = 0.6D;
            this.Text = "ConfigureCounterPositionForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Panel coordinatePanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label exampleLabel;
    }
}