namespace _01.OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("Input.txt");
            File.Delete("Output.txt");

            for (int i = 1; i < inputLines.Length; i+=2)
            {
                File.AppendAllText("Output.txt", inputLines[i] + Environment.NewLine);
            }

            // string[] lines = File.ReadAllLines("lines.txt");
            // var oddLines = lines.Where((line, index) => index % 2 == 1);
            // File.WriteAllLines("odd-lines.txt", oddLines);

        }
    }
}
