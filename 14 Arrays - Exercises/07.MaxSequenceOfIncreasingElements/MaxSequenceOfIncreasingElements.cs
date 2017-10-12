namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] sequance = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;

            for (int i = 1; i < sequance.Length; i++)
            {
                if (sequance[i] > sequance[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write("{0} ", sequance[i]);
            }
        }
    }
}
