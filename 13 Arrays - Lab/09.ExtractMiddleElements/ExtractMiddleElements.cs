namespace _09.ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();

            if (nums.Length == 1)
            {
                int num = nums[0];
                Console.WriteLine("{{ {0} }}", num);
            }
            else if (nums.Length % 2 == 0)
            {
                int first = nums[nums.Length / 2 - 1];
                int second = nums[nums.Length / 2];
                Console.WriteLine("{{ {0}, {1} }}", first, second);
            }
            else
            {
                int first = nums[nums.Length / 2 - 1];
                int second = nums[nums.Length / 2];
                int third = nums[nums.Length / 2 + 1];
                Console.WriteLine("{{ {0}, {1}, {2} }}", first, second, third);
            }
        }
    }
}
