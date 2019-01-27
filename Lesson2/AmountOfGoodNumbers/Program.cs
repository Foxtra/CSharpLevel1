/*
 * *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * Хорошим называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 * Ткачёв Сергей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfGoodNumbers
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

        static bool CheckGoodNumber(int value)
        {
            string s = Convert.ToString(value);
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i] - '0';
            }
            if (value % sum == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int AmountOfGoodNumbers = 0;
            Console.WriteLine("Вас приветствует программа подсчета подсчета количества «Хороших» чисел");
            Console.Write("Задайте диапазон: от 1 до ");

            int end = GetInt();
            DateTime start = DateTime.Now;

            for (int i = 1; i < end; i++)
            {
                if (CheckGoodNumber(i))
                {
                    AmountOfGoodNumbers++;
                }
            }

            Console.Write("\nВремя работы программы: ");
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine("\nВ заданном диапазоне содержится " + AmountOfGoodNumbers + " «Хороших» чисел");

            Console.ReadKey();
        }
    }
}
