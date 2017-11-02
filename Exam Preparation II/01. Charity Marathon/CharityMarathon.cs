namespace _01.Charity_Marathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            decimal marathonDays = int.Parse(Console.ReadLine());
            decimal numberOfRunners = int.Parse(Console.ReadLine());
            decimal averageNumberOfLapsEveryRunnerMakes = int.Parse(Console.ReadLine());
            decimal lengthTrack= int.Parse(Console.ReadLine());
            decimal capacityTrack = int.Parse(Console.ReadLine());
            decimal moneyDonatePerKm = decimal.Parse(Console.ReadLine());

            decimal maxRunnersForAllTime = marathonDays * capacityTrack;
            if (maxRunnersForAllTime > numberOfRunners)
            {
                maxRunnersForAllTime = numberOfRunners;
            }

            decimal totalMeters = maxRunnersForAllTime *
                averageNumberOfLapsEveryRunnerMakes *
                lengthTrack;

            decimal totalKm = totalMeters / 1000;
            decimal moneyRaisedForMarathon = totalKm * moneyDonatePerKm;
            Console.WriteLine($"Money raised: {moneyRaisedForMarathon:F2}");
        }
    }
}
