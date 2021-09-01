using System;

namespace Class_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Topic 1 : Student
            /*            Student st1 = new Student();
                        Student st2 = new Student("Ujjwal Ojha");
                        st1.display();
                        st2.display();
                        st1.EditStudentsInfo();
                        st1.display();*/
            #endregion

            #region Topic 2 : Static Area
            /* AreaCalculator.Course = "GEOMETRY";

             AreaCalculator ac1 = new AreaCalculator();
             double x = ac1.CircleArea(10);
             Console.WriteLine("Circle Area = " + x);

             AreaCalculator ac2 = new AreaCalculator();
             double y = ac2.RectangleArea(10, 20);
             Console.WriteLine("Rec Area " + y);

             ac1.Print();
             ac2.Print();*/
            #endregion

            #region Topic 3 : Static
            /*display(5);
            static void display(int x)
            {
                Console.WriteLine("This is a method"+x*x);
            }*/
            #endregion

            Circle c = new Circle();
            
            Console.WriteLine(c.GetArea());

        }
    }
}
