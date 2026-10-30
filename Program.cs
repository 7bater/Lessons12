//using System;
//using System.Text;
//using static System.Console;
//using Lessons12.models;
//using Lessons12.utils;
//using Lessons12.services;
//using System.Collections.Generic;

//namespace Lessons12
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<Employee> employees = EmployeeGen.GenEmployees(5);
//            ServiceListEmployee serviceList = new ServiceListEmployee(employees);

//            string choice;
//            string menu = @"
//Оберіть операцію:
//0. Вихід
//1. Додати згенерованого співробітника
//2. Показати всіх співробітників
//3. Видалити співробітника
//";

//            do
//            {
//                Clear();
//                WriteLine(menu);
//                Write("Ваш вибір: ");
//                choice = ReadLine();
//                WriteLine();

//                switch (choice)
//                {
//                    case "1":
//                        serviceList.AddEmployee(new Employee(
//                            EmployeeGen.GenFirstName(),
//                            EmployeeGen.GenLastName(),
//                            EmployeeGen.GenPosition(),
//                            EmployeeGen.GenWages(),
//                            EmployeeGen.GenEmail()
//                        ));
//                        WriteLine("Співробітника успішно додано!");
//                        break;

//                    case "2":
//                        WriteLine("Список співробітників:");
//                        foreach (var emp in serviceList.Employees)
//                        {
//                            WriteLine($"{serviceList.Employees.IndexOf(emp)}. {emp.FirstName} {emp.LastName} | {emp.Position} | {emp.Wages} грн | {emp.Email}");
//                        }
//                        break;

//                    case "3":
//                        WriteLine("Введіть індекс співробітника для видалення:");
//                        if (int.TryParse(ReadLine(), out int index) && index >= 0 && index < serviceList.Employees.Count)
//                        {
//                            serviceList.RemoveEmployee(serviceList.Employees[index]);
//                            WriteLine("Співробітника видалено.");
//                        }
//                        else
//                        {
//                            WriteLine("Невірний індекс.");
//                        }
//                        break;

//                    case "0":
//                        WriteLine("Вихід...");
//                        break;

//                    default:
//                        WriteLine("Невірний вибір.");
//                        break;
//                }

//                if (choice != "0")
//                {
//                    WriteLine("\nНатисніть клавішу для продовження...");
//                    ReadKey();
//                }

//            } while (choice != "0");
//        }
//    }
//}

//ex2
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Lessons12.models;
using Lessons12.utils;
using Lessons12.services;

namespace Lessons12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            LinkedList<Book> bookList = new LinkedList<Book>();
            for (int i = 0; i < 3; i++)
            {
                bookList.AddLast(BookGen.GenerateRandomBook());
            }

            ServiceLinkedListBook service = new ServiceLinkedListBook(bookList);

            string choice;
            string menu = @"
Оберіть операцію:
0. Вихід
1. Показати всі книги
2. Додати книгу в кінець
3. Додати книгу на початок
4. Видалити першу книгу
5. Видалити останню книгу
";

            do
            {
                Clear();
                WriteLine(menu);
                Write("Ваш вибір: ");
                choice = ReadLine();
                WriteLine();

                switch (choice)
                {
                    case "1":
                        WriteLine("Список книг:");
                        int index = 0;
                        foreach (var book in service.Books)
                        {
                            WriteLine($"{index++}. {book.Title} | {book.Author} | {book.Genre} | {book.Year}");
                        }
                        break;

                    case "2":
                        service.AddLast(new Book(
                            BookGen.GenTitle(),
                            BookGen.GenAuthor(),
                            BookGen.GenGenre(),
                            BookGen.GenYear()
                        ));
                        WriteLine("Книгу додано в кінець!");
                        break;

                    case "3":
                        service.AddFirst(new Book(
                            BookGen.GenTitle(),
                            BookGen.GenAuthor(),
                            BookGen.GenGenre(),
                            BookGen.GenYear()
                        ));
                        WriteLine("Книгу додано на початок!");
                        break;

                    case "4":
                        service.RemoveFirst();
                        WriteLine("Першу книгу видалено.");
                        break;

                    case "5":
                        service.RemoveLast();
                        WriteLine("Останню книгу видалено.");
                        break;

                    case "0":
                        WriteLine("Вихід...");
                        break;

                    default:
                        WriteLine("Невірний вибір.");
                        break;
                }

                if (choice != "0")
                {
                    WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                    ReadKey();
                }

            } while (choice != "0");
        }
    }
}