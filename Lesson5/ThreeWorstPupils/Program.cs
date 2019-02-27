/*
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
 * В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>, где <Фамилия> — строка, состоящая из не более чем из 20 символов, 
<Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, 
соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. 
Пример входной строки: Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 * 
 * Сергей Ткачёв
 */

using System;
using System.IO;
struct Element
{
    public string FI;
    public double avgNote;
}
class Program
{
    /// <summary>Метод сортировки массива учеников</summary>
    /// <param name="pupils">Массив учеников</param>
    static void SortPupils(ref Element[] pupils)
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            for (int j = 0; j < pupils.Length-i-1; j++)
            {
                if (pupils[j].avgNote > pupils[j + 1].avgNote)
                {
                    Element tmp = pupils[j + 1];
                    pupils[j + 1] = pupils[j];
                    pupils[j] = tmp;
                }   
            }
        }
    }

    static void Main(string[] args)
    {
        int amountOfWorstPupils = 3;
        StreamReader sr = new StreamReader("..\\..\\data.txt", encoding: System.Text.Encoding.GetEncoding(1251));
        int N = int.Parse(sr.ReadLine());
        Element[] a = new Element[N];
        for (int i = 0; i < N; i++)
        {
            string[] s = sr.ReadLine().Split(' ');
            a[i].FI = s[0] + " " + s[1];
            a[i].avgNote = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
        }
        sr.Close();

        SortPupils(ref a);

        String result = String.Format("{0,-20} {1,-10}\n\n", "Ученик", "Средний балл");

        Element prev = a[0];

        for (int i = 0; i < amountOfWorstPupils; i++)
        {
            if (i > 0)
            {
                if (prev.avgNote == a[i].avgNote)
                    amountOfWorstPupils++;
                prev = a[i];
            }

            result += String.Format("{0,-20} {1,-10:F2}\n",
                                   a[i].FI, a[i].avgNote);

        }

        Console.WriteLine("Вас приветствует программа вывода на экран учеников с тремя худшими средними баллами.");

        Console.WriteLine($"\n{result}");

        Console.ReadKey();
    }
}

