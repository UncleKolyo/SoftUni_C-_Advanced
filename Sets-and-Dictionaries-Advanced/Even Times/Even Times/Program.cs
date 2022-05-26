using System;
using System.Collections.Generic;

namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int magicNum = 0;
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNum))
                {
                    numbers.Add(currentNum, 1);
                }
                else
                    numbers[currentNum]++;
            }
            foreach (var KVP in numbers)
            {
                if (KVP.Value % 2 == 0)
                {
                    Console.WriteLine(KVP.Key);
                }
            }
        }
    }
}
