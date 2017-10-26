namespace _02.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            int baseNNum = int.Parse(input[0]);
            char[] baseTenNum = input[1].ToCharArray();
            BigInteger result = new BigInteger(0);

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                int currentNum = (int)char.GetNumericValue(baseTenNum[i]);
                result += currentNum * BigInteger.Pow(baseNNum, baseTenNum.Length - i - 1);
            }
            Console.WriteLine(result);
        }
    }
}
