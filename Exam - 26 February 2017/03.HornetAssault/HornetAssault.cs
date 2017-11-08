namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            double[] beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            List<double> hornets = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Reverse()
                 .ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                double hornetsSummedPower = hornets.Sum();
                double beehive = beehives[i];

                if (hornetsSummedPower > beehive)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] = beehives[i] - hornets.Sum();
                    if (hornets.Count!=0)
                    {
                        hornets.RemoveAt(hornets.Count - 1);
                    }
                }

            }

            hornets.Reverse();

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(a => a > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(a => a > 0)));
            }

        }
    }
}
