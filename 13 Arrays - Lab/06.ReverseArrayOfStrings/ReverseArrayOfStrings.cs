namespace _06.ReverseArrayOfStrings
{
    using System;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine()
                                    .Split(' ');
            for (int i = 0; i < arr.Length / 2; i++)
            {
                SwapElements(arr, i, arr.Length - 1 - i);
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        static void SwapElements(string[] arr, int i, int j)
        {
            string oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}
