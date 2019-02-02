/*
 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * б) Сделать задание, только вывод организуйте в центре экрана
 * в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
 * Ткачёв Сергей
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSurnameCity
{
    class Program
    {
        static void Print(string[] msg, int x, int y)
        {
            // Установим позицию курсора на экране
            
            for (int i = 0; i < msg.Length; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.WriteLine(msg[i]);
            }
            
        }


        static void Main(string[] args)
        {
            string[] info = { "Sergey", "Tkachev", "Saint Petersburg" };

            
            Print(info, 50, 13);

            Console.ReadKey();
        }
    }
}
