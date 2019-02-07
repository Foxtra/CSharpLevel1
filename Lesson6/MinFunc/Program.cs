/*
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 * 
 * Сергей Ткачёв
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace MinFunc
{
    /// <summary>Делегат функции с сигнатурой double, double</summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double Fun(double x);

    class Program
    {
        /// <summary>Метод производит расчёт значения переданной функции и записывает в файл двоинчм потоком</summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="start">Начальное значение аргумента</param>
        /// <param name="end">Конечное значение агрумента</param>
        /// <param name="step">Шаг дисретизации</param>
        /// <param name="F">Делегат функции</param>
        public static void SaveFunc(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            
            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>Функция возвращает массив значений из файла и находит минимальное</summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="min">Переменная минимума с ключевым словом out</param>
        /// <returns></returns>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        /// <summary>Функция возведения в квадрат</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double secondDegree (double x)
        {
            return x * x;
        }

        /// <summary>Функция возведения в третью степень</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double thirdDegree(double x)
        {
            return x * x * x;
        }

        /// <summary>Функция квадратного корня</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double mySqrt(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>Функция синуса</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Sin(double x)
        {
            return Math.Sin(x);
        }

        /// <summary>Метод проверяет ввод целочисленного значения, меньше заданого</summary>
        /// <param name="max">Максимальное значение, которое может ввести пользователь</param>
        /// <returns></returns>
        static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write("Неверный ввод (требуется числовое значение от 0 до {0}).\nПожалуйста повторите ввод: ", max);
                else return x;
        }

        /// <summary>Метод получает значения начала отрезка и конца из одной строки</summary>
        /// <param name="start">Начало отрезка</param>
        /// <param name="end">Конец отрезка</param>
        static void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0], CultureInfo.InvariantCulture);
            end = double.Parse(interval[1], CultureInfo.InvariantCulture);
        }

        /// <summary>Метод выводит на экран значение функции и её аргумента</summary>
        /// <param name="start">Начальное значенеи аргумента</param>
        /// <param name="end">Конечное значение аргумента</param>
        /// <param name="step">Шаг дискредитирования</param>
        /// <param name="values">Массив значений функции</param>
        static void PrintResults(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует программа нахождения минимума функции!");
            List<Fun> functions = new List<Fun> { new Fun(secondDegree), new Fun(thirdDegree), new Fun(mySqrt), new Fun(Sin) };
            Console.WriteLine("Выберите функцию для дальнейшей работы.");
            Console.WriteLine("1) f(x)=y^2");
            Console.WriteLine("2) f(x)=y^3");
            Console.WriteLine("3) f(x)=y^1/2");
            Console.WriteLine("4) f(x)=Sin(y)");
            int userChoose = GetInt(functions.Count);

            Console.WriteLine("Задайте отрезок для нахождения минимума в формате 'х1 х2':");

            double start = 0;
            double end = 0;
            GetInterval(out start, out end);

            Console.WriteLine("Задайте величинау шага дискредитирования:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            SaveFunc("data.bin", start,end,step,functions[userChoose-1]);
            double min = double.MaxValue;
            Console.WriteLine("Получены следующие значения функции: ");
            PrintResults(start, end, step, Load("data.bin", out min));
            Console.WriteLine("Минимальное значение функции равняется: {0:0.00}", min);
            Console.ReadKey();
        }
    }
}
