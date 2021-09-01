using System;
using System.Collections.Generic;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Book
            /*
            Book book1 = new Book("The Light", "Devid Karnel");
            Book book2 = new Book("The Light", "Devid ");
            Book book3 = new Book();
            List<Book> BookList = new List<Book>();
            BookList.Add(book1);
            BookList.Add(book2);
            BookList.Add(book3);

            int? x = 12;
            if(x != null)
            {
                Console.WriteLine(x.Value);
            }
            else Console.WriteLine("NULL");

            showBook(BookList);
            */
            #endregion
            Console.WriteLine();
            int x = (int)Days.Tuesday;
            Console.WriteLine(x);

            Months d = (Months)x;
            Console.WriteLine(d);
        }

        public enum Months
        {
            January = 7,
            February,
            March,
        }
        public enum Days
        {
            Sunday = 5,
            Monday ,
            Tuesday,
        }

        public static void UpdateDayName(Days dayName)
        {
            if(dayName == Days.Sunday)
            {
                
            }
        }

        /*public static void showBook(List<Book> BookList)
       {
           foreach(var book in BookList)
           {
               Console.WriteLine(book.Author +" "+book.BookName);
           }
       }*/

    }
}
