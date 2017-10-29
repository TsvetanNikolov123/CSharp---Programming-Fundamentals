namespace _06.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(^([a-zA-Z])([a-zA-Z_0-9]){2,24})$";
            Regex regex = new Regex(pattern);

            List<string> matches = new List<string>();
            foreach (var element in input)
            {
                if (regex.IsMatch(element))
                {
                    matches.Add(element);
                }
            }

            int maxLength = 0;
            string firstConsecutive = string.Empty;
            string secondConsecutive = string.Empty;
            for (int i = 1; i < matches.Count; i++)
            {
                if (matches[i - 1].Length + matches[i].Length > maxLength)
                {
                    maxLength = matches[i - 1].Length + matches[i].Length;
                    firstConsecutive = matches[i - 1];
                    secondConsecutive = matches[i];
                }
            }

            Console.WriteLine(firstConsecutive);
            Console.WriteLine(secondConsecutive);
        }
    }
}
