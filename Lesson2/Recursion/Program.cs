/*
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 * Ткачёв Сергей
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static int GetInt() //проверяем ввод
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                else return x;
        }

        static void PrintFromTo(int start, int end)
        {
            if (start == end)
            {
                Console.Write("\b\b");
                Console.Write(" ");
                return;
            }
            else
            {
                Console.Write(start + ", ");
                start++;
                PrintFromTo(start, end);
            }
        }

        static long SumFromTo(int start, int end, long result)
        {
            if (start == end) return result;
            else
            {
                result += start;
                start++;
                return SumFromTo(start, end, result);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа рекурсивного подсчета чисел от a до b");

            Console.Write("Введите число а: ");
            int a = GetInt();

            Console.Write("Введите число b: ");
            int b = GetInt();

            Console.Write("\nЧисла, входящие в промежуток: ");
            PrintFromTo(a, b);

            Console.WriteLine("\nСумма чисел: " + SumFromTo(a,b,0));

            Console.ReadKey();
        }
    }
}
