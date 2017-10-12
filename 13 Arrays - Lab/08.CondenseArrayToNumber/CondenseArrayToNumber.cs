namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();

            while (arr.Length >= 2)
            {
                int[] arrTemporary = new int[arr.Length - 1];
                for (int i = 0; i < arrTemporary.Length; i++)
                {
                    arrTemporary[i] = arr[i] + arr[i + 1];
                }
                arr = arrTemporary;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
