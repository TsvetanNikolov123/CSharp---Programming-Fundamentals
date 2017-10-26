namespace _07.MultiplyBigNumber
{
    using System;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());


            int temp = 0;
            string multiplyedNumber = string.Empty;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int first = (int)Char.GetNumericValue(firstNum[i]);
                int sum = first * secondNum + temp;
                int lastDigit = sum % 10;
                multiplyedNumber = lastDigit + multiplyedNumber;
                temp = sum / 10;

                if (i == 0 && temp != 0)
                {
                    multiplyedNumber = temp + multiplyedNumber;
                }
            }
            
            multiplyedNumber = multiplyedNumber.TrimStart('0');
            if (multiplyedNumber.Length < 1)
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine(multiplyedNumber);
            }

        }
    }
}
