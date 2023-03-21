using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Деление обыкновенных дробей");
            Console.Write("Введите первый числитель:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите первый знаменатель:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите второй числитель:");
            double v = double.Parse(Console.ReadLine());
            Console.Write("Введите второй знаменатель:");
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0)

            {
                double z = (x / c) % (v / y);
                Console.WriteLine("z = {0}", z);
            }
            else
            {
                Console.WriteLine("Нету решения");
            }

            Console.ReadKey();

        }
    }
}
