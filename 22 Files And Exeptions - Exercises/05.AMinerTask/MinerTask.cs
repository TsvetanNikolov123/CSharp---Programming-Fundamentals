using System;
using System.Collections.Generic;
using System.IO;

namespace _05.AMinerTask
{
    public class MinerTask
    {
        public static void Main()
        {
            string[] inputLine = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            Dictionary<string, int> resources = new Dictionary<string, int>();
            int count = 0;
            string temp = "";

            foreach (var input in inputLine)
            {

                if (input == "stop")
                {
                    break;
                }
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

            }

            foreach (var resource in resources)
            {
                string result = $"{resource.Key} -> {resource.Value.ToString()}";
                File.AppendAllText("../../Output.txt", result + Environment.NewLine);
            }
        }
    }
}
