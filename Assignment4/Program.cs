using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static int multiply(int a ,ref int p)
        {   
            p = p += a;
            return p;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n,i, multiply(n , ref p));
            }
        }
    }
}
