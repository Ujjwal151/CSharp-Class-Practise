using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    public class UseingClass : SumMulCalc, Icloseable, Iopenable
    {
        string Name { get; set ; }
        int Age { get ; set ; }
        string Icloseable.Name { get; set; }
        int Icloseable.Age { get ; set ; }

        public UseingClass(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void Close()
        {
            Console.WriteLine("Close from UseingClass");
        }

        public string Getname()
        {
            return Name;
        }

        public void Open()
        {
            Console.WriteLine("Open from UseingClass");
        }
    }
}
