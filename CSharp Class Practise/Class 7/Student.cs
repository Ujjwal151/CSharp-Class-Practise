using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7
{
    class Student
    {
        public string name; // It can ba accessed anywhere in the project

        private int age;     //We used Get and set Method to accesss the private fields
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int newAge)
        {
            age = newAge;
        }

        // We used property for cgpa
        private double cgpa; 
        public double Cgpa // Case Matters. 
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }

       
        // We used auto property instead of property for mob
        public string mob { get; set; } // Case doesnot matter for auto property.
        //public string mob; // We could also use it instead of auto property
        /* private string mob;
         public string Mob
         {
             get
             {
                 return mob;
             }
             set
             {
                 mob = value;
             }
         }*/







    }
}
