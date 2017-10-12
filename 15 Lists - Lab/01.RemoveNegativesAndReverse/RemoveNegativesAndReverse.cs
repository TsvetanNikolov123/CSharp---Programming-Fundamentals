namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            List<int> result = new List<int>();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] > 0)
                {
                    result.Add(nums[i]);
                }
            }

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
