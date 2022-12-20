using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "111 22 3333 4 5555";
            string s = "111 000 3333 444444";
            string[] massiv = s.Split(' ');
            int g = massiv[0].Length;
            string h = "";
            for (int i = 0; i < massiv.Length; i++)
            {
                if (g > massiv[i].Length)
                {
                    h = massiv[i] + " ";
                }
                else if (g == massiv[i].Length)
                {
                    h = h.Insert(h.Length, " " + massiv[i]);
                }

            }
            Console.WriteLine(h);
        }
    }
}
