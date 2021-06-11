using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        double length, breadth, height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double length)
        {
            this.length = length;
        }

        public void setBreadth(double breadth)
        {
           this.breadth = breadth;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breadth = a.breadth + b.breadth;
            box.height = a.height + b.height;
            return box;
        }

    }
}
