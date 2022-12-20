using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Символы и строки. Обработка строк.";
            int cnt = 0, max = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c)) cnt = 0; else cnt++;
                if (max < cnt) max = cnt;
            }
            Console.WriteLine(max);
        }
    }
}
