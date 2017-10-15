namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                                            .Split(' ')
                                            .ToArray();
                string user = tokens[1];
                string ip = tokens[0];
                int duration = int.Parse(tokens[2]);

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new SortedDictionary<string, int>();
                }

                if (!logs[user].ContainsKey(ip))
                {
                    logs[user][ip] = 0;
                }
                logs[user][ip] += duration;
            }
            foreach (var name in logs)
            {
                string names = name.Key;
                int totalDuration = name.Value.Values.Sum();
                List<string> ipList = name.Value.Keys.ToList();

                Console.WriteLine("{0}: {1} [{2}]", names, totalDuration, string.Join(", ", ipList));
            }
        }
    }
}

