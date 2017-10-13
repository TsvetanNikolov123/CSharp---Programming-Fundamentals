namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", FindPrimesInRange(startNum, stopNum).ToArray());
            Console.WriteLine(numbers);
        }


        private static List<int> FindPrimesInRange(int start, int stop)
        {
            var result = new List<int>();

            for (int i = start; i <= stop; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    isPrime = false;
                }

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
