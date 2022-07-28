using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<4; i++)
            {
                Console.Write("{0}",a);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", a);
            }
        }
    }
}
