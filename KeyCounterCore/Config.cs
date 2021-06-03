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
    public class Config
    {
        public Key[] keys { get; set; }
        public string name { get; set; }
        public int counter_start { get; set; }
        public Point counter_position { get; set; }

        public Config()
        {
            keys = new Key[] { new Key(System.Windows.Forms.Keys.K, Key.KeyAction.Increment),
                               new Key(System.Windows.Forms.Keys.F, Key.KeyAction.Increment),
                               new Key(System.Windows.Forms.Keys.R, Key.KeyAction.Reset),
                               new Key(System.Windows.Forms.Keys.Pause, Key.KeyAction.Exit)
                             };
            name = "Name";
            counter_start = 0;
            counter_position = new Point(12, 9);
        }
    }
}
