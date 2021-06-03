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
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
            linkLabel1.Text += $"\n{LocaleDialogue.GetFallback("translationcredit", "")}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/Jono997/KeyCounter");
        }
    }
}
