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
    /// <summary>
    /// Класс для двумерного массива
    /// </summary>
    class myDimensionalArray
    {
        public int[,] a;

        /// <summary>Конструктор, заполняющий массив случайными числами</summary>
        /// <param name="n">Количество строк</param>
        /// <param name="m">Количество столбцов</param>
        public myDimensionalArray(int n, int m)
        {
            a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i,j] = rnd.Next();
        }

         /// <summary>Свойство, возвращает максимальный элемент массива</summary>
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];

                return max;
            }
        }

        /// <summary>Метод возвращает сумму элементов массива</summary>
        public void Sum(out int sum)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    sum += a[i,j];
        }

        /// <summary>Метод номер максимального элемента массива </summary>
        public void IndexOfMax(out string index)
        {
            index = "-1, -1";
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] == max)
                        index = i + ", " + j;
        }

        /// <summary>Метод возвращает сумму элементов больше заданного</summary>
        public void SumMoreThan(out int sum, int min)
        {
            sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i, j] > min)
                        sum += a[i, j];
                }
        }

      /// <summary>Свойство, возвращает минимальный элемент массива</summary>
        public int Min
        {
            get
            {
                int min = a[0,0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i,j] < min) min = a[i,j];
                    
                return min;
            }
        }

       
        /// <summary>Метод, возвращающий массив строк с элементами массива</summary>
        /// <returns></returns>
        public string[] toString()
        {
            string[] s = new string[a.GetLength(0)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                s[i] += "[ ";
                for (int j = 0; j < a.GetLength(1); j++)
                    s[i] += a[i, j] + " ";
                s[i] += " ]";
            }
            return s;
        }

    }
}
