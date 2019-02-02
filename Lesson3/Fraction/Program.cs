/*
 *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса. 
 ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 ** Добавить упрощение дробей.
 * Сергей Ткачёв
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        /// <summary>
        /// Функция проверки ввода без обработки исключений
        /// </summary>
        /// <returns></returns>
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static Fraction Init(int numerator, int denumerator)
        {
            bool checkException;
            Fraction fraction = null;
            do
            {
                checkException = false;
                try
                {
                    fraction = new Fraction(numerator, denumerator);
                }
                catch (ArgumentException ex)
                {
                    checkException = true;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    denumerator = GetInt();
                }
            } while (checkException);
            
            return fraction;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа работы с дробями!");
            Console.Write("Введите числитель первой дроби: ");
            int n1 = GetInt();
            Console.Write("Введите знаминатель первой дроби: ");
            int d1 = GetInt();
            Console.Write("Введите числитель второй дроби: ");
            int n2 = GetInt();
            Console.Write("Введите знаминатель второй дроби: ");
            int d2 = GetInt();
            Fraction fraction1 = Init(n1, d1);
            Fraction fraction2= Init(n2, d2);

            Console.WriteLine();
            Fraction result = fraction1.Plus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции сложения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
                + result.ToString());
            result = fraction1.Minus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции вычитания чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Multi(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции умножения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Division(fraction2);
            result.Simplification();
            Console.WriteLine("Результом операции деления чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());

            Console.ReadKey();
        }
    }
}
