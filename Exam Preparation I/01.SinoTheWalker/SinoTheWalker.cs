namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int secondsForOneStep = int.Parse(Console.ReadLine()) % 86400;

            double tolalSeconds = numberOfSteps * secondsForOneStep;

            time = time.AddSeconds(tolalSeconds);

            Console.Write("Time Arrival: ");
            Console.WriteLine(time.ToString("HH:mm:ss"));
        }
    }
}
