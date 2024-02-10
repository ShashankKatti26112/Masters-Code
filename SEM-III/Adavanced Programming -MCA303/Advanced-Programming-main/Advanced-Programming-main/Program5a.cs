using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Baseclass
    {
        public virtual string city()
        {
            return "Bmsce";
        }
    }
    class DerivedClass : Baseclass
    {
        public override string city()
        {
            return "Bmsit";
        }
    }

    class program4a
    {
        public static void Main()
        {
            DerivedClass d = new DerivedClass();
            string city = d.city();
            Console.WriteLine("College Name:{0}", city);
            Console.ReadLine();
        }
    }
}
