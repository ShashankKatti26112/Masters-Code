using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, r;
            Console.WriteLine("enter the numerator");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            q = int.Parse(Console.ReadLine());
            try
            {
                r = p / q;
                Console.WriteLine("the answer is {0}", r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
