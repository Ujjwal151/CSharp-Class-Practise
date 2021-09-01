using System;

namespace Class_6_String_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "  012 3456 789      ";
            s = s.TrimStart();
            Console.WriteLine("."+s+".");
            //Console.WriteLine( s.Insert(4, "--"));
            //int index = s.LastIndexOf("ak");
            //int index = s.LastIndexOfAny(new char[] { 'n', ',','g' },6,2);
            //Console.WriteLine($"1.{index}");
        }
    }
}
