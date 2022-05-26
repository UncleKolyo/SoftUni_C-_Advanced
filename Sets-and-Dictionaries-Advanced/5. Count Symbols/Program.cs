using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] sortedInput = input.OrderBy(x => x).ToArray();

            input = new string(sortedInput);

            SortedDictionary<char, int> keyValuePairs = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!keyValuePairs.ContainsKey(currentChar))
                {
                    keyValuePairs.Add(currentChar, 1);
                }
                else
                    keyValuePairs[currentChar]++;
            }
            foreach (var KVP in keyValuePairs)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value} time/s");
            }
        }
    }
}
