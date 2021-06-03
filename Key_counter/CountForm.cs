using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Key_counter
{
    public partial class CountForm : Form
    {
        private Config config;
        private Kennedy.ManagedHooks.KeyboardHook keyboardHook = new Kennedy.ManagedHooks.KeyboardHook();
        private int counter;
        private int checkpoint;

        public CountForm(Config config)
        {
            InitializeComponent();
            this.config = config;
            counter = checkpoint = config.counter_start;
            counterLabel.Text = counter.ToString();
            keyboardHook.KeyboardEvent += new Kennedy.ManagedHooks.KeyboardHook.KeyboardEventHandler(keyPressed);
            keyboardHook.InstallHook();
        }

        private void keyPressed(Kennedy.ManagedHooks.KeyboardEvents kEvent, Keys key)
        {
            if (kEvent == Kennedy.ManagedHooks.KeyboardEvents.KeyDown)
                foreach (Key _key in config.keys)
                    if ((Keys)_key.keyChar == key)
                    {
                        switch (_key.action)
                        {
                            case Key.KeyAction.Increment:
                                counter += 1;
                                break;
                            case Key.KeyAction.Decrement:
                                counter -= 1;
                                break;
                            case Key.KeyAction.Reset:
                                if (counter == checkpoint)
                                    counter = config.counter_start;
                                else
                                    counter = checkpoint;
                                break;
                            case Key.KeyAction.Exit:
                                Close();
                                break;
                            case Key.KeyAction.Checkpoint:
                                checkpoint = counter;
                                break;
                        }
                        counterLabel.Text = counter.ToString();
                    }
        }

        private void CountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.UninstallHook();
        }
    }
}
