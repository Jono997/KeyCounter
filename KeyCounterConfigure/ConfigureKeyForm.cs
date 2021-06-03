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
        private Kennedy.ManagedHooks.KeyboardHook keyboardHook = new Kennedy.ManagedHooks.KeyboardHook();

        public ConfigureKeyForm(Key key)
        {
            this.key = key;
            InitializeComponent();
            InitialiseLocaleComponents();
            foreach(Key.KeyTrigger trigger in Enum.GetValues(typeof(Key.KeyTrigger)))
            {
                triggerComboBox.Items.Add(trigger.ToString());
            }
            triggerComboBox.SelectedIndex = (int)key.trigger;
            foreach (Key.KeyAction action in Enum.GetValues(typeof(Key.KeyAction)))
            {
                actionComboBox.Items.Add(action.ToString());
            }
            actionComboBox.SelectedIndex = (int)key.action;
            refresh_keyTextBox();
            keyboardHook.KeyboardEvent += new Kennedy.ManagedHooks.KeyboardHook.KeyboardEventHandler(keyPressed);
            keyboardHook.InstallHook();
        }

        private void InitialiseLocaleComponents()
        {
            Text = LocaleDialogue.Get("keytitle");
            keyLabel.Text = LocaleDialogue.Get("keylabel");
            triggerLabel.Text = LocaleDialogue.Get("triggerlabel");
            toolTip1.SetToolTip(triggerLabel, LocaleDialogue.Get("triggertooltip"));
            toolTip1.SetToolTip(triggerComboBox, LocaleDialogue.Get("triggertooltip"));
            actionLabel.Text = LocaleDialogue.Get("actionlabel");
            toolTip1.SetToolTip(actionLabel, LocaleDialogue.Get("actiontooltip"));
            toolTip1.SetToolTip(actionComboBox, LocaleDialogue.Get("actiontooltip"));
            OKButton.Text = LocaleDialogue.Get("ok");
            cancelButton.Text = LocaleDialogue.Get("cancel");
        }

        private void refresh_keyTextBox()
        {
            keyTextBox.Text = key.keyChar.ToString();
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void keyPressed(Kennedy.ManagedHooks.KeyboardEvents kEvent, Keys key)
        {
            if (keyTextBox.Focused)
            {
                this.key.keyChar = key;
                refresh_keyTextBox();
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            key.trigger = (Key.KeyTrigger)triggerComboBox.SelectedIndex;
            key.action = (Key.KeyAction)actionComboBox.SelectedIndex;
            key.actionValue = Convert.ToInt32(actionValueNumericUpDown.Value);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = keyTextBox.Text.Length > 0 && keyTextBox.Text != "None" && triggerComboBox.SelectedIndex != -1 && actionComboBox.SelectedIndex != -1;
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyTextBox_TextChanged(null, null);
            actionValueLabel.Visible = actionValueNumericUpDown.Visible = Key.UsesActionValue.Contains((Key.KeyAction)actionComboBox.SelectedIndex);
            if (actionValueLabel.Visible)
            {
                switch ((Key.KeyAction)actionComboBox.SelectedIndex)
                {
                    case Key.KeyAction.Increment:
                        actionValueLabel.Text = LocaleDialogue.Get("incrementamountlabel");
                        toolTip1.SetToolTip(actionValueLabel, LocaleDialogue.Get("incrementamounttooltip"));
                        toolTip1.SetToolTip(actionValueNumericUpDown, LocaleDialogue.Get("incrementamounttooltip"));
                        break;
                    case Key.KeyAction.Decrement:
                        actionValueLabel.Text = LocaleDialogue.Get("decrementamountlabel");
                        toolTip1.SetToolTip(actionValueLabel, LocaleDialogue.Get("decrementamounttooltip"));
                        toolTip1.SetToolTip(actionValueNumericUpDown, LocaleDialogue.Get("decrementamounttooltip"));
                        break;
                }
            }
        }

        private void triggerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyTextBox_TextChanged(null, null);
        }

        private void ConfigureKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.Dispose();
        }
    }
}
