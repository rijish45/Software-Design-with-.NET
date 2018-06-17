using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3

{
    public class PointClass
    {
        public Point p;     //keeps track of the coordinate
        public Boolean color; //keeps track of color

        public PointClass(Point point, Boolean whatcolor)

        {
            color = whatcolor;
            p = new Point(point.X, point.Y);

        }
    }
}
