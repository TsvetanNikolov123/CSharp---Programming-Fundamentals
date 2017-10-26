namespace _06.SumBigNumbers
{
    using System;
    using System.Collections.Generic;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);
            int difference = maxLen - minLen;

            if (str1.Length > str2.Length)
            {
                str2 = str2.PadLeft(str2.Length + difference, '0');
            }
            else
            {
                str1 = str1.PadLeft(str1.Length + difference, '0');
            }

            int temp = 0;
            string sumOfNumbers = string.Empty;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                int first = (int)Char.GetNumericValue(str1[i]);
                int second = (int)Char.GetNumericValue(str2[i]);
                int sum = first + second + temp;

                if (sum > 9)
                {
                    int tempNum = sum % 10;
                    temp = 1;
                    sumOfNumbers = tempNum.ToString() + sumOfNumbers;
                }
                else
                {
                    temp = 0;
                    sumOfNumbers = sum.ToString() + sumOfNumbers;
                }

                if (i == 0 && temp == 1)
                {
                    sumOfNumbers = temp + sumOfNumbers;
                }
            }
            sumOfNumbers = sumOfNumbers.TrimStart('0');
            Console.WriteLine(sumOfNumbers);
        }
    }
}
