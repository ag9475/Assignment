using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string and a integer");
            string s = Console.ReadLine();
            int i = Convert.ToInt32(Console.ReadLine());
            string i1 = i.ToString();
            int s1 = Int32.Parse(s);
            Console.WriteLine("String : {0} Integer : {1}",i1,s1);
        }
    }
}
