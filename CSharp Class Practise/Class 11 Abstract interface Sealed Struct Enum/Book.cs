using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    public struct Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }

        public Book(string bookName, string author)
        {
            BookName = bookName;
            Author = author;
        }


    }
}
