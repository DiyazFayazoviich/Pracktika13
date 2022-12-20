using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "11 22 33 44 55 66";
            string s = "Clever student want to study";
            string[] massiv = s.Split(' ');

            for (int i = 0; i < massiv.Length; i++)
            {
                if ((i + 1) % 2 == 0 && i != 0)
                {
                    Console.Write(massiv[i] + ' ');
                }
            }

            Console.WriteLine("\n" + massiv.Length + " слов");
        }
    }
}
