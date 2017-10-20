namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
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
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
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
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
