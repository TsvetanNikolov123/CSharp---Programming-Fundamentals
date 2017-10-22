namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Town
    {
        public Town(string name, int seatsCount)
        {
            this.Name = name;
            this.SeatsCount = seatsCount;
            this.Students = new List<Student>();
        }

        public string Name { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> Students { get; set; }
    }

    public class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }

    public class Student
    {
        public Student(string name, string email, DateTime date)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = date;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    public class StudentGroups
    {
        public static void Main()
        {
            var towns = GetTownData();
            var groups = GetGroups(towns);
            PrintResults(groups);
        }

        private static List<Group> GetGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {

                IEnumerable<Student> studs = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(z => z.Name).ThenBy(y => y.Email);

                while (studs.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = studs.Take(group.Town.SeatsCount).ToList();
                    studs = studs.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }

        private static List<Town> GetTownData()
        {
            var towns = new List<Town>();
            var inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    var input = Regex
                        .Split(inputLine, @"\s=>\s")
                        .ToList();

                    var townName = input[0];
                    var seats = int.Parse(Regex.Match(input[1], @"\d+").Value);
                    var town = new Town(townName, seats);
                    towns.Add(town);
                }
                else
                {
                    var input = inputLine
                        .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList();

                    var name = input[0];
                    var email = input[1];
                    var date = DateTime.ParseExact(input[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var student = new Student(name, email, date);

                    towns
                        .LastOrDefault()
                        .Students
                        .Add(student);
                }
            }

            return towns;
        }

        private static void PrintResults(List<Group> groups)
        {
            var townsCount = groups
                .Select(x => x.Town)
                .Distinct()
                .Count();

            Console.WriteLine($"Created {groups.Count} groups in {townsCount} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");

                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }

        }
    }
}