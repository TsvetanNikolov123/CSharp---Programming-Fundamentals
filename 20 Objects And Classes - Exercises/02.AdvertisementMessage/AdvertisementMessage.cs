namespace _02.AdvertisementMessage
{
    using System;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random rnd = new Random();

            int phraseIndex = rnd.Next(0, phrases.Length);
            int eventIndex = rnd.Next(0, events.Length);
            int authorIndex = rnd.Next(0, authors.Length);
            int cityIndex = rnd.Next(0, cities.Length);


            Console.WriteLine("{0} {1} {2} - {3}",
                phrases[phraseIndex],
                events[eventIndex],
                authors[authorIndex],
                cities[cityIndex]);
        }
    }
}
