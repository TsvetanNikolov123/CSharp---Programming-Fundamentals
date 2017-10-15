namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, string> resources = new Dictionary<string, string>();
            int count = 0;
            string temp = "";

            while (input != "stop")
            {
                count++;
                if (count % 2 != 0)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = "";
                    }
                    temp = input;
                }
                else
                {
                    resources[temp] += input;
                }
                input = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                if (!(resource.Value.EndsWith("us") || resource.Key.EndsWith("uk")))
                {
                    Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
                }
            }
        }
    }
}
