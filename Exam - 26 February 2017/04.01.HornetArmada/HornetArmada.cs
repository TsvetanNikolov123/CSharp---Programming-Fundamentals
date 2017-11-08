namespace _04._01.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> legionSoldiers =
                new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionActivities =
                new Dictionary<string, long>();

            long n = long.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                long activity = long.Parse(inputArgs[0]);
                string legion = inputArgs[1];
                string soldier = inputArgs[2];
                long count = long.Parse(inputArgs[3]);

                if (!legionActivities.ContainsKey(legion))
                {
                    legionActivities.Add(legion, activity);
                }
                else
                {
                    if (activity > legionActivities[legion])
                    {
                        legionActivities[legion] = activity;
                    }
                }

                if (!legionSoldiers.ContainsKey(legion))
                {
                    legionSoldiers.Add(legion, new Dictionary<string, long>());
                }

                if (!legionSoldiers[legion].ContainsKey(soldier))
                {
                    legionSoldiers[legion].Add(soldier, 0);
                }

                legionSoldiers[legion][soldier] += count;
            }

            string[] printArgs = Console.ReadLine().Split('\\');

            if (printArgs.Length > 1)
            {

                long activity = long.Parse(printArgs[0]);
                string soldier = printArgs[1];

                foreach (var legion in legionSoldiers
                    .Where(legion => legionSoldiers[legion.Key].ContainsKey(soldier))
                    .Where(legion => legionActivities[legion.Key] < activity) // TODO
                    .OrderByDescending(legion => legion.Value[soldier]))
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value[soldier]}");
                }

            }
            else
            {
                string soldier = printArgs[0];

                foreach (var legion in legionActivities
                    .Where(legion => legionSoldiers[legion.Key].ContainsKey(soldier))
                    .OrderByDescending(legion => legion.Value))
                {
                    Console.WriteLine($"{legionActivities[legion.Key]} : {legion.Key}");
                }
            }
        }
    }
}
