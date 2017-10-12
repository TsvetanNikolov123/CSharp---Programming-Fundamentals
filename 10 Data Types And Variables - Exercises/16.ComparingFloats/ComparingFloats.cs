namespace _16.ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;

            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
