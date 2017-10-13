namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            bool isFindEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isFindEqualSums = true;
                    break;
                }
            }

            if (!isFindEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
