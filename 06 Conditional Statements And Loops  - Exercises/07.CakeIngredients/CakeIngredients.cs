namespace _07.CakeIngredients
{
    using System;

    public class CakeIngredients
    {
        public static void Main()
        {
            string ingredient = Console.ReadLine();
            int counter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredient = Console.ReadLine();
                counter++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
