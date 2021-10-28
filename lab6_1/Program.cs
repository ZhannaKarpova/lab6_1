using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {   string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            char[] separ = { ' ' };
            string[] str = startString.Split(separ);
            int max = str.Length;
            for (int i = 0; i < str.Length; i++)
                if (max < str[i].Length) { max = str[i].Length; }
            for (int i = 0; i < str.Length; i++)
                if (max == str[i].Length)
                { Console.WriteLine(str[i]); }
            Console.WriteLine(max);

            Console.ReadLine();

        }
    }
}
