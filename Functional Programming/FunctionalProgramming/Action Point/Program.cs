using System;
using System.Linq;

namespace Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Action<string> print = message => Console.WriteLine(input[i]);
                print(input[i]);
            }
        }
    }
}
