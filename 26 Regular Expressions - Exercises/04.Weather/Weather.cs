namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Weather
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<double, string>> cities =
                new Dictionary<string, Dictionary<double, string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                string regex = @"(?<city>[A-Z]{2})(?<temperature>[0-9]{2}\.[0-9]*)(?<weather>([A-Z][a-z]|[a-z])[a-z]*\|)";

                foreach (Match m in Regex.Matches(input, regex))
                {
                    string cityName = m.Groups["city"].Value;
                    double temperature = double.Parse(m.Groups["temperature"].Value);
                    string weather = m.Groups["weather"].Value.Trim('|');

                    cities[cityName] = new Dictionary<double, string>();
                    cities[cityName][temperature] = weather;
                }
            }
      
            foreach (var city in cities.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var temp in city.Value)
                {
                    Console.WriteLine("{0} => {1:f2} => {2}", city.Key,temp.Key, temp.Value);
                }
            } 
        }
    }
}
