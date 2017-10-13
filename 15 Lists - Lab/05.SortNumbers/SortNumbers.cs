namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            List<double> nums = Console.ReadLine()
                                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
