﻿namespace _15.FastPrimeChecker
{
    using System;

    public class FastPrimeChecker
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
