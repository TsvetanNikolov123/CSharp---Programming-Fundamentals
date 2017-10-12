namespace _02.RectangleArea
{
    using System;

    public class RectangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("{0:f2}", area);
        }
    }
}
