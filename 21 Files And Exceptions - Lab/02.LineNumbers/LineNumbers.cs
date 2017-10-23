namespace _02.LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");
            File.Delete("Output.txt");

            for (int i = 0; i < input.Length; i++)
            {
                int lineNumber = i + 1;
                string str = input[i];
                string line = $"{lineNumber}. {str}";
                File.AppendAllText("Output.txt", line + Environment.NewLine);
            }
        }
    }
}
