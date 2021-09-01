using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Interface
{
    public interface Icloseable
    {
        string Name { get; set; }
        int Age { get; set; }
        void Close();
        string Getname();
        
    }
}
