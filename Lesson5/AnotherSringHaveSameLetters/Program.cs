/*
 * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
 а) с использованием методов C#;
 б) *разработав собственный алгоритм.
 * 
 * Сергей Ткачёв
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherSringHaveSameLetters
{
    class Program
    {
        /// <summary>Метод определяет, является ли одна строка перестановкой другой, используя методы C#</summary>
        /// <param name="s1">Первая строка</param>
        /// <param name="s2">Вторая строка</param>
        /// <returns></returns>
        static bool isThisPermutation(string s1, string s2)
        {
            return s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));
        }

        /// <summary>Метод определяет, является ли одна строка перестановкой другой, используя собственный алгоритм</summary>
        /// <param name="s1">Первая строка</param>
        /// <param name="s2">Вторая строка</param>
        /// <returns></returns>
        static bool isThisPermutation2(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            string news1 = s1[0].ToString();
            string news2 = s2[0].ToString();

            for (int i = 1; i < s1.Length; i++)
                putCharIntoStr(ref news1, s1[i]);

            for (int i = 1; i < s2.Length; i++)
                putCharIntoStr(ref news2, s2[i]);

            if (news1.Equals(news2))
                return true;
            else
                return false;
        }

        /// <summary>Метод вставляет новый символ в строку в алфовитном порядке</summary>
        /// <param name="s">Строка</param>
        /// <param name="ch">Новый символ</param>
        static void putCharIntoStr (ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            string first = "ambiguous";
            string second = "asmuboiug";

            Console.WriteLine("Вас приветствует программа проверки является ли одна строка перестановкой другой.");

            Console.WriteLine("Проверим следующие строки: " + first + ", и " + second);

            if (isThisPermutation(first, second) == true && isThisPermutation2(first, second) == true)
                Console.WriteLine("Строки являются перестановками друг друга.");
            else
                Console.WriteLine("Строки состоят из разных символов.");

            Console.ReadKey();
        }
    }
}
