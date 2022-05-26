using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();



            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] separators = new string[] { ",", " -> " };
                string[] cmd = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string color = cmd[0]; //Key for bigger dict

                if (!clothes.ContainsKey(color))
                {
                    clothes[color] = new Dictionary<string, int>();      // If there is no such color, we add one
                }
                for (int j = 1; j < cmd.Length; j++) // Here we fill the value dictionary
                {
                    string pieceOfClothing = cmd[j]; //key for smaller dict
                    if (!clothes[color].ContainsKey(pieceOfClothing))
                    {
                        clothes[color].Add(pieceOfClothing, 1);
                    }
                    else
                        clothes[color][pieceOfClothing]++;
                }
            }
            string[] searchCommand = Console.ReadLine().Split(' ').ToArray();
            string searchColor = searchCommand[0];
            string searchPieceOfClothing = searchCommand[1];

            foreach (var colour in clothes)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var pieceOfClothing in colour.Value)
                {
                    if (pieceOfClothing.Key == searchPieceOfClothing && colour.Key == searchColor)
                    {
                        Console.WriteLine($"* {pieceOfClothing.Key} - {pieceOfClothing.Value} (found!)");
                    }
                    else
                    Console.WriteLine($"* {pieceOfClothing.Key} - {pieceOfClothing.Value}");
                }
            }
        }
    }   
}
    