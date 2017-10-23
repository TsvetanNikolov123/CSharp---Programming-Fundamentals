namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt")
                                    .ToLower()
                                    .Split();

            string[] text = File.ReadAllText("text.txt")
                                    .ToLower()
                                    .Split(new[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            File.Delete("Output.txt");

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            foreach (KeyValuePair<string, int> word in wordCount.OrderByDescending(w => w.Value))
            {
                string currentWord = word.Key;
                int currentCount = word.Value;
                string result = $"{currentWord} - {currentCount}";
                File.AppendAllText("Output.txt", result + Environment.NewLine);
            }
        }
    }
}
