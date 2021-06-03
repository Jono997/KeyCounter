using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace KeyCounter
{
    [XmlInclude(typeof(KeyCounterConfig))]
    public abstract class CounterConfigBase
    {
        public string name { get; set; }
        public Point counter_position { get; set; }
        public RGB counter_colour { get; set; }
        public bool counter_visible { get; set; }

        public CounterConfigBase()
        {
            name = "Name";
            counter_position = new Point(12, 9);
            counter_colour = new RGB();
            counter_visible = true;
        }
    }
}
