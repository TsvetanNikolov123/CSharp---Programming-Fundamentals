namespace _09.LegendaryFarming
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, int> trashDic = new Dictionary<string, int>();

            dic["Shards"] = 0;
            dic["Fragments"] = 0;
            dic["Motes"] = 0;
            bool ready = false;

            while (true)
            {
                if (ready)
                {
                    break;
                }
                string[] input = Console.ReadLine()
                                        .Split(' ')
                                        .ToArray();

                for (int i = 1; i <= input.Length - 1; i++)
                {
                    int quantity = 0;
                    string material = "";

                    if (i % 2 != 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else
                    {
                        material = input[i];
                    }

                    if (material == "Shard" || material == "Fragments" || material == "Dragonwrath")
                    {
                        dic[material] += quantity;
                    }
                    else
                    {
                        if (!trashDic.ContainsKey(material))
                        {
                            trashDic[material] = 0;
                        }
                        trashDic[material] += quantity;
                    }

                    if (dic["Shards"] >= 250 || dic["Fragments"] >= 250 || dic["Dragonwrath"] >= 250)
                    {
                        ready = true;
                        break;
                    }
                }
            }

            if (dic["Shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                dic["Shards"] -= 250;
            }
            else if (dic["Fragments"] >= 250 )
            {
                Console.WriteLine("Valanyr obtained!");
                dic["Fragments"] -= 250;
            }
            else if (dic["Motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                dic["Motes"] -= 250;
            }

            // TO DO
        }
    }
}
