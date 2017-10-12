namespace _06.StringsAndObjects
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string first = "Hello";
            string second = "World";
            object third = first + " " + second;
            string fourth = Convert.ToString(third);

            Console.WriteLine(fourth);
        }
    }
}
