namespace _03.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CameraView
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int skip = elements[0];
            int take = elements[1];
            string pattern = @"(?<=\|<)\w*";
            string input = Console.ReadLine();

            List<string> words = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                var word = m.Value
                    .Skip(skip)
                    .Take(take);
                string result = string.Empty;
                foreach (var w in word)
                {
                    result = result + w;
                }
                words.Add(result);
            }

            Console.WriteLine(string.Join(", ",words));

        }
    }
}
