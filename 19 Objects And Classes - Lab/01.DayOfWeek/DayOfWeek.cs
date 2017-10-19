namespace _01.DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            var result = myDate.DayOfWeek;
            Console.WriteLine(result);
        }
    }
}
