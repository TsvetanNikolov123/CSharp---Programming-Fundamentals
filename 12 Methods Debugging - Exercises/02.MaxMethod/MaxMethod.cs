namespace _02.MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestNumber = GetMax(firstNumber, GetMax(secondNumber, thirdNumber));
            Console.WriteLine(biggestNumber);
        }

        public static int GetMax(int a, int b)
        {
            int biggest = Math.Max(a, b);
            return biggest;
        }
    }
}
