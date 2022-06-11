

namespace CopyBinaryFile
{
    using System;
    using System.IO;
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";
            CopyFile(inputFilePath, outputFilePath);
        }
        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using var reader = new FileStream(inputFilePath, FileMode.Open); //Метода за четене

            using var writer = new FileStream(outputFilePath, FileMode.Create); //Метода за писане

            byte[] buffer = new byte[4096]; //Буфера

            var readBytes = reader.Read(buffer, 0, buffer.Length); //Блока който чете


            while (readBytes != 0)  // Докато имаш какво да четеш
            {
                writer.Write(buffer, 0, readBytes);   // Напиши буфера, като почваш от 0 с блока който си прочел
                //ИЛИ
                //writer.Write(buffer); //Това просто работи...
                readBytes = reader.Read(buffer, 0, buffer.Length);  //Прочети новия блок
            }


        }
    }
}
