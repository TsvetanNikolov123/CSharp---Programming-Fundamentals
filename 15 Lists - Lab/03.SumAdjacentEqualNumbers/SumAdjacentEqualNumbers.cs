namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> nums = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(double.Parse)
                                    .ToList();

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    double sum = nums[i - 1] + nums[i];
                    nums[i - 1] = sum;
                    nums.RemoveAt(i);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
