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
    public partial class ConfigureKeyForm : Form
    {
        public Key key { get; private set; }

        public ConfigureKeyForm(Key key)
        {
            this.key = key;
            InitializeComponent();
            foreach (Key.KeyAction action in Enum.GetValues(typeof(Key.KeyAction)))
            {
                actionComboBox.Items.Add(action.ToString());
            }
            actionComboBox.SelectedIndex = (int)key.action;
            refresh_keyTextBox();
        }

        private void refresh_keyTextBox()
        {
            keyTextBox.Text = key.keyChar.ToString();
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            key.keyChar = e.KeyCode;
            refresh_keyTextBox();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            key.action = (Key.KeyAction)actionComboBox.SelectedIndex;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = keyTextBox.Text.Length > 0 && keyTextBox.Text != "None" && actionComboBox.SelectedIndex != -1;
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyTextBox_TextChanged(null, null);
        }
    }
}
