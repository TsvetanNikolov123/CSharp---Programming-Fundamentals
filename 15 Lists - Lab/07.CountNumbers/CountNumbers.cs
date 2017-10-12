namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();

            foreach (var num in nums.Distinct().OrderBy(x => x))
                Console.WriteLine(string.Join(" -> ",
                    num,
                    nums.Count(x => x == num)));
        }
    }
}

