/*
 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и 
 * заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, 
 * метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount,
 * возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
 * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * 
 * Сергей Ткачёв
 */
using System;
using System.IO;

namespace ArrayClass
{
    /// <summary>
    /// Класс для одномерного массива
    /// </summary>
    class MyArray
    {
        int[] a;

        /// <summary>Конструктор, создающий массив и заполняющий его заданным значением</summary>
        /// <param name="n">Размер массива</param>
        /// <param name="el">Число, которым будет заполнен массив</param>
        /// <returns></returns>
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        /*
        /// <summary> Конструктор, создающий массив и заполняющий его случайными числами в диапазоне от min до max</summary>
        /// <param name="n">Размер массива</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param> 
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        */

        /// <summary>Конструктор, создающий массив заданной размерности и 
        /// заполняющий массив числами от начального значения с заданным шагом</summary>
        /// <param name="n">Размер массива</param>
        /// <param name="firstElement">Начальное значение</param>
        /// <param name="step">Шаг</param>
        public MyArray(int n, int firstElement, int step)
        {
            a = new int[n];
            a[0] = firstElement;
            for (int i = 1; i < n; i++)
                a[i] = a[i - 1] + step;
        }

        /// <summary>Конструктор, считывающий массив из файла</summary>
        /// <param name="filename">Имя файла</param>
        public MyArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }

        //public int[] A
        //{
        //    get { return a; }
        //    set { a = value; }
        //}

        /// <summary>Свойство, возвращает максимальный элемент массива</summary>
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        /// <summary>Cвойство возвращаем сумму элементов массива</summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        /// <summary>Метод меняет знаки у всех элементов массива</summary>
        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
            }
        }

        /// <summary>Метод умножает каждый элемент массива на определенное число</summary>
        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        /// <summary>Свойство, возвращает минимальный элемент массива</summary>
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        /// <summary>Свойство, возвращает число положительных элементов массива</summary>
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }


        /// <summary>Свойство возвращает количество максимальных элементов</summary>
        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        /// <summary>Метод, возвращающий строковое представление массива</summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        /// <summary>Метод, записывающий массив в файл</summary>
        /// <param name="filename">Название файла</param>
        public void saveIntoFile(string filename)
        {
            StreamWriter wr = new StreamWriter(filename);
            for (int i = 0; i < a.Length; i++)
            {
                wr.WriteLine(a[i]);
            }
            wr.Close();
        }

        /// <summary>Метод, загружающий массив из файла</summary>
        /// <param name="filename">Название файла</param>
        public void loadFromFile(string filename)
        {

            StreamReader sr = new StreamReader(filename);
            int N = 0;
            while (sr.ReadLine() != null) { N++; }

            a = new int[N];
            sr.DiscardBufferedData();
            sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }

    }
}
