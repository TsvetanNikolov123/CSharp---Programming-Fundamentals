namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            List<string> tokens = Console.ReadLine()
                                         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {

                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "A")
                {
                    if (!phonebook.ContainsKey(tokens[1]))
                    {
                        phonebook[tokens[1]] = "";
                    }
                    phonebook[tokens[1]] = tokens[2];
                }
                else if (tokens[0] == "S")
                {
                    if (phonebook.ContainsKey(tokens[1]))
                    {
                        string name = tokens[1];
                        string phonenumber = phonebook[tokens[1]];
                        Console.WriteLine("{0} -> {1}", name, phonenumber);
                    }
                    else
                    {
                        string name = tokens[1];
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                tokens = Console.ReadLine()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            }
        }
    }
}
