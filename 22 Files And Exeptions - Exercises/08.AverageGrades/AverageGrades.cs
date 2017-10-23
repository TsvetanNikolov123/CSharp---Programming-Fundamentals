namespace _08.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double AverageGrade => this.Grades.Average();
    }

    public class AverageGrades
    {
        public static void Main()
        {
            string[] inputLine = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(inputLine[0]);
            for (int i = 0; i < studentsCount; i++)
            {
                string[] tokens = inputLine[i + 1].Split();
                string name = tokens[0];
                double[] grades = tokens.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student()
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(student);
            }

            students = students
                            .Where(a => a.AverageGrade >= 5.0)
                            .OrderBy(s => s.Name)
                            .ThenByDescending(a => a.AverageGrade)
                            .ToList();

            foreach (Student student in students)
            {
                string result = $"{student.Name} -> {student.AverageGrade:F2}";
                File.AppendAllText("../../Output.txt", result + Environment.NewLine);
            }
        }
    }
}
