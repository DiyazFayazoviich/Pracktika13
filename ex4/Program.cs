using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.Write("Введите шестнадцетеричное число:");
            try
            {
                i = Convert.ToInt32(Console.ReadLine(), 16);
                Console.WriteLine("Да");
                Console.WriteLine(i);
            }
            catch (Exception e)
            {
                Console.WriteLine("Нет");
            }
    }
}
