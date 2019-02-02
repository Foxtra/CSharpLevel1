/*
 * *а) Реализовать класс для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
 * возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
 * возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
 * 
 * Сергей Ткачёв
 */

using System;
using System.IO;

namespace twoDimensionalArray
{

    class Program
    {
        /// <summary>Метод считывает строку и проверяет на корректный целочисленный ввод</summary>
        /// <returns></returns>
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с двумерным массивом");

            Console.Write("Введите желаемое количество строк массива: ");
            int size1 = GetInt();
            Console.Write("Введите желаемое количество столбцов массива: ");
            int size2 = GetInt();


            myDimensionalArray a = new myDimensionalArray(size1, size2);

            Console.WriteLine("\nСоздан массив: ");

            string[] array = a.toString();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int sum = 0;
            a.Sum(out sum);

            Console.WriteLine("Сумма элементов массива: " + sum);

            a.SumMoreThan(out sum, a.a[0, 0]);
           Console.WriteLine("Cумма элементов массива, которые больше, первого элемента: " + sum);

            Console.WriteLine("Максимальный элемент массива: " + a.Max);

            Console.WriteLine("Минимальный элемент массива: " + a.Min);

            string numOfMax = "";
            a.IndexOfMax(out numOfMax);
            Console.WriteLine("Номер максимального элемента: " + numOfMax);

            Console.ReadKey();
        }
    }
}
