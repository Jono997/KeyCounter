using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCounter
{
    public partial class ConfigurePollingRateForm : Form
    {
        public int polling_rate;

        public ConfigurePollingRateForm(int polling_rate)
        {
            InitializeComponent();
            InitialiseLocaleComponents();
            polling_rateNumericUpDown.Value = polling_rate;
        }

        private void InitialiseLocaleComponents()
        {
            Text = LocaleDialogue.Get("pollingratetitle");
            polling_rateLabel.Text = LocaleDialogue.Get("pollingratelabel");
            demonstrateButton.Text = LocaleDialogue.Get("pollingratedemonstrate");
            toolTip1.SetToolTip(demonstrateButton, LocaleDialogue.Get("pollingratedemonstratetooltip"));
            OKButton.Text = LocaleDialogue.Get("ok");
        }

        private void polling_rateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            demonstrationTimer.Interval = Convert.ToInt32(polling_rateNumericUpDown.Value);
        }

        private void demonstrateButton_Click(object sender, EventArgs e)
        {
            demonstrationTimer.Enabled = !demonstrationTimer.Enabled;
            demonstrateButton.Text = demonstrationTimer.Enabled ? "Stop demonstration" : "Demonstrate";
        }

        private void demonstrationTimer_Tick(object sender, EventArgs e)
        {
            demonstratePictureBox.BackColor = (demonstratePictureBox.BackColor == Color.Gray ? Color.DarkSlateGray : Color.Gray);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            polling_rate = demonstrationTimer.Interval;
        }
    }
}
