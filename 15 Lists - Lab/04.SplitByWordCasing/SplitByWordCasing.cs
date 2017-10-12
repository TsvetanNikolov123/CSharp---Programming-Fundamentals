namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> tokens = Console.ReadLine()
                                         .Split(new[] { ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\\", "/", "[", "]", " " }, 
                                          StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string token in tokens)
            {
                if (token.All(char.IsLower))
                {
                    lowerCase.Add(token);
                }
                else if (token.All(char.IsUpper))
                {
                    upperCase.Add(token);
                }
                else
                {
                    mixedCase.Add(token);
                }
            }

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));
        }
    }
}
