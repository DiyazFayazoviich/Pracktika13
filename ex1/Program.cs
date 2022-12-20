using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] massiv = new string[] { "Ахметвалиев Д.Ф.", "Ашмарин К.В.", "Аркадьева О.Н.", "Ахметвалиев И.А.", "Гареев Д.Э.", "Хуснутдинов Ф.Д.", "Ашмарин К.Ф.", "Гареев Г.Ф.", "Сафаров И.А." };
            int count = 0;
            Console.WriteLine("Количество однофамильцев");
            foreach (string item in massiv)
            {
                string[] massiv2 = item.Split(' ');
                for (int i = 0; i < massiv.Length; i++)
                {
                    string[] massiv3 = massiv[i].Split(' ');
                    if (massiv2[0] == massiv3[0])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{item} - {count - 1}");
                count = 0;
            }
        }

    }
}
