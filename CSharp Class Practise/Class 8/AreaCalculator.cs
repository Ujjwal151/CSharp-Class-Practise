using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8
{
    class AreaCalculator
    {

        public static string Course { get; set; }

        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double RectangleArea(double length, double width)
        {

            return length*width;
        }

        public void Print()
        {
            Console.WriteLine(Course);
        }


    }
}
