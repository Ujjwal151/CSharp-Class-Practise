using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    public interface Boss_Interface
    {
        
        int Num1 { get; set; }
        int Num2 { get; set; }
        int doSum(int Num1, int Num2);
        int doMul(int num3, int num4);

    }
}
