using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        public static int Add (int a , int b)
        {
            return a + b;
        }
        public static  int subtract(int a, int b)
        {
            return a - b;
        }
        public static double divide(int a, int b)
        {
            return a / b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation to perform : 1 to add  2 to subtract  3 to multiply and  4 to divide ");
            int o = Convert.ToInt32(Console.ReadLine());
            if (o == 1)
            {
                Console.WriteLine("Sum : {0} " , Add(i,j));
            }
            if (o == 2)
            {
                Console.WriteLine("Difference : {0}" , subtract(i,j));
            }

            if (o == 3)
            {
                Console.WriteLine("Product : {0}" , multiply(i, j));
            }

            if (o == 4)
            {
                Console.WriteLine("division : {0}" , divide(i, j));
            }

        }
    }
}
