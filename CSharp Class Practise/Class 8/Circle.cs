using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle() : this(10)
        {
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }


    }
}
