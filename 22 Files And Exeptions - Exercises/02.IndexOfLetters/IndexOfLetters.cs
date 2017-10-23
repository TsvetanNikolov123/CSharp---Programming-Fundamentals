namespace _02.IndexOfLetters
{
    using System;
    using System.IO;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            char[] letters = input[0]
                                    .ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                char current = letters[i];
                int charNumber = current - 97;
                string line = $"{current} -> {charNumber}";

                File.AppendAllText("../../Output.txt", line + Environment.NewLine);
            }
        }
    }
}
