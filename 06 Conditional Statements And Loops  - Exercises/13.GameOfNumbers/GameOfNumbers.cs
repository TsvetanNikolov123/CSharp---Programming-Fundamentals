namespace _13.GameOfNumbers
{
    using System;

    public class GameOfNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            int a = 0;
            int b = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magic)
                    {
                        sum = i + j;
                        a = i;
                        b = j;
                    }
                }
            }
            if (sum == magic)
            {
                Console.WriteLine($"Number found! {a} + {b} = {sum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
