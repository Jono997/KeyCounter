using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCounter
{
    public class CounterHandler
    {
        public int counter { get; set; }
        public bool exit { get; private set; }
        private Config config;
        public int counter_start
        {
            get
            {
                return config.counter_start;
            }
        }
        public string name
        {
            get
            {
                return config.name;
            }
        }
        private int checkpoint;
        private CountForm parent;

        public CounterHandler(CountForm parent, Config config)
        {
            this.parent = parent;
            this.config = config;
            counter = checkpoint = config.counter_start;
            exit = false;
        }

        public void handleEvent(Kennedy.ManagedHooks.KeyboardEvents kEvent, Keys key)
        {
            if (kEvent == Kennedy.ManagedHooks.KeyboardEvents.KeyDown)
            {
                foreach (Key _key in config.keys)
                {
                    if (_key.keyChar == key)
                    {
                        switch (_key.action)
                        {
                            case Key.KeyAction.Increment:
                                counter++;
                                break;
                            case Key.KeyAction.Decrement:
                                counter--;
                                break;
                            case Key.KeyAction.Reset:
                                counter = (counter == checkpoint ? config.counter_start : checkpoint);
                                break;
                            case Key.KeyAction.Exit:
                                exit = true;
                                break;
                            case Key.KeyAction.Checkpoint:
                                checkpoint = counter;
                                break;
                            case Key.KeyAction.GlobalCheckpoint:
                                parent.global_checkpoint();
                                break;
                            case Key.KeyAction.GlobalReset:
                                parent.global_reset();
                                break;
                        }
                        return;
                    }
                }
            }
        }
    }
}
