using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public abstract class program
    {
        public abstract int mul(int a, int b);
        public void displ()
        {
            Console.WriteLine("Abstract class program");
        }
    }
    public class demo : program
    {
        public override int mul(int a, int b)
        {
            return a * b;
        }
    }
    public class main
    {
        public static void Main()
        {
            demo d = new demo();
            int j = d.mul(20, 30);
            d.displ();
            Console.WriteLine("The Multipliction of {0} * {1} = {2}", 20, 30, j);
            Console.ReadLine();
        }
    }
}
