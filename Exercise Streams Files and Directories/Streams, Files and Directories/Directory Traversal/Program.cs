namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;


    public class DirectoryTraversal
    {
        static void Main()
        {
            //C:\Users\Admin\Desktop\Gunsmith-The Game

            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] filePaths = Directory.GetFiles(inputFolderPath);

            Dictionary<string, List<string>> files = new Dictionary<string, List<string>>();



            foreach (var file in filePaths)
            {
                var fileInfo = new FileInfo(file);

                string currKey = fileInfo.Extension;
                string currValue = fileInfo.Name;

                Console.WriteLine(currValue);

                if (!files.ContainsKey(currKey))
                {
                    files.Add(currKey, new List<string>());
                    files[currKey].Add(currValue);
                }
                else
                    files[currKey].Add(currValue);

            }

            foreach (var key in files)
            {
                Console.WriteLine(key);
                Console.WriteLine(string.Join('\n', key.Value));
            }
            return inputFolderPath;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {

        }
    }
}
