namespace _02.CircleArea12DigitsPrecision
{
    using System;

    public class CircleArea
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
