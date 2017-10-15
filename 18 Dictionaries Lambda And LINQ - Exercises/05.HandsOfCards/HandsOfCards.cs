namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, HashSet<string>> personsCards = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                string[] tokens = input
                                 .Split(':')
                                 .ToArray();
                string[] cards = tokens[1]
                                 .Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
                HashSet<string> hash = new HashSet<string>(cards);

                if (!personsCards.ContainsKey(tokens[0]))
                {
                    personsCards[tokens[0]] = new HashSet<string>();
                }

                foreach (var card in cards)
                {
                    personsCards[tokens[0]].Add(card);
                }
                input = Console.ReadLine();
            }

            foreach (var list in personsCards)
            {
                string personName = list.Key;
                int sumOfAllCards = 0;

                foreach (var card in list.Value)
                {
                    string first;
                    string last;

                    if (card.Length < 3)
                    {
                        first = card[0].ToString();
                        last = card[1].ToString();
                    }
                    else
                    {
                        first = "10";
                        last = card[2].ToString();
                    }

                    int power = 0;

                    switch (first)
                    {
                        case "2":
                            power += 2;
                            break;
                        case "3":
                            power += 3;
                            break;
                        case "4":
                            power += 4;
                            break;
                        case "5":
                            power += 5;
                            break;
                        case "6":
                            power += 6;
                            break;
                        case "7":
                            power += 7;
                            break;
                        case "8":
                            power += 8;
                            break;
                        case "9":
                            power += 9;
                            break;
                        case "10":
                            power += 10;
                            break;
                        case "J":
                            power += 11;
                            break;
                        case "Q":
                            power += 12;
                            break;
                        case "K":
                            power += 13;
                            break;
                        case "A":
                            power += 14;
                            break;
                    }

                    int multipliers = 0;
                    switch (last)
                    {
                        case "S":
                            multipliers += 4;
                            break;
                        case "H":
                            multipliers += 3;
                            break;
                        case "D":
                            multipliers += 2;
                            break;
                        case "C":
                            multipliers += 1;
                            break;
                    }

                    sumOfAllCards += multipliers * power;
                }
                Console.WriteLine("{0}: {1}", personName, sumOfAllCards);
            }
        }
    }
}
