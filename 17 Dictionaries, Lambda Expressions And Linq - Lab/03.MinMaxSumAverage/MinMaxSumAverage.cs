namespace _03.MinMaxSumAverage
{
    using System;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                nums[i] = input;
            }

            int numsSum = nums.Sum();
            int numsMin = nums.Min();
            int numsMax = nums.Max();
            double numsAverage = nums.Average();

            Console.WriteLine("Sum = {0}", numsSum);
            Console.WriteLine("Min = {0}", numsMin);
            Console.WriteLine("Max = {0}", numsMax);
            Console.WriteLine("Average = {0}", numsAverage);
        }
    }
}
