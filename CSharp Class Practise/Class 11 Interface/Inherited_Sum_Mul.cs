using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    class Inherited_Sum_Mul : SumMulCalc
    {

        public int GetResult(int Num1, int Num2)
        {
            return doSum(Num1, Num2);
        } 

    }
}
