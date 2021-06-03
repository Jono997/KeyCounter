using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace KeyCounter
{
    public class KeyCounterConfig : CounterConfigBase
    {
        public Key[] keys { get; set; }
        public int counter_start { get; set; }

        public KeyCounterConfig() : base()
        {
            keys = new Key[] { new Key(System.Windows.Forms.Keys.K, Key.KeyAction.Increment, 1),
                               new Key(System.Windows.Forms.Keys.F, Key.KeyAction.Increment, 1),
                               new Key(System.Windows.Forms.Keys.R, Key.KeyAction.Reset),
                               new Key(System.Windows.Forms.Keys.Pause, Key.KeyAction.Exit)
                             };
            counter_start = 0;
        }
    }
}
