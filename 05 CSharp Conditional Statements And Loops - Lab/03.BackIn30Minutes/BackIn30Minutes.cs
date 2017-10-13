namespace _03.BackIn30Minutes
{
    using System;

    public class BackIn30Minutes
    {
        public static void Main()

        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 >= 60)
            {
                hours++;
                minutes += 30;
                minutes -= 60;
            }
            else
            {
                minutes += 30;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine("{0}:{1:d2}", hours, minutes);
        }
    }
}
