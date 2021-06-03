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

        public CountForm(Config[] configs)
        {
            InitializeComponent();
            List<CounterHandler> counter_handlers = new List<CounterHandler>();
            List<Label> counter_labels = new List<Label>();
            foreach (Config config in configs)
            {
                counter_handlers.Add(new CounterHandler(this, config));
                counter_labels.Add(new Label()
                {
                    Location = config.counter_position,
                    Text = config.name + ": " + config.counter_start.ToString(),
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.Lime
                });
                Controls.Add(counter_labels.Last());
            }
            this.counter_handlers = counter_handlers.ToArray();
            this.counter_labels = counter_labels.ToArray();
            global_checkpoints = new int[this.counter_handlers.Length];
            global_checkpoint();
            keyboardHook.KeyboardEvent += new Kennedy.ManagedHooks.KeyboardHook.KeyboardEventHandler(keyPressed);
            keyboardHook.InstallHook();
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
            for (int i = 0; i < counter_handlers.Length; i++)
            {
                counter_handlers[i].handleEvent(kEvent, key);
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
    }
}
