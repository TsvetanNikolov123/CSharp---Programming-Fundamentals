namespace _06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FixEmails
    {
        public static void Main()
        {
            string[] inputLine = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            Dictionary<string, string> resources = new Dictionary<string, string>();
            int count = 0;
            string temp = "";

            foreach(var input in inputLine)
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
                        resources[input] = "";
                    }
                    temp = input;
                }
                else
                {
                    resources[temp] += input;
                }
            }

            foreach (var resource in resources)
            {
                if (!(resource.Value.EndsWith("us") || resource.Key.EndsWith("uk")))
                {
                    string result = $"{resource.Key} -> {resource.Value}";
                    File.AppendAllText("../../Output.txt", result + Environment.NewLine);
                }
            }
        }
    }
}
