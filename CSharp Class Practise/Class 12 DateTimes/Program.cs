using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Class_12_DateTimes
{   class Program
    {   public static void Main()
        {
            #region short Pattern
            /* 
            //d = short date, D = Long Date 
            Console.WriteLine(DateTime.Now.ToString("d")); //30-Aug-21
            Console.WriteLine(DateTime.Now.ToString("D")); //Monday, August 30, 2021

            //f = long date short time, F = long date long timde 
            Console.WriteLine(DateTime.Now.ToString("f")); //Monday, August 30, 2021 4:10 PM
            Console.WriteLine(DateTime.Now.ToString("F")); //Monday, August 30, 2021 4:10:23 PM
            
            //g = short date short time, G = short date long time 
            Console.WriteLine(DateTime.Now.ToString("g")); //30-Aug-21 4:11 PM
            Console.WriteLine(DateTime.Now.ToString("G")); //30-Aug-21 4:11:13 PM
            
            //M = Month day
            Console.WriteLine(DateTime.Now.ToString("M")); //August 30
            
            // O = 
            Console.WriteLine(DateTime.Now.ToString("O")); //2021-08-30T16:16:30.4240835+06:00
            
            // R = Full day full time with GMT 
            Console.WriteLine(DateTime.Now.ToString("R")); //Mon, 30 Aug 2021 16:17:17 GMT
            
            // s = shortable Date time
            Console.WriteLine(DateTime.Now.ToString("s")); //2021-08-30T16:25:07
            
            // t = Short time T = Long time
            Console.WriteLine(DateTime.Now.ToString("t")); //4:26 PM
            Console.WriteLine(DateTime.Now.ToString("T")); //4:26:15 PM
            
            // u/U = utc which is 24 hour format
            //u = incliuding z, U = full date full time. At first it convert toUniversal
            Console.WriteLine(DateTime.Now.ToString());                  //30-Aug-21 4:34:56 PM
            Console.WriteLine(DateTime.Now.ToLocalTime().ToString("u")); //2021-08-30 16:34:56Z
            Console.WriteLine(DateTime.Now.ToUniversalTime().ToString("u")); //2021-08-30 10:34:56Z
            Console.WriteLine(DateTime.Now.ToString("U")); // Monday, August 30, 2021 10:34:56 AM
            */
            #endregion
            #region Parse
            // DateTime dt1 = DateTime.Parse("12/10/2021 10:20:30");
            // DateTime dt1 = DateTime.Parse("12/10/2021");
            // DateTime dt1 = DateTime.Parse("2012/10/25");
            // DateTime dt1 = DateTime.Parse("2012/10/25 13:20:30");
            #endregion
            #region Via Constructor
            //DateTime dt = new DateTime(2010, 12, 30, 15, 20, 55);
            //DateTime dt = new DateTime(2010,11,21, 15, 20, 55);  // 21 - Nov - 10 3:20:55 PM
            //DateTime dt = new DateTime(2010,11,21);  // 21-Nov-10 3:20:55 PM
            #endregion
            #region Universal >< Local
            /*DateTime saveNow = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;
            DateTime mydt = DateTime.SpecifyKind(saveNow,DateTimeKind.Unspecified);
            Display("   ",mydt);
            Console.WriteLine();
            mydt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            Display("   ", mydt);
            Console.WriteLine();
            mydt = DateTime.SpecifyKind(utcNow, DateTimeKind.Utc);
            Display("   ", mydt);*/

            //Outside the main function
            /*public static void Display(string title, DateTime input)
            {
                DateTime DT = input;
                DisplayNow("General : ", DT);
                DT = input.ToUniversalTime();
                DisplayNow("Universal : ", DT);
                DT = input.ToLocalTime();
                DisplayNow("Local : ", DT);
            }

            public static string Datepattern = @"dd/MMM/yyyy hh:mm:ss tt";

            public static void DisplayNow(string title, DateTime input)
            {
                string DTstring = input.ToString(Datepattern);
                Console.WriteLine($"{title} {DTstring} {input.Kind}");
            }*/
            #endregion
            #region Pattern
            /*DateTime[] dt = new DateTime[10];
            dt[0] = new DateTime(2010, 11, 30, 00, 20, 55); //30-Nov-10 12:20:55 AM
            dt[1] = new DateTime(2010, 11, 30, 05, 20, 55); //30-Nov-10 5:20:55 PM
            dt[2] = new DateTime(2010, 11, 30, 12, 20, 55); //30-Nov-10 12:20:55 PM
            dt[3] = new DateTime(1015, 05, 25, 15, 10, 30); //25-May-15 3:10:30 PM
            dt[4] = new DateTime(1015, 05, 25, 15, 10, 30, DateTimeKind.Utc); //25-May-15 3:10:30 PM
            dt[5] = new DateTime(2010, 11, 30);             //30-Nov-10 12:00:00 AM
            dt[6] = new DateTime(2050, 11, 30);             //30-Nov-50 12:00:00 AM
            dt[7] = new DateTime(1015, 05, 25, 15, 10, 30, 50);
            dt[8] = new DateTime(1015, 05, 25, 15, 10, 30, 50, DateTimeKind.Utc);
            dt[9] = new DateTime(1015,10,12);
            
            int i = 0;
            foreach( DateTime var in dt)
            {
                String dtstring = var.ToString(Datepattern);
                Console.WriteLine($"dt[{i++}] = "+ var.ToString(Datepattern));
                Console.WriteLine(var);
            }

            //Outside the main function 
            public static string Datepattern = "dd/MMM/yyyy hh:mm:ss.ff tt";*/
            #endregion

            Console.ReadLine();
        }

    }
}
