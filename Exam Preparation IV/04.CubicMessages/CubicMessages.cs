namespace _04.CubicMessages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";
            var messageRegex = new Regex(pattern);

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Over!")
                {
                    break;
                }

                var messageMatch = messageRegex.Match(line);

                if (!messageMatch.Success)
                {
                    continue;
                }

                var leftPart = messageMatch.Groups["leftPart"].Value;
                var message = messageMatch.Groups["message"].Value;
                var rightPart = messageMatch.Groups["rightPart"].Value;

                var messageLength = int.Parse(Console.ReadLine());

                if (messageLength != message.Length)
                {
                    continue;
                }

                //var verificationCode = new string((leftPart + rightPart)
                //    .Where(char.IsDigit)
                //    .Select(@char => int.Parse(@char.ToString()))
                //    .Select(index => index >= 0 && index < message.Length ? message[index] : ' ')
                //    .ToArray());
                
                
                // FROM HERE 
                var verificationCode = new StringBuilder();
                foreach (var @char in leftPart+ rightPart)
                {
                    if (!char.IsDigit(@char))
                    {
                        continue;
                    }

                    var index = int.Parse(@char.ToString());
                    var isValidIndex = index >= 0 && index < message.Length;

                    if (isValidIndex)
                    {
                        verificationCode.Append(message[index]);
                    }
                    else
                    {
                        verificationCode.Append(' ');
                    }
                }
                // TO HERE IS THE SAME AS UPPER!!!
                Console.WriteLine($"{message} == {verificationCode}");
            }
        }
    }
}
