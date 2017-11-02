namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] ladybugIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[size];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                if (ladybugIndex < 0 || ladybugIndex >= size)
                {
                    continue;
                }

                field[ladybugIndex] = 1;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                int currentLadyBugIndex = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int flyLength = int.Parse(commandParts[2]);

                if (currentLadyBugIndex < 0 || currentLadyBugIndex >= size)
                {
                    continue;
                }

                if (field[currentLadyBugIndex] == 0)
                {
                    continue;
                }

                field[currentLadyBugIndex] = 0;
                int position = currentLadyBugIndex;

                while (true)
                {

                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    // there is an another ladybug heres, keep walking
                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
