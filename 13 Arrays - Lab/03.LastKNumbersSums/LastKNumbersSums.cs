namespace _03.LastKNumbersSums
{
    using System;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;

            for (int current = 1; current < arr.Length; current++)
            {
                int start = Math.Max(0, current - k);
                int end = current - 1;
                long sum = 0;

                for (int prev = start; prev <= end; prev++)
                {
                    sum += arr[prev];
                }

                arr[current] = sum;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
