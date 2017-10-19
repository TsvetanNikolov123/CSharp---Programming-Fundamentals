namespace _02.RandomizeWords
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                int index = rnd.Next(0, words.Length);
                string rem = words[index];
                int newIndex = rnd.Next(0, words.Length);
                words[index] = words[newIndex];
                words[newIndex] = rem;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
