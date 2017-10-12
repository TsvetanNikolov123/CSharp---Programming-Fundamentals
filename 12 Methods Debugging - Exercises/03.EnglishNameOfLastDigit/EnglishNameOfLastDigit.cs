namespace _03.EnglishNameOfLastDigit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            long lastDigit= GetLastDigit(input);
            string lastDigitWithWord = LastDigitName(lastDigit);
            Console.WriteLine(lastDigitWithWord);
        }

        public static long GetLastDigit(long input)
        {
            long lastDigit = input % 10;
            return Math.Abs(lastDigit);
        }

        public static string LastDigitName(long lastDigit)
        {
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "";
                    break; 
            }
        }
    }
}
