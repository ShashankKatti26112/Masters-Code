using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3b
{
    class Program3b
    {
        static void Main(string[] args)
        {
            int i=0, sum=0;
            int[] arr= new int[5]{50,40,30,20,10};
            try
            {
                for (i = 0; i <= 5; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine("sum =" + sum);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
