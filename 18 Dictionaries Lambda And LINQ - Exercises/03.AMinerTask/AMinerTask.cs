namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            int count = 0;
            string temp = "";

            while (input != "stop")
            {
                count++;
                if (count % 2 != 0)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = 0;
                    }
                    temp = input;
                }
                else
                {
                    resources[temp] += int.Parse(input);
                }
                input = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}
