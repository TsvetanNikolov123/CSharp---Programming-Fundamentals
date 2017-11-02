namespace _01.SoftUniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;
            while (n != 0)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = (days * capsulesCount) * pricePerCapsule;
                totalPrice += price;

                Console.WriteLine("The price for the coffee is: ${0:F2}", price);
                n--;
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
