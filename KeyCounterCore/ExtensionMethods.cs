﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCounter
{
    public static class ExtensionMethods
    {
        public static Point Subtract(this Point p1, Point p2)
        {
            Point retval = new Point(p1.X - p2.X, p1.Y - p2.Y);
            return retval;
        }
    }
}
