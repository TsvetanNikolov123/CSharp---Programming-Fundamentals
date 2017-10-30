namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            string[] driversNames = Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries);

            double[] zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double[] chekPointIndex = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (string name in driversNames)
            {
                string driverName = name;
                double driverStartFuel = (double)Convert.ToInt32(driverName[0]);
                int zoneOfFuelEnd = 0;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (chekPointIndex.Contains(i))
                    {
                        driverStartFuel += zones[i];
                    }
                    else
                    {
                        driverStartFuel -= zones[i];
                        if (driverStartFuel <= 0)
                        {
                            zoneOfFuelEnd = i;
                            break;
                        }
                    }
                }

                if (driverStartFuel > 0)
                {
                    Console.WriteLine($"{driverName} - fuel left {driverStartFuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driverName} - reached {zoneOfFuelEnd}");
                }
            }

        }
        
    }
}
