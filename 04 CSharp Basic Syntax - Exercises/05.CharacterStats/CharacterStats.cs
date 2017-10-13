namespace _05.CharacterStats
{
    using System;

    public class CharacterStats
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.Write("Health: |");
            Console.Write("{0}{1}",
                new string('|',currentHealth),
                new string('.', maximumHealth - currentHealth));
            Console.WriteLine("|");

            Console.Write("Energy: |");
            Console.Write("{0}{1}",
                new string('|', currentEnergy),
                new string('.', maximumEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
