/*
 *  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 *  нужно ли человеку похудеть, набрать вес или все в норме;
 *  б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 *  Ткачёв Сергей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {

        static string CheckNorm(double bmi, double heigth)
        {
            string result = "";
            if (bmi >= 18.5 && bmi <= 24.99)
            {
                result = "Всё в норме!";
            }
            else if(bmi < 18.5)
            {
                double recommendation = (18.5 - bmi)* heigth * heigth;
                result = String.Format("Необходимо набрать {0:0.00} кг для нормализации веса!", recommendation);
            }
            else if (bmi > 24.99)
            {
                double recommendation = (bmi - 24.99) * heigth * heigth;
                result = String.Format("Необходимо сбросить {0:0.00} кг для нормализации веса!", recommendation);
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Вас приветствует программа для рассчёта ИМТ." +
               Environment.NewLine + "Введите вес человека в кг: ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth /= 100;

            Console.Write(Environment.NewLine + "Индекс массы тела: ");
            double BMI = mass / (heigth * heigth);
            Console.WriteLine("{0:0.##}", BMI);

            Console.WriteLine(CheckNorm(BMI, heigth));


            Console.ReadKey();
        }
    }
}
