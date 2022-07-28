using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        public static string test(string str)
        {
            str = str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            Console.WriteLine("Reversed string : {0}", test(s));
        }
    }
}
