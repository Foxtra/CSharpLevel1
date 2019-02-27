using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutEnglishWords
{
    /// <summary>Класс для слова с переводом</summary>
    [Serializable]
    public class Dictionary : IEquatable<Dictionary>
    {
        string englishText;       
        string russianText;       

        public string EnglishText { get { return englishText; } set { if (value.GetType() == typeof(string)) englishText = value; } }
        public string RussianText { get { return russianText; } set { if (value.GetType() == typeof(string)) russianText = value; } }

        /// <summary>Метод сравнения слова с другим</summary>
        /// <param name="another">Слово типа Dictionary для сравнения</param>
        /// <returns></returns>
        public bool Equals(Dictionary another)
        {
            if (this.englishText == another.englishText && this.russianText == another.russianText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Для сериализации приводится пустой конструктор</summary>
        public Dictionary()
        {
        }

        /// <summary>Метод записи слова</summary>
        /// <param name="engtext">Текст слова на англ</param>
        /// <param name="rutext">Текст слова на рус</param>
        public Dictionary(string engtext, string rutext)
        {
            this.englishText = engtext;
            this.russianText = rutext;
        }
    }
}
