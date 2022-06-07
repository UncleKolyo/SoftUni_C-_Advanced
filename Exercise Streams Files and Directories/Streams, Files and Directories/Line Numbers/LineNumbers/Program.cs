using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {

        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                string line = reader.ReadLine();
                int linecounter = 1;
                int letterCounter = 0;
                int punctCounter = 0;

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char character = line[i];
                        if (Char.IsLetter(character))
                        {
                            letterCounter++;
                        }
                        else if (Char.IsPunctuation(character))
                        {
                            punctCounter++;
                        }
                    }
                    File.AppendAllText(outputFilePath, $"Line {linecounter}: {line} ({letterCounter}) ({punctCounter}) {Environment.NewLine}");
                    //  Console.WriteLine($"Line {linecounter}: {line} ({letterCounter}) ({punctCounter})");
                    letterCounter = 0;
                    punctCounter = 0;
                    linecounter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}