namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int count = 0;
            string temp = factorial.ToString(); 
            while (temp.EndsWith("0"))
            {
                if (temp.EndsWith("0"))
                {
                    count++;
                    temp = temp.Remove(temp.Length - 1);
                }
            }

            Console.WriteLine(count);
        }
    }
}
