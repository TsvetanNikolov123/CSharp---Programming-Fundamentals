namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    Console.WriteLine("{0:f2}",FaceOfCube(sideOfCube));
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", SpaceOfCube(sideOfCube));
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", VolumeOfCube(sideOfCube));
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", AreaOfCube(sideOfCube));
                    break;
            }
        }

        static double FaceOfCube(double sideOfCube)
        {
            double face = Math.Sqrt(2 * sideOfCube * sideOfCube);
            return face;
        }

        static double SpaceOfCube(double sideOfCube)
        {
            double space = Math.Sqrt(3 * sideOfCube * sideOfCube);
            return space;
        }

        static double VolumeOfCube(double sideOfCube)
        {
            double volume = Math.Pow(sideOfCube, 3);
            return volume;
        }

        static double AreaOfCube(double sideOfCube)
        {
            double area = sideOfCube * sideOfCube * 6;
            return area;
        }
    }
}
