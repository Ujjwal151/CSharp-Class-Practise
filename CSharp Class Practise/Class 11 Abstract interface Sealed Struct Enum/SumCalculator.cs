using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    public abstract class SumCalculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public virtual int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public virtual int Mul(int num1, int num2)
        {
            return num1 * num2;
        }


        public abstract double Add(double num1, double num2);

    }
}
