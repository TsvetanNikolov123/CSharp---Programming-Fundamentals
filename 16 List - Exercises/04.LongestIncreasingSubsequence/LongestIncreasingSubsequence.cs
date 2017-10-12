namespace _04.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            int[] len = new int[sequence.Length];   // length of the LIS up to respective index
            int[] prev = new int[sequence.Length];  // previous element index in LIS
            int maxLen = 1;
            int lastIndex = 0;
            // calculate the longest increasing sequence (LIS) parameters: 
            // LIS length, last index, prev elements indices
            for (int currentIndex = 0; currentIndex < sequence.Length; currentIndex++)
            {
                len[currentIndex] = 1;
                prev[currentIndex] = -1;
                for (int prevIndex = 0; prevIndex < currentIndex; prevIndex++)
                {
                    if (sequence[prevIndex] < sequence[currentIndex] &&
                        len[prevIndex] >= len[currentIndex])
                    {
                        len[currentIndex]++;
                        prev[currentIndex] = prevIndex;
                    }
                    if (len[currentIndex] > maxLen)
                    {
                        maxLen = len[currentIndex];
                        lastIndex = currentIndex;
                    }
                }
            }
            List<int> longestIncreasingSeq = GetLongestIncreasingSequence(sequence, prev, lastIndex);
            Console.WriteLine(string.Join(" ", longestIncreasingSeq));
        }

        private static List<int> GetLongestIncreasingSequence(int[] sequence, int[] prev, int lastIndex)
        {
            //Console.WriteLine("maxLen: {0}", maxLen);
            //Console.WriteLine("lastIndex: {0}", lastIndex);
            //Console.WriteLine("len: {0}", string.Join(" ", len));
            //Console.WriteLine("prev: {0}", string.Join(" ", prev));
            List<int> longestIncreasingSeq = new List<int>();
            while (lastIndex != -1)
            {
                longestIncreasingSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestIncreasingSeq.Reverse();
            return longestIncreasingSeq;
        }

    }
}
