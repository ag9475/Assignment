using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string a = Console.ReadLine();
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                arr[i] = (int)(char.GetNumericValue(a[i]));
                sum += arr[i];                
            }
            Console.WriteLine("sum : {0}", sum);
        }
    }
}
