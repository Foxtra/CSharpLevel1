/*
Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 Ткачёв Сергей
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;

            b = a + b; //3 + 6 = 9
            a = b - a; //9 - 3 = 6
            b = b - a; //9 - 6 = 3

            Console.ReadKey();

        }
    }
}
