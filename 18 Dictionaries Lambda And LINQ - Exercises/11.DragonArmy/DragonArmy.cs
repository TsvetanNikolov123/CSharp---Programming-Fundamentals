namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            Dictionary<string, SortedDictionary<string, decimal[]>> dragons = 
                new Dictionary<string, SortedDictionary<string, decimal[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string type = tokens[0];
                string name = tokens[1];

                decimal damage = 0m;
                if (tokens[2] != "null")
                {
                    damage = decimal.Parse(tokens[2]);
                }
                else
                {
                    damage = 45;
                }

                decimal heath = 0m;
                if (tokens[3] != "null")
                {
                    heath = decimal.Parse(tokens[3]);
                }
                else
                {
                    heath = 250;
                }

                decimal armor = 0m;
                if (tokens[4] != "null")
                {
                    armor = decimal.Parse(tokens[4]);
                }
                else
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, heath, armor };
            }

            foreach (var type in dragons)
            {
                string typeName = type.Key;
                SortedDictionary<string, decimal[]> dragonsByType = type.Value;

                decimal averageDamage = dragonsByType.Values.Average(a => a[0]);
                decimal averageHealth = dragonsByType.Values.Average(a => a[1]);
                decimal averageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in dragonsByType)
                {
                    string name = dragon.Key;

                    decimal[] stats = dragon.Value;
                    decimal damage = stats[0];
                    decimal health = stats[1];
                    decimal armor = stats[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
