using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ').ToArray();
            HashSet<string> set = new HashSet<string>();


            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }

            }
            
            
        }
    }
}
