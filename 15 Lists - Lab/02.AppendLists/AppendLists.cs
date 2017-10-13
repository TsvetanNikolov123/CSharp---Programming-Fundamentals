namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine()
                                    .Split('|');

            List<int> result = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                List<int> temp = tokens[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();
                result.AddRange(temp);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
