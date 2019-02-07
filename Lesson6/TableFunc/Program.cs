/*
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * 
 * Сергей Ткачёв
 */

using System;

namespace TableFunc
{
    /// <summary>Делегат с сигнатурой double, double, double</summary>
    /// <param name="a">Параметр "а"</param>
    /// <param name="x">Параметр "х"</param>
    /// <returns></returns>
    public delegate double Fun(double a, double x);

    class Program
    {
        /// <summary>Метод, принимающий делегат</summary>
        /// <param name="F">Метод с сигнатурой double, double, double</param>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <param name="b">Количество строк в таблице</param>
        public static void Table(Fun F,double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a,x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        /// <summary>Метод возвращает значение функции a*x^2</summary>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        /// <summary>Метод возвращает значение функции a*sin(x)</summary>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a*x^2:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc),-1.5, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(MyFunc), 3, -2, 2);

            Console.ReadKey();
        }
    }

}
