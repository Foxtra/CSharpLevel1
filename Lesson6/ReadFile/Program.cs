/*
 * **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
 * Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
 * 
 * Сергей Ткачёв
 */

using System;
using System.Diagnostics;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream
            Console.WriteLine("Запишем файлы при помощи разных потоков:");
            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSampleWrite("D:\\temp\\bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSampleWrite("D:\\temp\\bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSampleWrite("D:\\temp\\bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSampleWrite("D:\\temp\\bigdata3.bin", size));

            Console.WriteLine("Прочтём файлы при помощи разных потоков:");
            byte[] bytesFromFileStream = FileStreamSampleRead("D:\\temp\\bigdata0.bin");
            int[] integersFromBinatyStream = BinaryStreamSampleRead("D:\\temp\\bigdata1.bin");
            string stringFromSreamReader = StreamReaderSample("D:\\temp\\bigdata2.bin");
            byte[] bytesFromBufferedStream = BufferedStreamSampleRead("D:\\temp\\bigdata3.bin");

            Console.ReadKey();
        }

        /// <summary>Метод записи в файл при помощи FileStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long FileStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод чтения из файла при помощи FileStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <returns></returns>
        static byte[] FileStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] byteArray = new byte[fs.Length];
            for(int i = 0; i < fs.Length; i++)
                byteArray[i] = (byte)fs.ReadByte();
            fs.Close();
            return byteArray;
        }

        /// <summary>Метод записи в файл при помощи BinaryStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long BinaryStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод чтения из файла при помощи BinaryStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <returns></returns>
        static int[] BinaryStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int[] intArr = new int[fs.Length / 4];
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length / 4; i++)
                intArr[i] = br.ReadInt32();
            fs.Close();
            return intArr;
        }

        /// <summary>Метод записи в файл при помощи StreamReader</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long StreamWriterSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод чтения из файла при помощи StreamReader</summary>
        /// <param name="filename">Имя файла</param>
        /// <returns></returns>
        static string StreamReaderSample(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            fs.Close();
            return result;
        }

        /// <summary>Метод записи в файл при помощи BufferedStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long BufferedStreamSampleWrite(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод чтения из файла при помощи BufferedStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <returns></returns>
        static byte[] BufferedStreamSampleRead(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            return buffer;
        }
    }

}
