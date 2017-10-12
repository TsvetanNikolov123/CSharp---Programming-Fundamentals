namespace _06.TheatrePromotions
{
    using System;

    public class TheatrePromotions
    {
        public static void Main()
        {
            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (0 <= age && age <= 18)
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (dayOfWeek == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (dayOfWeek == "Holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (dayOfWeek == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (dayOfWeek == "Holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (dayOfWeek == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (dayOfWeek == "Holiday")
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
