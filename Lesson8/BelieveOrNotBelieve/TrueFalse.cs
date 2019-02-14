using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    /// <summary>Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML</summary>
    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>Конструктор записывает путь к файлу и инициализирует пустой список вопросов</summary>
        /// <param name="fileName">Имя и путь к файлу</param>
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        /// <summary>Метод добавления вопроса</summary>
        /// <param name="text">Текст вопроса</param>
        /// <param name="trueFalse">Ответ на вопрос</param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>Метод удаления вопроса</summary>
        /// <param name="index">Индекс вопроса в списке</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>Индексатор - свойство для доступа к закрытому объекту</summary>
        /// <param name="index">Индекс вопроса</param>
        /// <returns></returns>
        public Question this[int index]
        {
            get { return list[index]; }
        }

        /// <summary>Метод сериализации списка вопросов</summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>Метод десериализации списка вопросов</summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        /// <summary>Свойство возвращает размер списка вопросов</summary>
        public int Count
        {
            get { return list.Count; }
        }
    }

}
