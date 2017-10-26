namespace _08.LettersChangeNumbers
{
    using System;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            
            foreach (string token in tokens)
            {
                char firstLetter = (char)token[0];
                char lastLetter = (char)token[token.Length - 1];
                string stringNumber = token.Substring(1, token.Length - 2);
                double number = double.Parse(stringNumber);
                
                if (char.IsUpper(firstLetter))
                {
                    number = number / ((int)(firstLetter) - 64);
                }
                else
                {
                    number = number * ((int)(firstLetter) - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    number = number - ((int)(lastLetter) - 64);
                }
                else
                {
                    number = number + ((int)(lastLetter) - 96);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
