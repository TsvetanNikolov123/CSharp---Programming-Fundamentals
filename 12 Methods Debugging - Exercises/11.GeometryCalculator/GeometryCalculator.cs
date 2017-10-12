namespace _11.GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string figures = Console.ReadLine();

            switch (figures)
            {
                case "triangle":
                    Triangle();
                    break;
                case "square":
                    Square();
                    break;
                case "rectangle":
                    Rectangle();
                    break;
                case "circle":
                    Circle();
                    break;
            }
        }

        public static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = side * height / 2;
            Console.WriteLine("{0:f2}", triangleArea);
        }

        public static void Square()
        {
            double side = double.Parse(Console.ReadLine());

            double squareArea = side * side;
            Console.WriteLine("{0:f2}", squareArea);
        }

        public static void Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = width * height;
            Console.WriteLine("{0:f2}", rectangleArea);
        }

        public static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * (radius * radius);
            Console.WriteLine("{0:f2}", circleArea);
        }
    }
}
