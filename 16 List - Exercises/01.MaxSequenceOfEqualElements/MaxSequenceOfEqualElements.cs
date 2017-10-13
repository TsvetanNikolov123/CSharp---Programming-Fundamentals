namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();

            List<int> longestSeq = GetLongestSequence(numbers);
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        private static List<int> GetLongestSequence(List<int> numbers)
        {
            int maxLen = 1;
            int maxIndex = 0;
            int currentLen = 1;
            int currentIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                }
                else
                {
                    currentIndex = i;
                    currentLen = 1;
                }
                if (maxLen < currentLen)
                {
                    maxLen = currentLen;
                    maxIndex = currentIndex;
                }
            }

            List<int> longestSeq = new List<int>();
            for (int i = 0; i < maxLen; i++)
            {
                longestSeq.Add(numbers[maxIndex + i]);
            }

            return longestSeq;
        }
    }
}


