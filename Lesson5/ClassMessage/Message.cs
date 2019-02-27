/*
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 * 
 * Сергей Ткачёв
 */

using System;
using System.Text;
using System.Collections.Generic;

namespace ClassMessage
{
    /// <summary>Статический класс Message</summary>
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Лейтенант шел по желтому строительному песку, нагретому дневным палящим солнцем. " +
                "Он был мокрым от кончиков пальцев до кончиков волос, все его тело было усеяно царапинами " +
                "от острой колючей проволоки и ныло от сводящей с ума боли, но он был жив и направлялся к командному штабу, " +
                "который виднелся на горизонте метрах в пятистах. Повторим несколько слов для частотного анализа: шел, его, его, тело, жив, он, ";
        }

        /// <summary>Выводит слова сообщения, которые содержат не более n букв</summary>
        /// <param name="len">Длинна слова</param>
        static public void GetWordsByLength(int len)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            //Console.WriteLine("Вывод слов, длинной не более " + len + ": " );
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }

        /// <summary>Удаляет из сообщения все слова, которые заканчиваются на заданный символ</summary>
        /// <param name="ch">Символ для поиска слов</param>
        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            //Console.WriteLine("Будут удалены слова, оканчивающиеся на символ '" + ch + "': ");
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
            //Console.WriteLine("В результате работы метода, исходный текст изменился на: " + text);
        }

        /// <summary>Находит самое длинное слово сообщения</summary>
        /// <returns></returns>
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;
            
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            //Console.WriteLine("Слово с самой большой длинной: " + maxWord);
            return maxWord;
        }

        /// <summary>Формирует строку StringBuilder из самых длинных слов сообщения</summary>
        /// <returns></returns>
        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            //Console.WriteLine("Полученная строка самых длинных слов: " + result);
            return result;
        }

        /// <summary>Производит частотный анализ текста</summary>
        /// <param name="words">Массив слов</param>
        /// <param name="text">Текст</param>
        static public void FrequencyAnalysis(string[] words, string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] textWords = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFrequency.ContainsKey(word))
                            wordFrequency[word] += 1;
                        else
                            wordFrequency.Add(word, 1);
                    }
                }
            }
            //Console.WriteLine("Частотный анализ текста дал следующий результат: ");
            ICollection<string> keys = wordFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

            foreach (string key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, wordFrequency[key]);
            Console.WriteLine($"\n{result}");
        }
    }
}
