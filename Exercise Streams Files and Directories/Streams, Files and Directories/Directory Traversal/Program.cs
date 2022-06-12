namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            //C:\Users\Admin\Desktop\Gunsmith-The Game
            string path = @"C:\Users\Admin\Desktop\Gunsmith-The Game";
           // string path = Console.ReadLine();
            string reportFileName = @"C:\Users\Admin\Desktop\Gunsmith-The Game\Нова папка";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] filePaths = Directory.GetFiles(inputFolderPath);

            SortedDictionary<string, SortedDictionary<decimal , string>> files = new SortedDictionary<string, SortedDictionary<decimal, string>>();



            foreach (var file in filePaths)
            {
                var fileInfo = new FileInfo(file);

                string currKey = fileInfo.Extension; // Key for big Dict
                string currValue = fileInfo.Name;    // Value for inner dict
                decimal size = (decimal)(fileInfo.Length / 1000.0); // Key for inner Dict
    

                if (!files.ContainsKey(currKey))
                {
                    files[currKey] = new SortedDictionary<decimal, string>(); // If there is no such key, we add one
                    files[currKey].Add(size, currValue);
                }
                else
                    files[currKey][size] = currValue;


            }

            string output = string.Empty;

            foreach (var item in files)
            {
                output += item.Key + '\n';//string.Join('\n',item.Key);
                foreach (var thing in item.Value)
                {
                    //--controller.js - 1635.143kb
                    output += $"--{thing.Value} - {thing.Key}kb" + '\n';
                }
            }
            return output;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(textContent);

            using var writer = new FileStream(reportFileName, FileMode.OpenOrCreate);

            writer.Write(bytes, 0, bytes.Length);
        }
    }
}
