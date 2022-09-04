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

            int r = 0;
            Console.WriteLine("Input circle radius");
            r = Convert.ToInt32(Console.ReadLine());
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
