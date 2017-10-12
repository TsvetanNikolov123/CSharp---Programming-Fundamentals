namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            int[] secondArr = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            int[] resultArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
