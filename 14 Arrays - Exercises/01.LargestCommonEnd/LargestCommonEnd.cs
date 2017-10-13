namespace _01.LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine()
                                     .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);                    // first way to reverse array
            secondArr = secondArr.Reverse().ToArray();  // second way to reverse array
            int rightCount = FindMaxCommonItems(firstArr, secondArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        private static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
