/*
 Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 В результате вся информация выводится в одну строчку. 
 Ткачёв Сергей 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Вас приветствует программа-анкета." + 
                Environment.NewLine + "Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите свою Фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите свой рост: ");
            string heigth = Console.ReadLine();

            Console.Write("Введите свой вес: ");
            string weigth = Console.ReadLine();

            Console.WriteLine(Environment.NewLine + "Склеивание.");            
            string oneString = name + surname + heigth + weigth;
            Console.WriteLine(oneString);

            Console.WriteLine(Environment.NewLine + "Форматированный вывод.");
            Console.WriteLine("{0:D1}, {1:D1}, {2:D3}, {3:D3}", name, surname, int.Parse(heigth), int.Parse(weigth));

            Console.WriteLine(Environment.NewLine + "Вывод со знаком $.");
            Console.WriteLine($"{name}, {surname}, {int.Parse(heigth):###}, {int.Parse(weigth):###}");

            Console.ReadKey();
        }
    }
}
