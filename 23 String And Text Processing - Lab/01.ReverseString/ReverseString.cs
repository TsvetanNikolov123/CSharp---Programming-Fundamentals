namespace _01.ReverseString
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string reversed = ReverseStringMethod(input);
            Console.WriteLine(reversed);
        }

        public static string ReverseStringMethod(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

    }
}
