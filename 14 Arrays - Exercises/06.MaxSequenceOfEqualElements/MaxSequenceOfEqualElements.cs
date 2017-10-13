namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            int temp = nums[0];
            int count = 1;
            int bestNum = 0;
            int bestCount = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == temp)
                {
                    count++;
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestNum = temp;
                        bestCount = count;
                    }
                    temp = nums[i];
                    count = 1;
                }
            }

            if (count > bestCount)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0} ", temp);
                }
            }
            else
            {
                for (int i = 0; i < bestCount; i++)
                {
                    Console.Write("{0} ", bestNum);
                }
            }
        }
    }
}

