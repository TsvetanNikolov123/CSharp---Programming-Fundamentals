namespace _08.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string value = Console.ReadLine();

            if (value == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (value == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine((char)GetMax(first, second));
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
