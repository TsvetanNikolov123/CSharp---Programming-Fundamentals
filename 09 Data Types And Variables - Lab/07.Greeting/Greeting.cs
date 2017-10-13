namespace _07.Greeting
{
    using System;

    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {secondName}.\r\nYou are {age} years old.");
        }
    }
}
