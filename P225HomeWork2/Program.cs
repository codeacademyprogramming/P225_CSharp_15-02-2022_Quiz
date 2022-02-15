using System;
using P225HomeWork2.Models;

namespace P225HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FullName = "FilanKes Filankesov",
                Position = "Developer",
                Salary = 5000
            };

            Employee employee1 = new Employee
            {
                FullName = "FilanKes Filankesov",
                Position = "Developer",
                Salary = 5000
            };

            Employee employee2 = new Employee
            {
                FullName = "FilanKes Filankesov",
                Position = "Developer",
                Salary = 5000
            };

            Employee employee3 = new Employee
            {
                FullName = "FilanKes Filankesov",
                Position = "Developer",
                Salary = 5000
            };

            Employee employee4 = new Employee
            {
                FullName = "FilanKes Filankesov",
                Position = "Developer",
                Salary = 5000
            };

            Company company = new Company();
            company.Name = "Code Academy";
            company.Limit = 3;

            company.AddEmoployee(employee);
            foreach (Employee item in company.GetEmployee())
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
            Console.WriteLine("------------");
            company.AddEmoployee(employee1);
            foreach (Employee item in company.GetEmployee())
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
            Console.WriteLine("------------");
            company.AddEmoployee(employee2);
            foreach (Employee item in company.GetEmployee())
            {
                Console.WriteLine($"{item.FullName} {item.No}");
            }
            Console.WriteLine("------------");
            //company.AddEmoployee(employee2);
            //foreach (Employee item in company.GetEmployee())
            //{
            //    Console.WriteLine($"{item.FullName} {item.No}");
            //}
            //Console.WriteLine("------------");
            //company.AddEmoployee(employee2);
            company.RemoveEmployee(2);
            foreach (Employee item in company.GetEmployee())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.FullName} {item.No}");
                }
            }
            Console.WriteLine("------------");
        }
    }
}
