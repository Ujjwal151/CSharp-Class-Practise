using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Abstract_interface_Sealed_Struct_Enum
{
    public class Tool
    {
        public string Size { get; set; }
        public string Price { get; set; }

        public void ToolMethod1()
        {
            Console.WriteLine("Call From ToolMethod1...");
        }
        

    }
}
