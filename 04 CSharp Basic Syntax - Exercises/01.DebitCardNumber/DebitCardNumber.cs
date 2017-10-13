namespace _01.DebitCardNumber
{
    using System;

    public class DebitCardNumber
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}",
                                firstNumber,
                                secondNumber,
                                thirdNumber,
                                fourthNumber);
        }
    }
}
