namespace _05.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibobacci(number));
        }

        public static int Fibobacci(int num)
        {
            int first = 1;
            int second = 1;
            for (int i = 0; i < num - 1; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            
            return second;
        }
    }
}

