using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_counter
{
    public partial class OptionsForm : Form
    {
        public Config config;
        private List<Key> keys;
        private Keys current_key;

        public OptionsForm()
        {
            config = Config.Load();
            keys = config.keys.ToList();
            InitializeComponent();

            foreach (Key.KeyAction action in Enum.GetValues(typeof(Key.KeyAction)))
            {
                key_roleComboBox.Items.Add(action.ToString());
            }

            generate_keyListBox();
            counter_startNumericUpDown.Value = config.counter_start;
        }

        private void generate_keyListBox()
        {
            keyListBox.Items.Clear();
            foreach (Key key in keys)
            {
                string item = "";
                switch (key.action)
                {
                    case Key.KeyAction.Increment:
                        item = "ICR";
                        break;
                    case Key.KeyAction.Decrement:
                        item = "DCR";
                        break;
                    case Key.KeyAction.Reset:
                        item = "RST";
                        break;
                    case Key.KeyAction.Exit:
                        item = "EXT";
                        break;
                    case Key.KeyAction.Checkpoint:
                        item = "CHP";
                        break;
                }
                item += ": " + key.keyChar.ToString();
                keyListBox.Items.Add(item);
            }
        }

        private void keyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_keyButton.Enabled = keyListBox.SelectedIndex != -1;
        }

        private void key_roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_keyButton.Enabled = keyTextBox.Text.Length > 0 && key_roleComboBox.SelectedIndex != -1;
        }

        private void add_keyButton_Click(object sender, EventArgs e)
        {
            Key key = new Key(current_key, (Key.KeyAction)key_roleComboBox.SelectedIndex);
            keys.Add(key);
            generate_keyListBox();
        }

        private void remove_keyButton_Click(object sender, EventArgs e)
        {
            keys.RemoveAt(keyListBox.SelectedIndex);
            generate_keyListBox();
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            current_key = e.KeyCode;
            e.SuppressKeyPress = true;
            keyTextBox.Text = e.KeyCode.ToString();
            key_roleComboBox_SelectedIndexChanged(null, null);
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.keys = keys.ToArray();
            config.counter_start = Convert.ToInt32(counter_startNumericUpDown.Value);
            config.Save();
        }
    }
}
