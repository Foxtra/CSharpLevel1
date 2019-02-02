/*
 * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 * Сергей Ткачёв
 */

namespace Complex
{
    /// <summary>
    /// Класс для представления комплексного числа
    /// </summary>
    internal class CComplex
    {
        private double im;
        double re;

        /// <summary> Конструктор без параметров</summary>
        public CComplex()
        {
            im = 0;
            re = 0;
        }
        /// <summary> Конструктор с параметрами</summary>
        /// <param name="_im">Мнимая часть</param>
        /// <param name="re">Вещественная часть</param>
        /// <returns></returns>
        public CComplex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        /// <summary> Метод сложения с другим комплексным числом </summary>
        /// <param name="x2">Комплексное число для сложения</param>
        /// <returns></returns>
        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        /// <summary> Метод разности с другим комплексным числом </summary>
        /// <param name="x2">Комплексное число для разности</param>
        /// <returns></returns>
        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        /// <summary> Метод произведения с другим комплексным числом </summary>
        /// <param name="x2">Комплексное число для произведения</param>
        /// <returns></returns>
        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        /// <summary>Свойство для мнимой части</summary>
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        /// <summary> Метод представления комплексного числа в удобной форме</summary>
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
}