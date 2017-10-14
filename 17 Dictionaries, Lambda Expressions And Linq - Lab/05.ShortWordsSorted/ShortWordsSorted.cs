namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                                        .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' },
                                            StringSplitOptions.RemoveEmptyEntries)
                                        .Where(w => w.Length < 5)
                                        .OrderBy(w => w)
                                        .Select(w => w.ToLower())
                                        .Distinct()
                                        .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
