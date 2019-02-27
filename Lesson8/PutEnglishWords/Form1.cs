/*
 * *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных 
 * (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
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

namespace PutEnglishWords
{
    public partial class Form1 : Form
    {
        CheckWord database;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Обработчик нажатия кнопки Добавить слово</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add(tboxEngText.Text, tboxRuText.Text);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        /// <summary>Обработчик нажатия кнопки Удалить слово</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database.Count == 1 || database == null) return;
            database.Remove(new Dictionary(tboxEngText.Text, tboxRuText.Text));
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        /// <summary>Обработчик нажатия кнопки Сохранить слово</summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        /// <summary>Обработчик нажатия кнопки "Новый" файл в меню</summary>
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new CheckWord(sfd.FileName);
                database.Add("test", "тест");
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        /// <summary>Обработчик нажатия кнопки "Открыть" файл в меню</summary>
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new CheckWord(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        /// <summary>Обработчик нажатия кнопки "Сохранить" файл в меню</summary>
        private void miSave_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].EnglishText = tboxEngText.Text;
                database[(int)nudNumber.Value - 1].RussianText = tboxRuText.Text;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Откройте или создайте файл со словами ");
            }
        }

        /// <summary>Обработчик нажатия кнопки "Выйти" в меню</summary>
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Обработчик выбора из уже имеющихся слов</summary>
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxEngText.Text = database[(int)nudNumber.Value - 1].EnglishText;
                tboxRuText.Text = database[(int)nudNumber.Value - 1].RussianText;
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Данное слово отсутствует");
            }
        }
    }
}
