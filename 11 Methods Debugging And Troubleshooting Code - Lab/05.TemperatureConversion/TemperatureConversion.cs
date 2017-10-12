namespace _05.TemperatureConversion
{
    using System;

    public class TemperatureConversion
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
