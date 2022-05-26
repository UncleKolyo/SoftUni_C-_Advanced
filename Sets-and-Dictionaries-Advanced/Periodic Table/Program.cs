using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.CompareTo(y);
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                foreach (var chem in input)
                {
                    set.Add(chem);
                }
            }
            SortedSet<string> sortedSet = new SortedSet<string>(new StringComparer());
            foreach (var chem in set)
            {
                sortedSet.Add(chem);
            }

            Console.WriteLine(String.Join(' ', sortedSet));

        }
    }
}