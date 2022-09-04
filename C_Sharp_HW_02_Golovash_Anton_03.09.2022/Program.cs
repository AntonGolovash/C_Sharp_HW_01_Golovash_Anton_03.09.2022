using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_02_Golovash_Anton_03._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0;
            int b = 0;
            int c = 0;
        Start_of_the_program:
            Console.WriteLine("Enter the short side of the rectangle");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the long side of the rectangle");
            Console.WriteLine("The value must be less than the short side of the rectangle");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0 && a < b)
            {
                goto Continuation;
            }
            else
            {
                Console.WriteLine("Please, enter correct data");
                goto Start_of_the_program;
            }
        Continuation:
            Console.WriteLine("Enter the side of a square inscribed in a rectangle");
            Console.WriteLine("The value must be less than the long side of the first rectangle");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < b)
            {
                goto Continuation1;
            }
            else
            {
                Console.WriteLine("Please, enter correct data");
                goto Continuation;
            }
        Continuation1:
            double vertical_division_result = (double)(a / c);
            double horizontal_division_result = (double)(b / c);
            double vertical_remainder_of_division = (double)(a % c);
            double horizontal_remainder_of_division = (double)(b % c);
            double number_of_inscribed_squares = vertical_division_result * horizontal_division_result;
            double area_of_unoccupied_part_of_rectangle = vertical_remainder_of_division * horizontal_remainder_of_division;
            Console.WriteLine($"On a rectangle, you can place {number_of_inscribed_squares} squares");
            Console.WriteLine($"Area of unoccupied part of the rectangle {area_of_unoccupied_part_of_rectangle} ");

            Console.ReadLine();
        }
    }
}
