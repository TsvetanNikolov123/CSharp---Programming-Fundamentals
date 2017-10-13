namespace _04.TripleSum
{
    using System;

    public class TripleSum
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                                    .Split(' ');

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            bool tripleExists = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], numbers[k]);
                            tripleExists = true;
                            break;
                        }
                    }
                }
            }

            if (!tripleExists)
            {
                Console.WriteLine("No");
            }
        }
    }
}
