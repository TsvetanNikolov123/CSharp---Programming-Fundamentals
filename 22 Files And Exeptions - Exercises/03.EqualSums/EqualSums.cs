namespace _03.EqualSums
{
    using System;
    using System.IO;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");
            
            int[] numbers = input[0]
                                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            bool isFoundEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    int result = i;
                    File.AppendAllText("../../Output.txt", result.ToString() + Environment.NewLine);
                    isFoundEqualSums = true;
                    break;
                }
            }

            if (!isFoundEqualSums)
            {
                File.AppendAllText("../../Output.txt", "no" + Environment.NewLine);
            }
        }
    }
}
