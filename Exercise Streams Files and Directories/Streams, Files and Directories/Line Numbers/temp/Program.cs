using System;

namespace temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine($"a{i} = {a}");
                a = a + 4;
            }
        }
    }
}
