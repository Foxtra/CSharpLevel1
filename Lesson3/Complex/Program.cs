/*
 * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 * Сергей Ткачёв
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    /// <summary>
    /// Структура для представления комплексного числа
    /// </summary>
    struct Complex
    {
        public double im;
        public double re;

        /// <summary> Метод сложения с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для сложения</param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary> Метод разности с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для разности</param>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        /// <summary> Метод произведения с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для произведения</param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary> Метод представления комплексного числа в удобной форме</summary>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Рассмотрим результат работы структуры:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Рассмотрим результат работы класса:");
            CComplex ccomplex1 = new CComplex(1, 1);
            CComplex ccomplex2 = new CComplex(2, 2);
            ccomplex2.Im = 3;
            CComplex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());

            Console.ReadKey();
        }
    }
}
