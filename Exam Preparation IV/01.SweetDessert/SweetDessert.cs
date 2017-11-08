namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            //for six portions - 2 bananas, 4 eggs and 0.2 kilos berries.

            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            decimal numberOfGuest = decimal.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal moneyForSetOfSixPortions =
                bananasPrice * 2 +
                eggsPrice * 4 +
                berriesPrice * 0.2m;

            decimal setsOfPortions = Math.Ceiling(numberOfGuest / 6);

            decimal neededMoney = setsOfPortions * moneyForSetOfSixPortions;

            if (amountOfCash >= neededMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", neededMoney);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",
                    neededMoney - amountOfCash);
            }
        }
    }
}
