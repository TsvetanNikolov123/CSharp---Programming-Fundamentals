namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale(Console.ReadLine());
                sales.Add(sale);
            }

            List<string> towns = sales
                                   .Select(s => s.Town)
                                   .Distinct()
                                   .OrderBy(t => t)
                                   .ToList();
            foreach (string town in towns)
            {
                double currentSum = sales
                                        .Where(s => s.Town == town)
                                        .Select(s => s.Price * s.Quantity)
                                        .Sum();

                Console.WriteLine($"{town} -> {currentSum:F2}");
            }
        }

        private static Sale ReadSale(string input)
        {
            string[] tokens = input.Split();
            string town = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);
            double quantity = double.Parse(tokens[3]);

            return new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
