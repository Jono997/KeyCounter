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
    public partial class ConfigureCounterOpacityForm : Form
    {
        public ConfigureCounterOpacityForm(double opacity)
        {
            InitializeComponent();
            Text = LocaleDialogue.Get("opacitytitle");
            OKButton.Text = LocaleDialogue.Get("ok");
            opacityTrackBar.Value = Convert.ToInt32(opacity * 100);
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            Opacity = Convert.ToDouble(opacityTrackBar.Value) / 100;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
