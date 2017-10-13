namespace _12.MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {
                if (IsSymmetric(i) == true && 
                    IsItSumOfDigitsDivisibleBySeven(i) == true && 
                    HaveOneEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static bool IsSymmetric(int inputNumber)
        {
            string str = inputNumber.ToString();
            int length = inputNumber.ToString().Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsItSumOfDigitsDivisibleBySeven(int inputNumber)
        {
            int sum = 0;
            int num = inputNumber;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            bool isTrue = false;
            if (sum % 7 == 0)
            {
                isTrue = true;
            }

            return isTrue;
        }

        public static bool HaveOneEvenDigit(int inputNumber)
        {
            int num = inputNumber;
            bool isTrue = false;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    isTrue = true;
                    break;
                }
                num /= 10;
            }

            return isTrue;
        }
    }
}
