namespace _05.RoundingNumbers
{
    using System;

    public class RoundingNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                                    .Split();

            double[] arr = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                double num = arr[i];
                double numRoundet = Math.Round(arr[i], 0, MidpointRounding.AwayFromZero);

                Console.WriteLine("{0} => {1}", num, numRoundet);
            }
        }
    }
}
