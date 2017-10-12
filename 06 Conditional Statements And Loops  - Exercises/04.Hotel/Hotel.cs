namespace _04.Hotel
{
    using System;

    public class Hotel
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                double discount = 0.0;
                double studioRoom = 50.0;
                double doubleRoom = 65.0;
                double suiteRoom = 75.0;
                double freeNight = 0.0;

                if (nightsCount > 7)    // studio 5%
                {
                    discount = nightsCount * studioRoom * 5 / 100.0;
                }

                if (month == "October" && nightsCount > 7)
                {
                    freeNight = studioRoom - studioRoom * 5 / 100;
                }

                Console.WriteLine("Studio: {0:f2} lv.", (studioRoom * nightsCount - discount) - freeNight);
                Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", suiteRoom * nightsCount);
            }
            else if (month == "June" || month == "September")
            {
                double discount = 0.0;
                double studioRoom = 60.0;
                double doubleRoom = 72.0;
                double suiteRoom = 82.0;
                double freeNight = 0.0;

                if (nightsCount > 14)    // studio 10%
                {
                    discount = nightsCount * doubleRoom * 10 / 100.0;
                }

                if (month == "September" && nightsCount > 7)
                {
                    freeNight = studioRoom; //- studioRoom * 10 / 100.0;
                }

                Console.WriteLine("Studio: {0:f2} lv.", studioRoom * nightsCount - freeNight);
                Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nightsCount - discount);
                Console.WriteLine("Suite: {0:f2} lv.", suiteRoom * nightsCount);
            }
            else if (month == "July" || month == "August" || month == "December")
            {

                double discount = 0.0;
                double studioRoom = 68.0;
                double doubleRoom = 77.0;
                double suiteRoom = 89.0;

                if (nightsCount > 14)    // studio 15%
                {
                    discount = nightsCount * suiteRoom * 15 / 100.0;
                }

                Console.WriteLine("Studio: {0:f2} lv.", studioRoom * nightsCount);
                Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nightsCount);
                Console.WriteLine("Suite: {0:f2} lv.", suiteRoom * nightsCount - discount);
            }
        }
    }
}
