/*
 *  Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
 *  На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 *  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 *  программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 *  
 *  Ткачёв Сергей
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class Program
    {

        static string enterPass()
        {
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace и Enter не учитываются
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            return pass;
        }

        static string RightTryWord(int x)
        {
            string s = "";
            // Попытка, когда заканчивается на один, кроме 11.
            if (x % 10 == 1 && x != 11) s += " попытка";
            else
                // Попытки
                if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " попытки";
            else
                    // Попыток
                    if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
            return s;
        }

        static bool CheckLogAndPass(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки логина и пароля.");
            int AmountOfTries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = enterPass();

                if (CheckLogAndPass(login, password))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина или пароля." + 
                        Environment.NewLine + "У Вас осталось " + AmountOfTries + RightTryWord(AmountOfTries));
                }

            } while (AmountOfTries > 0);

            Console.WriteLine("Авторизация успешна!");

            Console.ReadKey();
        }
    }
}
