namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (inputData != "report")
            {
                string[] tokens = inputData
                                    .Split('|')
                                    .ToArray();
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, long>();
                }

                if (!data[country].ContainsKey(city))
                {
                    data[country].Add(city, population);
                }

                inputData = Console.ReadLine();
            }

            foreach (var state in data.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }

        }
    }
}
