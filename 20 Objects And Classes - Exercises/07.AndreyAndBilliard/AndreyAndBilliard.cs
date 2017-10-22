namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int numberOfItems = int.Parse(Console.ReadLine());
            Dictionary<string, double> shop = new Dictionary<string, double>();

            while (numberOfItems > 0)
            {
                string[] tokens = Console.ReadLine()
                                            .Split('-');

                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);

                if (!shop.ContainsKey(productName))
                {
                    shop[productName] = 0;
                }
                shop[productName] = productPrice;

                numberOfItems--;
            }

            List<Customer> allCustomers = new List<Customer>();

            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients")
                {
                    break;
                }
                string[] tokens = info.Split('-', ',');

                string clientName = tokens[0];
                string productName = tokens[1];
                double quantity = double.Parse(tokens[2]);

                if (!shop.ContainsKey(productName))
                {
                    continue;
                }

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, double>();
                client.Name = clientName;
                client.ShopList.Add(productName, quantity);

                if (allCustomers.Any(c => c.Name == clientName))
                {
                    Customer existingCustomer = allCustomers.First(c => c.Name == clientName);
                    if (existingCustomer.ShopList.ContainsKey(productName))
                    {
                        existingCustomer.ShopList[productName] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[productName] = quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }


            foreach (Customer customer in allCustomers)
            {
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    foreach (KeyValuePair<string, double> product in shop)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            List<Customer> ordered = allCustomers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();

            foreach (Customer customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
            }
            Console.WriteLine("Total bill: {0:f2}", allCustomers.Sum(c => c.Bill));
        }
    }
}
