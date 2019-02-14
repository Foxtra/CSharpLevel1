/*
 * С помощью рефлексии выведите все свойства структуры DateTime.
 * 
 * Сергей Ткачёв
 */

using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа вывода на экран всех свойств структуры DateTime при помощи рефлексии.\n");

            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            Console.WriteLine($"CanRead: {GetPropertyInfo(dateTime, "DayOfWeek").CanRead}");
            Console.WriteLine($"CanWrite: {GetPropertyInfo(dateTime, "DayOfWeek").CanWrite}");
            Console.WriteLine($"Attributes: {GetPropertyInfo(dateTime, "DayOfWeek").Attributes}");
            Console.WriteLine($"CustomAttributes: {GetPropertyInfo(dateTime, "DayOfWeek").CustomAttributes}");
            Console.WriteLine($"DeclaringType: {GetPropertyInfo(dateTime, "DayOfWeek").DeclaringType}");
            Console.WriteLine($"GetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").GetMethod}");
            Console.WriteLine($"IsSpecialName: {GetPropertyInfo(dateTime, "DayOfWeek").IsSpecialName}");
            Console.WriteLine($"MemberType: {GetPropertyInfo(dateTime, "DayOfWeek").MemberType}");
            Console.WriteLine($"MetadataToken: {GetPropertyInfo(dateTime, "DayOfWeek").MetadataToken}");
            Console.WriteLine($"Module: {GetPropertyInfo(dateTime, "DayOfWeek").Module}");
            Console.WriteLine($"Name: {GetPropertyInfo(dateTime, "DayOfWeek").Name}");
            Console.WriteLine($"PropertyType: {GetPropertyInfo(dateTime, "DayOfWeek").PropertyType}");
            Console.WriteLine($"ReflectedType: {GetPropertyInfo(dateTime, "DayOfWeek").ReflectedType}");
            Console.WriteLine($"SetMethod: {GetPropertyInfo(dateTime, "DayOfWeek").SetMethod}");

            Console.WriteLine($"GetValue: {GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null)}");

            Console.ReadKey();
        }
    }

}
