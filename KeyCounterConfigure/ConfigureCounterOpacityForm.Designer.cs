
namespace KeyCounter
{
    partial class ConfigureCounterOpacityForm
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
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.opacityMinimumLabel = new System.Windows.Forms.Label();
            this.opacityMaximumLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityTrackBar.Location = new System.Drawing.Point(12, 12);
            this.opacityTrackBar.Maximum = 100;
            this.opacityTrackBar.Minimum = 30;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(292, 45);
            this.opacityTrackBar.TabIndex = 0;
            this.opacityTrackBar.Value = 100;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            // 
            // opacityMinimumLabel
            // 
            this.opacityMinimumLabel.AutoSize = true;
            this.opacityMinimumLabel.Location = new System.Drawing.Point(12, 44);
            this.opacityMinimumLabel.Name = "opacityMinimumLabel";
            this.opacityMinimumLabel.Size = new System.Drawing.Size(19, 13);
            this.opacityMinimumLabel.TabIndex = 1;
            this.opacityMinimumLabel.Text = "30";
            // 
            // opacityMaximumLabel
            // 
            this.opacityMaximumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityMaximumLabel.AutoSize = true;
            this.opacityMaximumLabel.Location = new System.Drawing.Point(279, 44);
            this.opacityMaximumLabel.Name = "opacityMaximumLabel";
            this.opacityMaximumLabel.Size = new System.Drawing.Size(25, 13);
            this.opacityMaximumLabel.TabIndex = 2;
            this.opacityMaximumLabel.Text = "100";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(13, 67);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(291, 39);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ConfigureCounterOpacityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 118);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.opacityMaximumLabel);
            this.Controls.Add(this.opacityMinimumLabel);
            this.Controls.Add(this.opacityTrackBar);
            this.Name = "ConfigureCounterOpacityForm";
            this.Text = "opacitytitle";
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label opacityMinimumLabel;
        private System.Windows.Forms.Label opacityMaximumLabel;
        private System.Windows.Forms.Button OKButton;
    }
}