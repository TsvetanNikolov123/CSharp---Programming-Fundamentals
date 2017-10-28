/// <summary>
/// 80/100
/// </summary>


namespace _02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string matchWord = Console.ReadLine();
            string pattern = @"[^.?!]*(?<=[.?\s!])" + matchWord + @"(?=[\s.?!])[^.?!]*[.?!]";

            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0}", m.Value.Trim(' ', '.', '!', '?'));
            }
        }
    }
}
