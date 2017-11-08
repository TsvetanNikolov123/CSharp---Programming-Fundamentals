namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetComm
    {
        public static void Main()
        {

            Dictionary<string, List<string>> broadcasts = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                
                string[] tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 2)
                {
                    continue;
                }

                string firstQuery = tokens[0];
                string secondQuery = tokens[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    //private message
                    string recipientsData = ReverseString(firstQuery);
                    string message = secondQuery;
                    if (!messages.ContainsKey(recipientsData))
                    {
                        messages[recipientsData] = new List<string>();
                    }
                    messages[recipientsData].Add(message);
                }
                else if (!firstQuery.Any(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    //broadcast
                    string message = firstQuery;
                    string frequency = "";
                    char[] temp = secondQuery.ToCharArray();
                    foreach (char @char in temp)
                    {
                        if (char.IsLower(@char))
                        {
                            frequency = frequency + char.ToUpper(@char);
                        }
                        else
                        {
                            frequency = frequency + char.ToLower(@char);
                        }
                    }

                    if (!broadcasts.ContainsKey(frequency))
                    {
                        broadcasts[frequency] = new List<string>();
                    }
                    broadcasts[frequency].Add(message);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count != 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    string frequency = broadcast.Key;
                    List<string> broadcastsMessages = broadcast.Value;

                    foreach (var broadcastMessage in broadcastsMessages)
                    {
                        Console.WriteLine($"{frequency} -> {broadcastMessage}");
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count != 0)
            {
                foreach (var message in messages)
                {
                    string recipient = message.Key;
                    List<string> recipientMessages = message.Value;

                    foreach (var recipientMessage in recipientMessages)
                    {
                        Console.WriteLine($"{recipient} -> {recipientMessage}");
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }

        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
