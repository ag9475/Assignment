using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Program
    {
        public static int[] reverse(int[] arr)
        {
            int[] arr1 = new int[3];
            int a1 = arr[0];
            int a2 = arr[1];
            int a3 = arr[2];
            arr1[0] = a2;
            arr1[1] = a3;
            arr1[2] = a1;
            return arr1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr = reverse(arr);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}