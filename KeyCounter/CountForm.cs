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

namespace KeyCounter
{
    public partial class CountForm : Form
    {
        private CounterHandler[] counter_handlers;
        private Label[] counter_labels;
        private Kennedy.ManagedHooks.KeyboardHook keyboardHook = new Kennedy.ManagedHooks.KeyboardHook();
        private int[] global_checkpoints;
        private Dictionary<Keys, bool> key_states;

        public CountForm(Config config)
        {
            InitializeComponent();
            Opacity = config.counter_opacity;
            List<CounterHandler> counter_handlers = new List<CounterHandler>();
            List<Label> counter_labels = new List<Label>();
            List<Color> used_colours = new List<Color>();
            foreach (KeyCounterConfig c in config.configs)
            {
                counter_handlers.Add(new CounterHandler(this, c));
                counter_labels.Add(new Label()
                {
                    Location = c.counter_position,
                    Text = c.name + ": " + c.counter_start.ToString(),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = c.counter_colour.toColor()
                });
                Controls.Add(counter_labels.Last());
                used_colours.Add(counter_labels.Last().ForeColor);
            }
            this.counter_handlers = counter_handlers.ToArray();
            this.counter_labels = counter_labels.ToArray();
            Random random = new Random();
            while (used_colours.Contains(BackColor))
            {
                BackColor = Color.FromArgb(random.Next(int.MinValue, int.MaxValue));
            }
            TransparencyKey = BackColor;
            global_checkpoints = new int[this.counter_handlers.Length];
            global_checkpoint();
            key_states = new Dictionary<Keys, bool>();
            keyPressTimer.Interval = config.polling_rate;
            keyboardHook.KeyboardEvent += new Kennedy.ManagedHooks.KeyboardHook.KeyboardEventHandler(keyPressed);
            keyboardHook.InstallHook();
            keyPressTimer.Enabled = true;
        }

        public void global_checkpoint()
        {
            for (int i = 0; i < counter_handlers.Length; i++)
            {
                global_checkpoints[i] = counter_handlers[i].counter;
            }
        }

        public void global_reset()
        {
            bool matches_checkpoint = true;
            for (int i = 0; i < counter_handlers.Length; i++)
            {
                if (counter_handlers[i].counter != global_checkpoints[i])
                {
                    matches_checkpoint = false;
                    break;
                }
            }

            for (int i = 0; i < counter_handlers.Length; i++)
            {
                counter_handlers[i].counter = matches_checkpoint ? counter_handlers[i].counter_start : global_checkpoints[i];
            }
        }
        
        private void keyPressed(Kennedy.ManagedHooks.KeyboardEvents kEvent, Keys key)
        {
            if (kEvent == Kennedy.ManagedHooks.KeyboardEvents.KeyDown)
            {
                fireHandlers(Key.KeyTrigger.Legacy, key);
                if (key_states.ContainsKey(key))
                {
                    if (!key_states[key])
                    {
                        key_states[key] = true;
                        fireHandlers(Key.KeyTrigger.KeyDown, key);
                    }
                }
                else
                {
                    key_states.Add(key, true);
                    fireHandlers(Key.KeyTrigger.KeyDown, key);
                }
            }
            else if (kEvent == Kennedy.ManagedHooks.KeyboardEvents.KeyUp)
            {
                key_states[key] = false;
                fireHandlers(Key.KeyTrigger.KeyUp, key);
            }
        }

        private void fireHandlers(Key.KeyTrigger trigger, Keys key)
        {
            for (int i = 0; i < counter_handlers.Length; i++)
            {
                counter_handlers[i].handleEvent(trigger, key);
                if (counter_handlers[i].exit)
                {
                    Close();
                    return;
                }
                counter_labels[i].Text = counter_handlers[i].name + ": " + counter_handlers[i].counter.ToString();
            }

        }

        private void CountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.UninstallHook();
        }

        private void keyPressTimer_Tick(object sender, EventArgs e)
        {
            foreach (Keys key in key_states.Keys)
            {
                if (key_states[key])
                {
                    fireHandlers(Key.KeyTrigger.KeyHeld, key);
                }
            }
        }
    }
}
