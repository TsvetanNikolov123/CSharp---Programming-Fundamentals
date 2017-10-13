namespace _09.MultiplicationTable
{
    using System;

    public class MultiplicationTable
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
