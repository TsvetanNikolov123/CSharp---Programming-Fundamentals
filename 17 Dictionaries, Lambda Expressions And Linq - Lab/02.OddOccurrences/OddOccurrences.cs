namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                                        .ToLower()
                                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                counts[word]++;
            }

            List<string> results = new List<string>();
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    results.Add(count.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
