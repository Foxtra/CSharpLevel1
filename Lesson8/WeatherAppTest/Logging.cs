using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppTest
{
    /// <summary>Класс логирования действий пользователя</summary>
    class Logging
    {
        /// <summary>Метод записи в файл</summary>
        /// <param name="Msg">Текст сообщения</param>
        internal static void Log(string Msg)
        {
            using (var sw = new System.IO.StreamWriter("data.log",true))
            {
                sw.WriteLine(Msg);
            }
        }
    }
}
