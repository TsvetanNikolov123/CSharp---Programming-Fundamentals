namespace _01.MostFrequentNumber
{
    using System;
    using System.IO;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            int[] nums = input[0]
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] counts = new int[65535];
            int maxCount = 0;
            int frequentNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                counts[nums[i]]++;
                if (counts[nums[i]] > maxCount)
                {
                    maxCount = counts[nums[i]];
                    frequentNumber = nums[i];
                }
            }

            File.AppendAllText("../../Output.txt", frequentNumber.ToString());
        }
    }
}
