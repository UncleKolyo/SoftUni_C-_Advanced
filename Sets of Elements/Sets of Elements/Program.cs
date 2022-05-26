using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> numbers1 = new HashSet<int>();
            HashSet<int> numbers2 = new HashSet<int>();



            for (int i = 0; i < n; i++)
            {
                numbers1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                numbers2.Add(int.Parse(Console.ReadLine()));
            }

            numbers1.IntersectWith(numbers2);

            Console.WriteLine(String.Join(" ", numbers1));
        }
    }
}