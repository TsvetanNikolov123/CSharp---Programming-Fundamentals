namespace _02.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class List
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                                            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();
            string[] tokens = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "Odd" && tokens[0] != "Even")
            {
                if (tokens.Length == 2)
                {
                    int element = int.Parse(tokens[1]);
                    nums.RemoveAll(e => e == element);
                }
                else if (tokens.Length == 3)
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    nums.Insert(position, element);
                }

                tokens = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (tokens[0] == "Odd")
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(e => e % 2 != 0)));
            }
            else if (tokens[0] == "Even")
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(e => e % 2 == 0)));
            }
        }
    }
}
