namespace _11.PriceChangeAlert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfStockPrices = int.Parse(Console.ReadLine());
            double notificationLimit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStockPrices - 1; i++)
            {
                double curentPrice = double.Parse(Console.ReadLine());
                double currentPercentage = GetPercentage(lastPrice, curentPrice);
                bool hasDifference = HasDifference(currentPercentage, notificationLimit);

                string message = GetNotification(curentPrice, lastPrice, currentPercentage, hasDifference);
                Console.WriteLine(message);

                lastPrice = curentPrice;
            }
        }

        public static string GetNotification(double currentPrice, double lastPrice, double difference, bool hasDifference)
        {
            string to = string.Empty;

            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!hasDifference)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (hasDifference && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (hasDifference && (difference < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }

            return to;
        }

        public static bool HasDifference(double limit, double notificationLimit)
        {
            if (Math.Abs(limit) >= notificationLimit)
            {
                return true;
            }

            return false;
        }

        public static double GetPercentage(double lastPrice, double currentPrice)
        {
            return (currentPrice - lastPrice) / lastPrice;
        }
    }
}
