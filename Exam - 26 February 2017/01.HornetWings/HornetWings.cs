namespace _01.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            
            double n = double.Parse(Console.ReadLine()); // wing flaps, hornet chosen to do
            double m = double.Parse(Console.ReadLine()); // distance in meter for 1000 wing flaps
            double p = double.Parse(Console.ReadLine()); // endurance of the hornet

            double distance = (n / 1000.0) * m;

            double flyForSeconds = n / 100;
            double rest = ((int)n / (int)p) * 5;

            int flyTime = (int)(flyForSeconds + rest);

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{flyTime} s.");
        }
    }
}
