/*
 * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
 * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
 * При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 * Сергей Ткачёв
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDataWithExeption
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
        /// <summary>
        /// Функция проверки ввода с обработкой исключений
        /// </summary>
        /// <returns></returns>
        static int CheckExeptionByInput()
        {
            int result = 0;
            bool exceptionCatched;
            do
            {
                exceptionCatched = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    exceptionCatched = true;
                    string message = ex.Message;
                    Console.WriteLine("Возникло исключение: " + message);
                    Console.Write("Пожалуйста, повторите ввод: ");
                }
                
            } while (exceptionCatched);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = CheckExeptionByInput();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество чисел: " + AmountOfOddNumbers);

            Console.ReadKey();
        }
    }
}
