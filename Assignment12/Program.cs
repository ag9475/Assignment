using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "";
            string str = Console.ReadLine();
            for (int i = str.Length-1; i > -1 ; i--)
            {
                str1 += str[i];
            }
            if (str1 == str)
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }
        }
    }
}
