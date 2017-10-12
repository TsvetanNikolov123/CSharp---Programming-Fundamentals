namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            List<double> nums = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(double.Parse)
                                    .ToList();
            List<double> squareNums = new List<double>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)(Math.Sqrt(nums[i])))
                {
                    squareNums.Add(nums[i]);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
