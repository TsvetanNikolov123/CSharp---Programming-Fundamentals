/// <summary>
/// 90/100
/// </summary>

namespace _04.WinningTicket
{
    using System;
    using System.Collections.Generic;

    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' , '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string element in tickets)
            {
                string ticket = element;//.Trim();
                
                
                if (ticket.Length < 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Dictionary<char, int> dicLeft =
                    new Dictionary<char, int>();
                    Dictionary<char, int> dicRight =
                        new Dictionary<char, int>();
                    dicLeft['@'] = 0;
                    dicLeft['#'] = 0;
                    dicLeft['$'] = 0;
                    dicLeft['^'] = 0;
                    dicRight['@'] = 0;
                    dicRight['#'] = 0;
                    dicRight['$'] = 0;
                    dicRight['^'] = 0;
                    
                    for (int i = 0; i < 20; i++)
                    {
                        if (i < 10)
                        {
                            if (ticket[i] == '@') dicLeft['@']++;
                            if (ticket[i] == '#') dicLeft['#']++;
                            if (ticket[i] == '$') dicLeft['$']++;
                            if (ticket[i] == '^') dicLeft['^']++;
                        }
                        else
                        {
                            if (ticket[i] == '@') dicRight['@']++;
                            if (ticket[i] == '#') dicRight['#']++;
                            if (ticket[i] == '$') dicRight['$']++;
                            if (ticket[i] == '^') dicRight['^']++;
                        }
                    }

                    int count = 0;
                    foreach (var @char in dicLeft)
                    {
                        char ch = @char.Key;
                        int ch1Count = @char.Value;
                        int ch2Count = dicRight[@char.Key];
                        string winCombination = string.Empty;

                        for (int i = 0; i < Math.Min(ch1Count, ch2Count); i++)
                        {
                            winCombination += ch.ToString();
                        }

                        string ticketFirstHalf = ticket.Substring(0, 10);
                        string ticketSecondHalf = ticket.Substring(10, 10);

                        if (ch1Count == 10 && ch2Count == 10)
                        {
                            Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", ticket, ch);
                            count++;
                            break;
                        }

                        if (ch1Count >= 6 && ch2Count >= 6
                            && ticketFirstHalf.Contains(winCombination)
                            && ticketSecondHalf.Contains(winCombination))
                        {
                            count++;
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, Math.Min(ch1Count, ch2Count), ch);
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                }
            }
        }
    }
}
