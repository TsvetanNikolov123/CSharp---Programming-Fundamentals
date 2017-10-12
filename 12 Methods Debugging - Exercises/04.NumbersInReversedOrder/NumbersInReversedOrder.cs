namespace _04.NumbersInReversedOrder
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Reversed(input);
        }

        public static void Reversed(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
