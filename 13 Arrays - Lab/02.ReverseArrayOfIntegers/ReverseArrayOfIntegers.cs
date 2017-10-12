namespace _02.ReverseArrayOfIntegers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
