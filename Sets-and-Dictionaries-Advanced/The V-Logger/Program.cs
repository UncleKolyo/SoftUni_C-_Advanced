using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, List<string>> socialMedia = new Dictionary<string, List<string>>();

            while (command[0] != "Statistics")
            {


                if (command[1] == "joined")
                {
                    string vlogger = command[0];
                    if (socialMedia.ContainsKey(vlogger))
                    {
                        continue;
                    }
                    socialMedia.Add(vlogger, null);
                }
                else if (command[1] == "followed")
                {

                    string follower = command[0];
                    string vlogger = command[2];
                    if (follower == vlogger)
                    {
                        continue;
                    }
                   //  if (!socialMedia[vlogger].Contains(follower))
                   // {
                        socialMedia[vlogger].Add(follower);
                   // }
                   // else
                   //     continue;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
