namespace _14.IntegerToHexAndBinary
{
    using System;

    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
