using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sn = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    continue;
                }
                else
                {
                    sn += s[i];
                }
            }
            Console.WriteLine(sn);
        }
    }
}
