namespace _07.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double number, int power)
        {
            double result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
