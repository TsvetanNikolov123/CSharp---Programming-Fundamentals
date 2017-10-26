namespace _05.MagicExchangeableWords
{
    using System;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            var str1 = input[0].ToCharArray().Distinct().ToArray();
            var str2 = input[1].ToCharArray().Distinct().ToArray();

            
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
