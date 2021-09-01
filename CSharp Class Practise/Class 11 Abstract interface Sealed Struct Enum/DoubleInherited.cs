using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    class DoubleInherited : DoubleSum
    {
        public override int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
