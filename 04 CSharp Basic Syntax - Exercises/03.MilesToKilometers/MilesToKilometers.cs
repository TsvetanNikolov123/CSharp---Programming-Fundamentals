namespace _03.MilesToKilometers
{
    using System;

    public class MilesToKilometers
    {
        public static void Main()
        {
            double oneMile = 1.60934; // 1 mile = 1.60934 km
            double input = double.Parse(Console.ReadLine());

            double result = input * oneMile;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
