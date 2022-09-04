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
            /*
            * 1. Даны целые положительные числа А, B, C.
            * Значение этих чисел программа должна запрашивать у пользователя.
            * На прямоугольнике размера А*В размещено максимально возможное
            * количество квадратов со стороной С.
            * Квадраты не накладываются друг на друга.
            * Найти количество квадратов, размещенных на прямоугольнике,
            * а также площадь незанятой части прямоугольника.
            * Необходимо предусмотреть служебные сообщения в случае,
            * если в прямоугольнике нельзя разместить ни одного квадрата
            * со стороной С (например, если зна чение С превышает размер сторон прямоугольника).
            */
            Console.WriteLine("TASK 1");

            double a = 0;
            double b = 0;
            double c = 0;

        Start_of_the_program:

            Console.WriteLine("Enter the short side of the rectangle");
            
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the long side of the rectangle");
            Console.WriteLine("The value must be less than the short side of the rectangle");
            
            b = Convert.ToDouble(Console.ReadLine());
            
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
           
            c = Convert.ToDouble(Console.ReadLine());
            
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

            double vertical_division_result = (a / c);
            double horizontal_division_result = (b / c);
            double vertical_remainder_of_division = (a % c);
            double horizontal_remainder_of_division = (b % c);
            double number_of_inscribed_squares = vertical_division_result * horizontal_division_result;
            double area_of_unoccupied_part_of_rectangle = vertical_remainder_of_division * horizontal_remainder_of_division;
            
            Console.WriteLine($"On a rectangle, you can place {number_of_inscribed_squares} squares");
            Console.WriteLine($"Area of unoccupied part of the rectangle {area_of_unoccupied_part_of_rectangle} ");

            /*
            * 2. Начальный вклад в банке равен 10000 грн.
            * Через каждый месяц размер вклада увеличивается на р процентов
            * от имеющейся суммы (Р вещественное число, 0 <P < 25).
            * Значение Р программа должна полу чать у пользователя.
            * По данному Р определить через сколько месяцев размер вклада
            * превысит 11000 грн., и вывести найденное количество месяцев К
            * (целое число) и итоговый размер вклада S (вещественное число).
            */

            Console.WriteLine("TASK 2");

            Console.WriteLine("Enter the annual interest rate on the deposit");
            Console.WriteLine("Deposit rate must be greater than 0 and equal to or less than 25");

            double annual_interest_rate = Convert.ToDouble(Console.ReadLine());
            double monthly_interest_rate = annual_interest_rate / 12;
            double deposit_amount = 10000;
            int months = 0;
            
            while (deposit_amount <= 11000)
            {
                deposit_amount += (deposit_amount * (monthly_interest_rate / 100));
                ++months;
            }

            Console.WriteLine($"After {months} months will the deposit exceed 11000");
            Console.WriteLine($"The total amount of the contribution will be {deposit_amount}");

            /*
            * 3. Даны целые положительные числа А и В (А < В).
            * Вывести все целые числа от А до В включительно;
            * каждое число должно выводиться на новой строке;
            * при этом каждое число должно выводиться количество раз,
            * равное его значению (например, число 3 выводится 3 раза).
            */

            Console.WriteLine("TASK 3");

            int A = 3;
            int B = 7;

            while (A <= B)
            {
                for (int i = A; i > 0; --i)
                {
                    Console.Write(A);
                }
                ++A;
                Console.WriteLine();
            }

            /*
             * 4. Дано целое число N большее 0, найти число,
             * полученное при прочтении числа N справа налево.
             * Например, если было введено число 345,
             * то программа должна вывести число 543.
            */

            Console.WriteLine("TASK 4");
            string s = "123456789";
            Console.WriteLine(s);
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);

            Console.ReadLine();

        }
    }
}
