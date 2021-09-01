using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    public partial class DoubleSum : SumCalculator
    {


        public override int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public new int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public override int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public override double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        



    }
}
