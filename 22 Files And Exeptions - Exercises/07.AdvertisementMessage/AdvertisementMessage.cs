using System;
using System.IO;

namespace _07.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = File.ReadAllLines("../../Phrases.txt");
            string[] events = File.ReadAllLines("../../Events.txt");
            string[] authors = File.ReadAllLines("../../Author.txt");
            string[] cities = File.ReadAllLines("../../Cities.txt");
            File.Delete("../../Output.txt");

            Random rnd = new Random();

            int phraseIndex = rnd.Next(0, phrases.Length);
            int eventIndex = rnd.Next(0, events.Length);
            int authorIndex = rnd.Next(0, authors.Length);
            int cityIndex = rnd.Next(0, cities.Length);

            string phrase = phrases[phraseIndex];
            string eventt = events[eventIndex];
            string author = authors[authorIndex];
            string city = cities[cityIndex];
            string result = $"{phrase} {eventt} {author} - {city}";

            File.AppendAllText("../../Output.txt", result + Environment.NewLine);
        }
    }
}
