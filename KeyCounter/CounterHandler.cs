using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KeyCounter
{
    public class CounterHandler
    {
        private Dictionary<Key.KeyTrigger, List<Key>> keys;
        public int counter { get; set; }
        public bool exit { get; private set; }
        private KeyCounterConfig config;
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

        public CounterHandler(CountForm parent, KeyCounterConfig config)
        {
            this.parent = parent;
            this.config = config;
            counter = checkpoint = config.counter_start;
            exit = false;
            keys = new Dictionary<Key.KeyTrigger, List<Key>>();
            keys.Add(Key.KeyTrigger.KeyDown, new List<Key>());
            keys.Add(Key.KeyTrigger.KeyUp,   new List<Key>());
            keys.Add(Key.KeyTrigger.KeyHeld, new List<Key>());
            keys.Add(Key.KeyTrigger.Legacy,  new List<Key>());
            foreach (Key key in config.keys)
            {
                keys[key.trigger].Add(key);
            }
        }

        private void executeKey(Key key)
        {
            switch (key.action)
            {
                case Key.KeyAction.Increment:
                    counter += key.actionValue;
                    break;
                case Key.KeyAction.Decrement:
                    counter -= key.actionValue;
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
        }

        public void handleEvent(Key.KeyTrigger trigger, Keys key)
        {
            foreach (Key _key in keys[trigger])
            {
                if (_key.keyChar == key)
                {
                    executeKey(_key);
                    return;
                }
            }
        }
    }
}
