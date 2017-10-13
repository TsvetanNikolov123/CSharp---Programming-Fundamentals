namespace _12.NumberChecker
{
    using System;

    public class NumberChecker
    {
        public static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
