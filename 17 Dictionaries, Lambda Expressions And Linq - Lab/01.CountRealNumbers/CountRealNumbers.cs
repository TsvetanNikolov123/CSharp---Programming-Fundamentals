namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                                          .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(double.Parse)
                                          .ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                    counts[number]++;
            }

            foreach (var count in counts)
            {
                Console.WriteLine("{0} -> {1}",count.Key, count.Value);
            }
        }
    }
}
