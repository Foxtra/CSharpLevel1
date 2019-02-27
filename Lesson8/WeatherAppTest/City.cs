using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppTest
{
    /// <summary>Класс для описания города</summary>
    class City
    {
        public string CityName{ get; set; }
        public int TemperatureMin { get; set; }
        public int TemperatureMax { get; set; }
        public int  PressureMin { get; set; }
        public int PressureMax { get; set; }

        /// <summary>Метод возвращает название города</summary>
        /// <returns></returns>
        public override string ToString()
        {
             return $"{this.CityName}";
        }

        /// <summary>Метод возвращает всю информацию о городе</summary>
        /// <returns></returns>
        internal string Print()
        {
            return $"{this.CityName,10} {TemperatureMin,3} - {TemperatureMax} °c  {PressureMin} - {PressureMax} мм.рт.ст.";
        }
    }
}
