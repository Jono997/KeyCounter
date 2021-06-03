using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KeyCounter
{
    public class RGB
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }


        public RGB(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public RGB(Color colour) : this(colour.R, colour.G, colour.B) { }

        public RGB() : this(Color.Lime) { }

        public Color toColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }
    }
}
