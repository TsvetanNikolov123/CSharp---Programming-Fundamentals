namespace _03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchForANumber
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            int[] arr = Console.ReadLine()
                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int elementsToTake = arr[0];
            int elementsToDelete = arr[1];
            int searchedNumber = arr[2];

            List<int> saveNewNumbers = nums.Take(elementsToTake).ToList();
            saveNewNumbers.RemoveRange(0, elementsToDelete);

            if (saveNewNumbers.Contains(searchedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
