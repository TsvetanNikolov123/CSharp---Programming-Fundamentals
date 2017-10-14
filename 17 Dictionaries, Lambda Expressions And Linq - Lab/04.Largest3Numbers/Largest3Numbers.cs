namespace _04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                                          .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(double.Parse)
                                          .ToList();

           

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
