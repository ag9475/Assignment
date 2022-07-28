using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int[] arr1 = new int[3] { 1,2,3};
            int[] arr2 = new int[3] { 4,5,6};
            int[] arr3 = new int[3] { 7,8,9};
            arr.Add(arr1[1]);
            arr.Add(arr2[1]);
            arr.Add(arr3[1]);
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

        }
    }
}
