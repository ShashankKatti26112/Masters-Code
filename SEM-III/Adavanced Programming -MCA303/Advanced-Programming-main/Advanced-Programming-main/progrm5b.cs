using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg4b
{
    public delegate int deli(int n, int m);
    public class pgm9
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int diff(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
    public class program9
    {
        public static void Main()
        {
            pgm9 p1 = new pgm9();
            deli d = p1.sum;
            int i = d(10, 20);
            pgm9 p2 = new pgm9();
            deli e = p2.diff;
            int j = e(40, 20);
            pgm9 p3 = new pgm9();
            deli f = p3.mul;
            int k = f(10, 20);
            pgm9 p4 = new pgm9();
            deli g = p4.div;
            int l = g(10, 20);
            Console.WriteLine("The sum is " + i + "\n The difference is " + j + "\n The product is " + k + "\n The quotient is " + l);
            Console.ReadLine();
        }
    }
﻿
