namespace _09.IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] letters = Console.ReadLine()
                                    .ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                char current = letters[i];
                int charNumber = current - 97;

                Console.WriteLine("{0} -> {1}", current, charNumber);
            }
        }
    }
}
