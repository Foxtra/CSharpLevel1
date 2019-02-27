/*
 * Используя заготовку с вебинара, реализовать парсинг xml-файла данных о погоде
 * с веб-сервиса meteoservice.ru 
 * 
 * Сергей Ткачёв
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppTest
{

    delegate void GetData(string Msg);
    public partial class Form1 : Form
    {
        Repository data;
        GetData getDataEvent;
        public Form1()
        {
            InitializeComponent();

            data = new Repository();
            getDataEvent = Logging.Log;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in data.Citys)
            {
                lbCitys.Items.Add(item);
            }
        }

        private void lbCitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCitys.SelectedIndex == -1) return;

            City selectedCity = (City)lbCitys.SelectedItem;

            getDataEvent($"Выбран {selectedCity.CityName} в {DateTime.Now}. Данные: {selectedCity.Print()}");

            lblPressureValueMin.Text = $"{selectedCity.PressureMin} мм.рт.ст";
            lblPressureValueMax.Text = $"{selectedCity.PressureMax} мм.рт.ст";
            lblTemperatureValueMin.Text = $"{selectedCity.TemperatureMin} °с";
            lblTemperatureValueMax.Text = $"{selectedCity.TemperatureMax} °с";

        }

        private void lblPressureMin_MouseDown(object sender, MouseEventArgs e)
        {
            if(sender.GetType()==typeof(Label))
            { 
            getDataEvent($"Нажат компонент {((Label)(sender)).Name} в {DateTime.Now} координаты мишы: {e.Location.ToString()}");
            }
            else if (sender.GetType() == typeof(ListBox))

            {
                getDataEvent($"Нажат компонент {((ListBox)(sender)).Name} в {DateTime.Now} координаты мишы: {e.Location.ToString()}");

            }
        }
    }
}
