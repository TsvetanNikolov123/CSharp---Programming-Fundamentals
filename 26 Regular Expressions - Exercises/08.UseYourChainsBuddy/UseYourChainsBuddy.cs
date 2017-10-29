namespace _08.UseYourChainsBuddy
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            Regex paragrafRegex = new Regex(@"<p>(?<message>.+?)<\/p>");
            string text = Console.ReadLine();

            string[] paragraphs = paragrafRegex.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13String(paragraphs[i]);
            }

            StringBuilder result = new StringBuilder();
            foreach (string paragraph in paragraphs)
            {
                result.Append(paragraph);
            }

            Console.WriteLine(result.ToString());
        }

        private static string Rot13String(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char letter in input)
            {
                result.Append(Rot13(letter));
            }
            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }

            char offset = char.IsUpper(letter) ? 'A' : 'a';
            char rotatedLetter =(char) ((letter - offset + 13) % 26 + offset);

            return rotatedLetter;
        }
    }
}
