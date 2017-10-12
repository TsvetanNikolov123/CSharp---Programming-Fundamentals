namespace _02.ChooseADrink2
{
    using System;

    public class ChooseADrink2
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {quantity * 0.7:f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {quantity * 1.00:f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {quantity * 1.00:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.70:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
                    break;
            }
        }
    }
}
