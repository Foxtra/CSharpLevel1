/*
 * **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 * 
 * Сергей Ткачёв
 */

using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace ConvertCSVtoXML
{
    class Program
    {
        /// <summary>Мэджик код</summary>
        /// <param name="fileNameOpen">Имя csv файла</param>
        /// <param name="fileNameSave">Имя xml файла</param>
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа-преобразователь из CSV в XML-файл с информацией о студентах");

            Converter("..\\..\\students_6.csv", "..\\..\\students_8.xml");

            Console.WriteLine("Работа программы завершена!");
            Console.ReadLine();
        }
    }
}
