namespace _05.BooleanVariable
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            bool input = Convert.ToBoolean(Console.ReadLine());

            if (input)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
