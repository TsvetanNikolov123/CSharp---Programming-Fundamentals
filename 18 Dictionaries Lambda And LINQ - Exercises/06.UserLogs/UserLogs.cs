namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> dic = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] tokens = input
                                    .Split(' ')
                                    .ToArray();
                string[] tempIp = tokens[0]
                                   .Split('=')
                                   .Skip(1)
                                   .ToArray();
                string[] tempName = tokens[2]
                                   .Split('=')
                                   .Skip(1)
                                   .ToArray();
                string ip = tempIp[0];
                string name = tempName[0];

                if (!dic.ContainsKey(name))
                {
                    dic[name] = new Dictionary<string, int>();
                }

                if (!dic[name].ContainsKey(ip))
                {
                    dic[name].Add(ip, 0);
                }
                dic[name][ip]++;

                input = Console.ReadLine();
            }

            foreach (var name in dic)
            {
                string userName = name.Key;
                Dictionary<string, int> ipAddressAndCount = name.Value;
                Console.WriteLine("{0}: ", userName);
                int counter = 1;

                foreach (var item in ipAddressAndCount)
                {
                    string ip = item.Key;
                    int messageCount = item.Value;

                    if (name.Value.Count == counter)
                    {
                        Console.WriteLine("{0} => {1}.", ip, messageCount);
                        break;
                    }
                    Console.Write("{0} => {1}, ", ip, messageCount);
                    counter++;
                }
            }
        }
    }
}
