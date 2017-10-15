namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(' ');
                switch (data[0])
                {
                    case "A":
                        {
                            string name = data[1];
                            string phonenumber = data[2];
                            if (!phonebook.ContainsKey(name))
                            {
                                phonebook[name] = "";
                            }
                            phonebook[name] = phonenumber;
                            break;
                        }
                    case "S":
                        {
                            string name = data[1];
                            if (phonebook.ContainsKey(name))
                            {
                                Console.WriteLine(string.Join(" -> ", name, phonebook[name]));
                            }
                            else Console.WriteLine($"Contact {name} does not exist.");
                            break;
                        }
                    case "ListAll":
                        {
                            foreach (var phonebookPair in phonebook)
                            {
                                Console.WriteLine(string.Join(" -> ", phonebookPair.Key, phonebookPair.Value));
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}