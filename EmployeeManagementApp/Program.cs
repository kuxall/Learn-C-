// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace EmployeeManagementApp
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Employee Management APP ");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ViewEmployee();
                        break;
                    case "3":
                        UpdateEmployee();
                        break;
                    case "4":
                        DeleteEmployee();
                        break;
                    case "5":
                        Environment.Exit(0);
                        Console.WriteLine("Thank you for using Employee Management App");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Employee employee = new Employee();
            employee.EmployeeId = nextId++;

            Console.Write("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Designation:  ");
            employee.EmployeeDesignation = Console.ReadLine();

            employees.Add(employee);
            Console.WriteLine("Employee added successfully");
        }

        static void ViewEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No Employee found");
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine("Employee Id: {0}", employee.EmployeeId);
                    Console.WriteLine("Employee Name: {0}", employee.EmployeeName);
                    Console.WriteLine("Employee Designation: {0}", employee.EmployeeDesignation);
                    Console.WriteLine("-------------------------------");
                }
            }
        }

        static void UpdateEmployee()
        {
            Console.Write("Enter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee employee = employees.Find(e => e.EmployeeId == id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.Write("Enter Employee Name: ");
                employee.EmployeeName = Console.ReadLine();

                Console.Write("Enter Employee Designation: ");
                employee.EmployeeDesignation = Console.ReadLine();

                Console.WriteLine("Employee updated successfully");
            }
        }

        static void DeleteEmployee()
        {
            Console.Write("Enter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee employee = employees.Find(e => e.EmployeeId == id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully");
            }
        }
    }
}

