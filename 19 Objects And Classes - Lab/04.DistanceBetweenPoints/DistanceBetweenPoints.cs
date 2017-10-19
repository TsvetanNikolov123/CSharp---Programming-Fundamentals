namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secound = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point { X = first[0], Y = first[1] };
            Point secoundPoint = new Point { X = secound[0], Y = secound[1] };

            double distance = CalcDistance(firstPoint, secoundPoint);

            Console.WriteLine("{0:f3}", distance);
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var hypotenuse = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return hypotenuse;
        }
    }
}
