namespace _06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string reversed = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += "" + input[i];
            }

            List<int> nums = reversed
                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Reverse()
                                .Select(int.Parse)
                                .ToList();
            int sum = nums.Sum();
            Console.WriteLine(sum);
        }
    }
}
