namespace KeyCounter
{
    partial class CountForm
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
            this.keyPressTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // keyPressTimer
            // 
            this.keyPressTimer.Tick += new System.EventHandler(this.keyPressTimer_Tick);
            // 
            // CountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CountForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer keyPressTimer;
    }
}