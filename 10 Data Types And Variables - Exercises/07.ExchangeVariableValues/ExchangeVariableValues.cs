namespace _07.ExchangeVariableValues
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            int c = b;
            b = a;
            a = c;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {a}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
