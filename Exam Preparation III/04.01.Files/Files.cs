namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> filesByRoot = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] routeParams = Console.ReadLine().Split('\\');

                string root = routeParams[0];
                string[] fileWithSize = routeParams[routeParams.Length - 1].Split(';');

                string fileNameWithExtensions = fileWithSize[0];
                long fileSize = long.Parse(fileWithSize[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }

                if (!filesByRoot[root].ContainsKey(fileNameWithExtensions))
                {
                    filesByRoot[root].Add(fileNameWithExtensions, fileSize);
                }
                else
                {
                    filesByRoot[root][fileNameWithExtensions] = fileSize;
                }
            }

            string[] queryParams = Console.ReadLine().Split(' ');

            string queryExtensions = queryParams[0];
            string queryRoot = queryParams[2];

            if (filesByRoot.ContainsKey(queryRoot))
            {
                Dictionary<string, long> foundFiles = filesByRoot[queryRoot];

                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExtensions))
                    {
                        Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
