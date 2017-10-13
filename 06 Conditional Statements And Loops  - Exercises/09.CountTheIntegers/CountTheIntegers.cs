namespace _09.CountTheIntegers
{
    using System;

    public class CountTheIntegers
    {
        public static void Main()
        {
            int num = 0;
            int counter = 0;

            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
