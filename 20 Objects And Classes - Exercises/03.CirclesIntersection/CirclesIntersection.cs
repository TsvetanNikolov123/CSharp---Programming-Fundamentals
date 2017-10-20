namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class Circle
    {
        public Point Center { get; set; }

        public int Radius { get; set; }
    }

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public double DistanceTo(Point p)
        {
            double deltaX = Math.Abs(X - p.X);
            double deltaY = Math.Abs(Y - p.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class CirclesIntersection
    {
        public static void Main()
        {
            Circle circleA = GetCircle();
            Circle circleB = GetCircle();
            bool circlesIntersect = circleA.Center.DistanceTo(circleB.Center) <=
                                    circleA.Radius + circleB.Radius;
            Console.WriteLine(circlesIntersect ? "Yes" : "No");
        }

        private static Circle GetCircle()
        {
            int[] data = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            Point center = new Point() { X = data[0], Y = data[1] };
            Circle circle = new Circle() { Center = center, Radius = data[2] };
            return circle;
        }
    }
}
