namespace _01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern = @"(?<=^|\s)\b[A-Za-z0-9]+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0}", m.Value);
            }
        }
    }
}
