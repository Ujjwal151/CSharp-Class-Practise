using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Icloseable ob1 = new UseingClass(7,8);
            ob1.Name = "Ujjwal Ojha";

            UseingClass ob2 = new UseingClass(5, 6);
            int r = ob2.doMul(2, 5);
            Console.WriteLine(r);

            Console.WriteLine(ob1.Getname());


            UseingClass ob3 = new UseingClass(50,10);
            UseingClass ob4 = new UseingClass(10,2);
            UseingClass ob5 = new UseingClass(20,3);

            Console.WriteLine(ob3.Division());
            Console.WriteLine(ob4.Division());
            Console.WriteLine(ob5.Division());

            UseingClass ob6 = new UseingClass(10000, 10);
            int subres = UseingClass.subTraction(20, 100);
            Console.WriteLine(subres);

            Console.Read();
        }
    }
}
