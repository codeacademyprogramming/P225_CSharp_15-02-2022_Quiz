using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork2.Models
{
    class Company
    {
        string _name;
        public string Name 
        {
            get => _name;
            //{
            //    return _name;
            //}
            set
            {
                if (char.IsUpper(value[0]) )
                {
                    foreach (char item in value)
                    {
                        if (!char.IsLetter(item) && !char.IsDigit(item) && !char.IsWhiteSpace(item))
                        {
                            Console.WriteLine("Duzgun Name Daxil Et");
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun Name Daxil Et");
                    return;
                }
            }
        }

        public int Limit { get; set; }

        Employee[] Employees;

        public Company()
        {
            Employees = new Employee[0];

        }

        public void AddEmoployee(Employee employee)
        {
            if (Employees.Length < Limit)
            {

                Array.Resize(ref Employees, Employees.Length + 1);
                employee.No = Employees.Length;
                Employees[Employees.Length - 1] = employee;
            }
            else
            {
                Console.WriteLine("Yer Yoxdur");
            }
        }

        public Employee[] GetEmployee()
        {
            return Employees;
        }

        public Employee[] SearchEmployees(string search)
        {
            Employee[] employees = new Employee[0];

            foreach (Employee employee in Employees)
            {
                if (employee.FullName.Contains(search))
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = employee;
                }
            }

            return employees;
        }

        public void RemoveEmployee(int no)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i] != null && Employees[i].No == no)
                {
                    Employees[i] = null;
                    return;
                }
            }
        }
    }
}
