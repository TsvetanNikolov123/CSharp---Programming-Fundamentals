namespace _08.SumOfOddNumbers
{
    using System;

    public class SumOfOddNumbers
    {
        public static void Main()
        {
            int oddNums = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= oddNums; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
