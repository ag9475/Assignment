using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        public static void fn1(ref int a ,ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }
        static void Main(string[] args)
        {
            int i = 2, j = 3;
            fn1(ref i , ref j);
            Console.WriteLine("New value of I : {0} and J : {1}", i, j);
        }
    }
}
