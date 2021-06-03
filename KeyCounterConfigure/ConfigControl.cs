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
        public KeyCounterConfig config
        {
            get
            {
                _config.name = nameTextBox.Text;
                _config.keys = keys.ToArray();
                _config.counter_start = Convert.ToInt32(counter_startNumericUpDown.Value);
                return _config;
            }
        }
        private KeyCounterConfig _config;
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
            InitialiseLocaleComponents();
        }

        private void InitialiseLocaleComponents()
        {
            toolTip1.SetToolTip(nameTextBox, LocaleDialogue.Get("nametooltip"));
            toolTip1.SetToolTip(keysListBox, LocaleDialogue.Get("keystooltip"));
            addButton.Text = LocaleDialogue.Get("addkey");
            toolTip1.SetToolTip(addButton, LocaleDialogue.Get("addkeytooltip"));
            modifyButton.Text = LocaleDialogue.Get("modifykey");
            toolTip1.SetToolTip(modifyButton, LocaleDialogue.Get("modifykeytooltip"));
            removeButton.Text = LocaleDialogue.Get("removekey");
            toolTip1.SetToolTip(removeButton, LocaleDialogue.Get("removekeytooltip"));
            counter_startLabel.Text = LocaleDialogue.Get("startvalue");
            toolTip1.SetToolTip(counter_startLabel, LocaleDialogue.Get("startvaluetooltip"));
            toolTip1.SetToolTip(counter_startNumericUpDown, LocaleDialogue.Get("startvaluetooltip"));
            toolTip1.SetToolTip(counter_positionLabel, LocaleDialogue.Get("positiontooltip"));
            toolTip1.SetToolTip(counter_positionButton, LocaleDialogue.Get("positiontooltip"));
            counter_positionButton.Text = LocaleDialogue.Get("configureposition");
            counter_colourLabel.Text = LocaleDialogue.Get("colour");
            toolTip1.SetToolTip(counter_colourLabel, LocaleDialogue.Get("colourtooltip"));
            toolTip1.SetToolTip(counter_colourPanel, LocaleDialogue.Get("colourtooltip"));
            toolTip1.SetToolTip(counter_colourButton, LocaleDialogue.Get("colourtooltip"));
            counter_colourButton.Text = LocaleDialogue.Get("configurecolour");
            testButton.Text = LocaleDialogue.Get("testcounter");
            toolTip1.SetToolTip(testButton, LocaleDialogue.Get("testcountertooltip"));
        }

        public void Setup(MainForm self, KeyCounterConfig config)
        {
            parent = self;
            _config = config;
            keys = config.keys.ToList();
            nameTextBox.Text = config.name;
            refresh_keysListBox();
            counter_startNumericUpDown.Value = config.counter_start;
            counter_positionLabel.Text = LocaleDialogue.Get("position", config.counter_position.X, config.counter_position.Y);
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            counter_colourPanel.BackColor = config.counter_colour.toColor();
        }

        private void refresh_keysListBox()
        {
            int index = keysListBox.SelectedIndex;
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
                    case Key.KeyAction.GlobalCheckpoint:
                        prefix = "GCP";
                        break;
                    case Key.KeyAction.GlobalReset:
                        prefix = "GRS";
                        break;
                }
                if (Key.UsesActionValue.Contains(keys[i].action))
                    prefix += $" {keys[i].actionValue}";

                string suffix = "";
                switch (keys[i].trigger)
                {
                    case Key.KeyTrigger.KeyDown:
                        suffix = "DWN";
                        break;
                    case Key.KeyTrigger.KeyUp:
                        suffix = "UP";
                        break;
                    case Key.KeyTrigger.KeyHeld:
                        suffix = "HLD";
                        break;
                    case Key.KeyTrigger.Legacy:
                        suffix = "OLD";
                        break;
                }

                keysListBox.Items.Add($"{prefix}: {keys[i].keyChar} - {suffix}");
            }
            keysListBox.SelectedIndex = index >= keysListBox.Items.Count ? -1 : index;
            keysListBox_SelectedIndexChanged(null, null);
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
            string text_xml = ConfigLoader.Save(new Config( new KeyCounterConfig[] { config }));
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

        private void counter_positionButton_Click(object sender, EventArgs e)
        {
            ConfigureCounterPositionForm configureForm = new ConfigureCounterPositionForm(config.counter_position, config.name);
            if (configureForm.ShowDialog() == DialogResult.OK)
            {
                config.counter_position = configureForm.counter_position;
                counter_positionLabel.Text = LocaleDialogue.Get("position", config.counter_position.X, config.counter_position.Y);
                changed = true;
            }
        }

        private void counter_colourButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                counter_colourPanel.BackColor = colorDialog1.Color;
                config.counter_colour = new RGB(colorDialog1.Color);
                changed = true;
            }
        }
    }
}
