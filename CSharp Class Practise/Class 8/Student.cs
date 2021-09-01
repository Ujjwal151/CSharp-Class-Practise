using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8
{
    public class Student
    {
        private static string School { get; set; }
        private static string Location { get; set; }
        public int Class { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public readonly int Id;
        public const double MAX_CGPA = 4.00; 

        public Student() : this("NO name has been setted")
        {
        }

        public Student( string argName) 
        {
            School = "Agailjhara BHP Academy";
            Location = "Agailjhara, Barishal";
            Name = argName;
            Class = 10;
            Id = 1000;
            Cgpa = 2.00;
        }

        public void display()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Cgpa = " + Cgpa);
            Console.WriteLine("School = " + School);
            Console.WriteLine("Location = " + Location);
            Console.WriteLine("Class = " + Class);
            Console.WriteLine();
        }

        public void EditStudentsInfo()
        {
            Console.Write("Name = ");
            Name = Console.ReadLine();
            Console.Write("Cgpa = ");
            Cgpa = double.Parse(Console.ReadLine());
        }

    }
}
