using System;
using Lessons12.models;

namespace Lessons12.utils
{
    public static class EmployeeGen
    {
        private static string[] firstNames = { "Анна", "Марк", "Вася", "Олекса", "Ігор" };
        private static string[] lastNames = { "Кравченко", "Кучеренко", "Соболь", "Міняйло" };
        private static string[] positions = { "Розробник", "Тестувальник", "Дизайнер" };
        private static string[] emails = { "anna", "mark", "vasya", "oleksa", "igor" };

        private const int Min = 25000;
        private const int Max = 75000;
        private static Random rnd = new Random();

        public static string GenFirstName()
        {
            return firstNames[rnd.Next(0, firstNames.Length)];
        }

        public static string GenLastName()
        {
            return lastNames[rnd.Next(0, lastNames.Length)];
        }

        public static string GenPosition()
        {
            return positions[rnd.Next(0, positions.Length)];
        }

        public static decimal GenWages()
        {
            return rnd.Next(Min, Max);
        }

        public static string GenEmail()
        {
            return emails[rnd.Next(0, emails.Length)] + rnd.Next() % 100 + "@gmail.com";
        }

        public static Employee GenerateRandomEmployee()
        {
            string fullName = $"{GenFirstName()} {GenLastName()}";
            string position = GenPosition();
            decimal salary = GenWages();
            string email = GenEmail();

            return new Employee(fullName, position, salary, email);
        }
    }
}