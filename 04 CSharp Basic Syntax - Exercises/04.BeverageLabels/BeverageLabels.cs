namespace _04.BeverageLabels
{
    using System;

    public class BeverageLabels
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", 
                                    volume,
                                    name);
            double energyContent = (volume / 100.0) * energyContentPer100ml;
            double sugarContent = (volume / 100.0) * sugarContentPer100ml;
            Console.WriteLine("{0}kcal, {1}g sugars",
                                    energyContent,
                                    sugarContent);
        }
    }
}
