namespace _01.Anonymous_Downsite
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class AnonymousDownsite
    {
        public static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            decimal siteLoss = 0.0m;
            
            List<string> siteNames = new List<string>();

            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= securityKey;
            }

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string siteName = inputTokens[0];
                siteNames.Add(siteName);
                decimal siteVisits = decimal.Parse(inputTokens[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(inputTokens[2]);

                siteLoss += siteVisits * siteCommercialPricePerVisit;
            }
            foreach (var site in siteNames)
            {
                Console.WriteLine($"{site}");
            }

            Console.WriteLine($"Total Loss: {siteLoss:f20}");

            Console.WriteLine($"Security Token: {sum}");
        }
    }
}
