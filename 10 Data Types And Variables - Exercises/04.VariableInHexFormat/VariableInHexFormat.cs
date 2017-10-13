namespace _04.VariableInHexFormat
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            decimal num = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine(num);
        }
    }
}
