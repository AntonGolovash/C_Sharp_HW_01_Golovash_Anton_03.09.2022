using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_01_Golovash_Anton_03._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задание 1
             * Дано целое положительное число г.
             * Значение этого числа программа должна запрашивать у пользователя.
             * Рассчитать площадь окружности вычисляется по формуле: So = п * r^2
             * Задание 2
             * Дано целое положительное число г.
             * Значение этого числа программа должна запрашивать у пользователя.
             * Рассчитать длину окружности вычисляется по формуле L = 2 * п * r
            */

            double r = 0;
            Console.WriteLine("Input circle radius");
            r = Convert.ToDouble(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine($"Square of a circle {Math.PI * Math.Pow(r, 2)}");
                Console.WriteLine($"Circumference of a circle {2 * Math.PI * r}");
            }
            else
            {
                Console.WriteLine("The number should be positive");
            }

            Console.ReadLine();
        }
    }
}
