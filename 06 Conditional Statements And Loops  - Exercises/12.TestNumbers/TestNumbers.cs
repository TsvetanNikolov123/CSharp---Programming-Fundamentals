namespace _12.TestNumbers
{
    using System;

    public class TestNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += 3 * (i * j);
                    counter++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
                        return;
                    }

                }
            }

            if (sum <= maxSum)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
