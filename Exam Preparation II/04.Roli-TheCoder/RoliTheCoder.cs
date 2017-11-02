namespace _04.Roli_TheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }

    public class RoliTheCoder
    {
        public static void Main()
        {
            List<Event> result = new List<Event>();

            Dictionary<int,Event> eventById = new Dictionary<int, Event>( );

            while (true)
            {
                string currentLine = Console.ReadLine();

                if (currentLine == "Time for Code")
                {
                    break;
                }

                string[] lineParts = currentLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int eventId = 0;

                if (!int.TryParse(lineParts[0], out eventId))
                {
                    continue;
                }

                string eventName = null;

                if (lineParts.Length > 1 && lineParts[1].StartsWith("#"))
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                List<string> participants = new List<string>();

                if (lineParts.Length > 2)
                {
                    participants = lineParts.Skip(2).ToList();

                    if (!participants.All(p => p.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventById.ContainsKey(eventId))
                {
                    if (eventById[eventId].Name == eventName)
                    {
                        var existingEvent = eventById[eventId];
                        existingEvent.Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Event newEvent = new Event
                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = participants
                    };

                    result.Add(newEvent);
                    eventById.Add(eventId, newEvent);
                }

                participants.Sort();
            }
            var sortedEvents = result
                .OrderByDescending(e => e.Participants.Distinct().Count())
                .ThenBy(e => e.Name);

            foreach (var ev in sortedEvents)
            {
                var distinctParticipants = ev.Participants.Distinct().ToList();

                Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
                foreach (var participant in distinctParticipants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }

        }
    }
}
