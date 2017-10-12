namespace _01.Hello_Name_
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Name(input);
        }

        public static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
