using System;

namespace Class_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Ujjwal";
            st1.SetAge(22);
            st1.Cgpa = 3.50;
            st1.mob = "01792427407";


            Console.WriteLine(st1.name);
            Console.WriteLine(st1.GetAge());
            Console.WriteLine(st1.Cgpa);
            Console.WriteLine(st1.mob);

            string str;
            
        }
    }
}
