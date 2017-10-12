namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        private static int cnt;

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            int sqrtN = (int)Math.Sqrt(n);
            if (n <= 1)
            {
                return false;
            }
            else if (n > 2)
            {
                for (int i = 2; i <= sqrtN; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
