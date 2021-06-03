using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;
using System.Diagnostics;

namespace KeyCounter
{
    public partial class ConfigControl : UserControl
    {
        public Config config
        {
            get
            {
                _config.name = nameTextBox.Text;
                _config.keys = keys.ToArray();
                _config.counter_start = Convert.ToInt32(counter_startNumericUpDown.Value);
                _config.counter_position = new Point(Convert.ToInt32(counter_position_xNumericUpDown.Value), Convert.ToInt32(counter_position_yNumericUpDown.Value));
                return _config;
            }
        }
        private Config _config;
        private List<Key> keys;
        private MainForm parent;
        private bool changed
        { 
            set
            {
                parent.changed = value;
            }
        }

        public ConfigControl()
        {
            _config = null;
            keys = null;
            InitializeComponent();
        }

        public void Setup(MainForm self, Config config)
        {
            parent = self;
            _config = config;
            keys = config.keys.ToList();
            nameTextBox.Text = _config.name;
            refresh_keysListBox();
            counter_startNumericUpDown.Value = _config.counter_start;
            counter_position_xNumericUpDown.Value = _config.counter_position.X;
            counter_position_yNumericUpDown.Value = _config.counter_position.Y;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
        }

        private void refresh_keysListBox()
        {
            keysListBox.Items.Clear();
            for (int i = 0; i < keys.Count; i++)
            {
                string prefix = "";
                switch (keys[i].action)
                {
                    case Key.KeyAction.Increment:
                        prefix = "INC";
                        break;
                    case Key.KeyAction.Decrement:
                        prefix = "DEC";
                        break;
                    case Key.KeyAction.Checkpoint:
                        prefix = "CHP";
                        break;
                    case Key.KeyAction.Reset:
                        prefix = "RST";
                        break;
                    case Key.KeyAction.Exit:
                        prefix = "EXT";
                        break;
                }
                keysListBox.Items.Add(prefix + ": " + keys[i].keyChar.ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConfigureKeyForm configureKeyForm = new ConfigureKeyForm(new Key());
            if (configureKeyForm.ShowDialog() == DialogResult.OK)
            {
                keys.Add(configureKeyForm.key);
                refresh_keysListBox();
                changed = true;
            }
        }

        private void keysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyButton.Enabled = removeButton.Enabled = keysListBox.SelectedIndex != -1;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ConfigureKeyForm configureKeyForm = new ConfigureKeyForm(keys[keysListBox.SelectedIndex]);
            if (configureKeyForm.ShowDialog() == DialogResult.OK)
            {
                keys[keysListBox.SelectedIndex] = configureKeyForm.key;
                refresh_keysListBox();
                changed = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            keys.RemoveAt(keysListBox.SelectedIndex);
            refresh_keysListBox();
            changed = true;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string text_xml = ConfigLoader.Save(new Config[] { config });
            string temp_file = Path.GetTempFileName();
            File.WriteAllText(temp_file, text_xml);
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo(Path.Combine(Environment.GetCommandLineArgs()[0], "..", "KeyCounter.exe"), temp_file)
            };
            process.Start();
            process.WaitForExit();
            File.Delete(temp_file);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            parent.refresh_tabPage_name(nameTextBox.Text);
            changed = true;
        }
    }
}
