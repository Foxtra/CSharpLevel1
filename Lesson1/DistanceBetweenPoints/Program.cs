/*
 а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
 Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
 б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 Ткачёв Сергей
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 1.5;
            double y1 = 3.8;
            double x2 = 7.6;
            double y2 = 10.3;

            Console.Write("Вас приветствует программа для рассчёта расстояние между точками." +
               Environment.NewLine + "Для точек с координатами ({0:0.#}; {1:0.#}) и ({2:0.#}; {3:0.#})" +
               Environment.NewLine + "расстояние равняется: ", x1, y1, x2, y2);

            double distance = Distance(x1,y1,x2,y2);

            Console.Write("{0:F2}",distance);

            Console.ReadKey();
        }

    }
}
