namespace _10.PairsByDifference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            int[] sequenceOfNumbers = Console.ReadLine()
                                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < sequenceOfNumbers.Length; i++)
            {
                for (int j = i; j < sequenceOfNumbers.Length; j++)
                {
                    int first = Math.Max(sequenceOfNumbers[i], sequenceOfNumbers[j]);
                    int second = Math.Min(sequenceOfNumbers[i], sequenceOfNumbers[j]);
                    if (first - second == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
