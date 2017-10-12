namespace _03.RestaurantDiscount
{
    using System;

    public class RestaurantDiscount
    {
        public static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;
            double pricePerPerson = 0;

            if (groupSize <= 50)
            {
                if (package == "Normal")
                {
                    totalPrice = 2500 + 500;
                    discount = totalPrice - (totalPrice * 5 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    totalPrice = 2500 + 750;
                    discount = totalPrice - (totalPrice * 10 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    totalPrice = 2500 + 1000;
                    discount = totalPrice - (totalPrice * 15 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else if (groupSize <= 100)
            {
                if (package == "Normal")
                {
                    totalPrice = 5000 + 500;
                    discount = totalPrice - (totalPrice * 5 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    totalPrice = 5000 + 750;
                    discount = totalPrice - (totalPrice * 10 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    totalPrice = 5000 + 1000;
                    discount = totalPrice - (totalPrice * 15 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else if (groupSize <= 120)
            {
                if (package == "Normal")
                {
                    totalPrice = 7500 + 500;
                    discount = totalPrice - (totalPrice * 5 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    totalPrice = 7500 + 750;
                    discount = totalPrice - (totalPrice * 10 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    totalPrice = 7500 + 1000;
                    discount = totalPrice - (totalPrice * 15 / 100.0);
                    pricePerPerson = discount / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
