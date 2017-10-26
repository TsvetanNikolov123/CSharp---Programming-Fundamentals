namespace _03.UnicodeCharacters
{
    using System;
    using System.Linq;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string value = Console.ReadLine();

            var chars = value
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
