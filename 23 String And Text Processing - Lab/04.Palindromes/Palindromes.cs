namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine()
                                        .Split(new char[] { ',', ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> sortedPalindroms = new SortedSet<string>();

            foreach (string token in tokens)
            {
                string reversed = new string(token.Reverse().ToArray());
                if (reversed == token)
                {
                    sortedPalindroms.Add(reversed);
                }
            }
            Console.WriteLine(string.Join(", ", sortedPalindroms));
        }
    }
}
