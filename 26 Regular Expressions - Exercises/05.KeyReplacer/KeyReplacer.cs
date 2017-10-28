/// <summary>
/// 83/100;
/// </summary>
namespace _05.KeyReplacer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyReplacer
    {
        public static void Main()
        {
            string[] keyString = Console.ReadLine()
                .Split(new[] { '<', '|', '\\'});
            string startKey = keyString[0];
            string endString = keyString.Last();
            string textString = Console.ReadLine();

            List<string> result = ExtractFromString(textString, startKey, endString);
            string output = string.Join("", result);
            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }

        private static List<string> ExtractFromString(
    string text, string startString, string endString)
        {
            List<string> matched = new List<string>();
            int indexStart = 0, indexEnd = 0;
            bool exit = false;
            while (!exit)
            {
                indexStart = text.IndexOf(startString);
                indexEnd = text.IndexOf(endString);
                if (indexStart != -1 && indexEnd != -1)
                {
                    matched.Add(text.Substring(indexStart + startString.Length,
                        indexEnd - indexStart - startString.Length));
                    text = text.Substring(indexEnd + endString.Length);
                }
                else
                    exit = true;
            }
            return matched;
        }
    }
}
