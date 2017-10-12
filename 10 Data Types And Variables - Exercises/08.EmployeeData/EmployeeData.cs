namespace _08.EmployeeData
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalIdNumber = long.Parse(Console.ReadLine());
            long employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalIdNumber}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
