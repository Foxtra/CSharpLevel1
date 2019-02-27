/*
 * *а) Реализовать класс для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
 * возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
 * возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
 * *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * в) Обработать возможные исключительные ситуации при работе с файлами.
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

        /// <summary>Конструткор по умолчанию</summary>
        public myDimensionalArray() { }

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

        /// <summary>Конструктор, считывающий двумерный массив из файла</summary>
        /// <param name="filename">Имя файла</param>
        public myDimensionalArray(string filename)
        {
            filename = "..\\..\\" + filename;
            string[] ss = new string[0];
            try
            {
                ss = File.ReadAllLines(filename);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }

            a = new int[ss.Length, ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {
                string[] tempArray = ss[i].Split(' ');
                for (int j = 0; j < ss.Length; j++)
                {
                    a[i, j] = int.Parse(tempArray[j]);
                }
            }
            
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
        public void Sum(out long sum)
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
        public void SumMoreThan(out long sum, int min)
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
                    s[i] += String.Format($"{a[i, j]:D10} ");
                s[i] += " ]";
            }
            return s;
        }

        /// <summary>Метод выводит в консоль двумерный массив</summary>
        /// <param name="array">Массив строк содержащий строки массива</param>
        public void PrintDinArr(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>Метод, записывающий двумерный массив в файл</summary>
        /// <param name="filename">Название файла</param>
        public void saveIntoFile(string filename)
        {
            filename = "..\\..\\" + filename;

            try
            {
                StreamWriter wr = new StreamWriter(filename);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        wr.Write(a[i, j] + " ");
                    wr.Write(Environment.NewLine);
                }
                wr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }
        }

        /// <summary>Метод, загружающий двумерный массив из файла</summary>
        /// <param name="filename">Название файла</param>
        public void loadFromFile(string filename)
        {
            filename = "..\\..\\" + filename;

            try
            {
                StreamReader sr = new StreamReader(filename);
                int N = 0;
                while (sr.ReadLine() != null) { N++; }

                a = new int[N, N];
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                for (int i = 0; i < N; i++)
                {
                    string[] tempArray = sr.ReadLine().Split(' ');
                    for (int j = 0; j < tempArray.Length - 1; j++)
                    {
                        a[i, j] = int.Parse(tempArray[j]);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }

            
        }

    }
}
