using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = Console.ReadLine();
            string[] words = Str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > ctr)
                {
                    word = words[i];
                    ctr = words[i].Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
