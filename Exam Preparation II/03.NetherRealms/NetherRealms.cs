namespace _03.NetherRealms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            string[] demons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, double> healthDic = new SortedDictionary<string, double>();
            SortedDictionary<string, double> damageDic = new SortedDictionary<string, double>();

            foreach (var demon in demons)
            {
                var healthSymbols = demon
                    .Where(s =>
                            !char.IsDigit(s) &&
                            s != '+' &&
                            s != '-' &&
                            s != '*' &&
                            s != '/' &&
                            s != '.');

                int health = 0;

                foreach (char healthSymbol in healthSymbols)
                {
                    health += (int)healthSymbol;
                }

                Regex regex = new Regex(@"-?\d+\.?\d*");
                MatchCollection matches = regex.Matches(demon);
                double damage = 0.0;

                foreach (Match match in matches)
                {
                    double currentnumber = double.Parse(match.Value);
                    damage += currentnumber;
                }

                var modifiers = demon.Where(s => s == '*' || s == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else if (modifier == '/')
                    {
                        damage /= 2;
                    }
                }
                // TODO

                    healthDic[demon] = health;
                    damageDic[demon] = damage;
            }

            foreach (var demon in healthDic)
            {
                string name = demon.Key;
                double health = demon.Value;
                double damage = damageDic[name];

                Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
            }
        }
    }
}
