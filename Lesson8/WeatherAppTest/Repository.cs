using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherAppTest
{
    /// <summary>Класс для хранения набора данных о городах</summary>
    class Repository
    {
        List<City> db = new List<City>();

        public List<City> Citys { get { return this.db; } }

        Random random = new Random();

        /// <summary>Конструктор добавляет несколько городов</summary>
        public Repository()
        {
            db.Add(GetWeather("Saint Petersburg", "69.xml"));
            db.Add(GetWeather("Adler", "2879.xml"));
            db.Add(GetWeather("Borovichi", "2799.xml"));
            db.Add(GetWeather("Ufa", "140.xml"));
            db.Add(GetWeather("Penza", "169.xml"));
            db.Add(GetWeather("Kazan", "486.xml"));

        }

        /// <summary>Метод вывода всех городов в консоль</summary>
        public void PrintData()
        {
            foreach (var item in db)
            {
                Debug.WriteLine(item.Print());
            }
        }

        /// <summary>Метод получения данных о погоде конкретного города</summary>
        /// <param name="city">Название города</param>
        /// <param name="code">Код файла на веб-сервисе meteoservice.ru</param>
        /// <returns></returns>
        private static City GetWeather(string city, string code)
        {
            string url = "https://xml.meteoservice.ru/export/gismeteo/point/"+code;
            WebClient webClient = new WebClient();
            string data = webClient.DownloadString(url);

            City currentCity = new City();

            var weatherCollection = XDocument.Parse(data)
                .Descendants("MMWEATHER")
                .Descendants("REPORT")
                .Descendants("TOWN")
                .Descendants("FORECAST").ToArray();


            currentCity.CityName = city;
            currentCity.PressureMax = int.Parse(weatherCollection[0].Element("PRESSURE").Attribute("max").Value);
            currentCity.PressureMin = int.Parse(weatherCollection[0].Element("PRESSURE").Attribute("min").Value);
            currentCity.TemperatureMax = int.Parse(weatherCollection[0].Element("TEMPERATURE").Attribute("max").Value);
            currentCity.TemperatureMin = int.Parse(weatherCollection[0].Element("TEMPERATURE").Attribute("min").Value);


            return currentCity;
        }

    }
}
