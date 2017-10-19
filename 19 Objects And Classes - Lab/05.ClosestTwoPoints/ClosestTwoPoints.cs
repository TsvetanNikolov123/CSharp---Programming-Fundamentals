namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point curretPoint = Point.ParsePoint(Console.ReadLine());

                points.Add(curretPoint);
            }

            double midDistance = double.MaxValue;
            Point[] bestPoints = new Point[2];

            for (int prevPoint = 0; prevPoint < points.Count; prevPoint++)
            {
                for (int currentPoint = prevPoint + 1; currentPoint < points.Count; currentPoint++)
                {
                    double distance = CalcDistance(points[prevPoint], points[currentPoint]);
                    if (distance < midDistance)
                    {
                        midDistance = distance;
                        bestPoints[0] = points[prevPoint];
                        bestPoints[1] = points[currentPoint];
                    }
                }
            }
            Console.WriteLine($"{midDistance:F3}");
            Console.WriteLine(bestPoints[0]);
            Console.WriteLine(bestPoints[1]);
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        
        public static Point ParsePoint(string input)                               
        {                                                                          
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();        
                                                                                   
            return new Point                                                       
            {                                                                      
                X = inputData[0],                                                  
                Y = inputData[1]                                                                                                                                                                                                                                                                                                                                                                                                         
            };                                                                     
        }

        public override String ToString()
        {
            return String.Format($"({X}, {Y})");
        }
    }
}