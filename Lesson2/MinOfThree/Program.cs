/*
 * Написать метод, возвращающий минимальное из трех чисел.
 * Ткачёв Сергей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {

        static int minOfThree (int a, int b, int c)
        {
            if (a >= b)
            {
                if (b >= c)
                {
                    return c;
                }
                else
                {
                    return b;
                }

            }
            else
            {
                if (a >= c)
                {
                    return c;
                }
                else
                {
                    return a;
                }
            }
        }

        static int GetInt() //проверяем ввод
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа 'минимальное из трёх' ");
            Console.Write("Введите первое число: ");
            int a = GetInt();

            Console.Write("Введите второе число: ");
            int b = GetInt();

            Console.Write("Введите третье число: ");
            int c = GetInt();

            Console.WriteLine(Environment.NewLine + "Минимальным является: " + minOfThree(a,b,c));                   

            Console.ReadKey();
        }
    }
}
