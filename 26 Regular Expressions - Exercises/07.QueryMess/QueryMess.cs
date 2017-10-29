namespace _07.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string firstRegex = @"([^&?]+)=([^&?]+)";
            string secondRegex = @"(%20|\+)+";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;

                MatchCollection matches = Regex.Matches(input, firstRegex);
                Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, secondRegex, word => " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, secondRegex, word => " ").Trim();

                    if (!dic.ContainsKey(field))
                    {
                        dic[field] = new List<string>();
                    }
                    dic[field].Add(value);
                }

                foreach (KeyValuePair<string,List<string>> result in dic)
                {
                    Console.Write("{0}=[{1}]",
                        result.Key,
                        string.Join(", ", result.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
