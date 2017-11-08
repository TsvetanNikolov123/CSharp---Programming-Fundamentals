namespace _04.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class AnonymousCache
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> dic =
                new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, Dictionary<string, long>> dicTemp =
                new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }

                string[] tokens = input.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 1)
                {
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    string dataSets = tokens[2];

                    if (!dic.ContainsKey(dataSets))
                    {
                        if (!dicTemp.ContainsKey(dataSets))
                        {
                            dicTemp[dataSets] = new Dictionary<string, long>();
                        }
                        dicTemp[dataSets][dataKey] = dataSize;
                    }

                    if (dic.ContainsKey(dataSets))
                    {
                        dic[dataSets][dataKey] = dataSize;
                    }
                }
                else
                {
                    string dataSet = tokens[0];
                    if (!dic.ContainsKey(dataSet))
                    {
                        dic[dataSet] = new Dictionary<string, long>();
                        if (dicTemp.ContainsKey(dataSet))
                        {
                            foreach (var dataset in dicTemp[dataSet])
                            {

                                dic[dataSet][dataset.Key] = dataset.Value;
                            }
                        }
                    }

                }
            }
            if (dic.Count == 0)
            {
                return;
            }
            // dic.Select(d => d.Value.Values.Sum())

            string dicKeyTemp = "";
            decimal dicSumTemp = 0m;
            List<string> result = new List<string>();


            foreach (var d in dic)
            {
                string str = d.Key;
                var strDic = d.Value;

                if ((decimal)d.Value.Values.Sum() > dicSumTemp)
                {
                    result.Clear();
                    dicSumTemp = d.Value.Values.Sum();
                    dicKeyTemp = d.Key;
                    foreach (var s in d.Value)
                    {
                        string key = s.Key;
                        result.Add(key);
                    }
                }

            }

            Console.WriteLine($"Data Set: {dicKeyTemp}, Total Size: {dicSumTemp}");
            foreach (var item in result)
            {
                Console.WriteLine($"$.{item}");
            }

        }
    }
}