namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                string output = "";
                int counter = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        return output;
                    }
                    string[] reversing = line.Split(' ').ToArray();
                    Array.Reverse(reversing);
                    line = string.Join(" ", reversing);
                    line = line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');
                    if (counter % 2 == 0)
                    {
                        counter++;
                        continue;
                    }
                    else
                    {
                        output += line + Environment.NewLine;
                        counter++;
                    }



                }

            }

        }
    }
}
