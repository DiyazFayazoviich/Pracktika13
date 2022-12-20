using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracktika13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = ""; double k = 0; int g = 0; double num = 0; bool u = true; bool q = false;
            while (u == true)
            {
                Console.WriteLine("Введите двоичное число: ");
                x = Console.ReadLine();
                foreach (char c in x)
                {
                    if (c == '1' || c == '0')
                    {
                        u = false;
                        q = true;
                    }
                    else
                    {
                        q = false;

                    }
                }
                k = x.Length - 1;
            }
            if (q == true)
            {
                while (k >= 0)
                {
                    num += double.Parse(Convert.ToString(x[g])) * Math.Pow(2, k);
                    k--;
                    g++;
                }
                Console.WriteLine($"Двоичное число {x} в десятичной равно = {num}");
            }
        }

    }
}
