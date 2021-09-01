using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    public class SumMulCalc : Boss_Interface
    {
        //public string Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int doMul(int num3, int num4)
        {
            return num3 * num4;
        }

        public int doSum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public int Division ()
        {
            return Num1 / Num2;
        }

        public static int subTraction(int num1, int num2)
        {
            return num1 - num2;
        }




    }
}
