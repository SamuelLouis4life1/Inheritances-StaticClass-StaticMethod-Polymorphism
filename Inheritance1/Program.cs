﻿using System;
using System.Collections.Generic;
using Inheritance1.Entities;
using System.Globalization;


/// <summary>
/// A company has its own and outsourced employees. For each employee, you want to record name, hours worked, and hourly value. Outsourced employees still have an additional expense.
/// The employee payment corresponds to the hourly rate multiplied by hours worked, and outsourced employees still receive a bonus corresponding to 110% of their additional expenditure.
/// It is a program to read the data of N employees (N provided by the user) and store them in a list. After reading all data, show name and payment of each employee in the order in which they were typed.
/// </summary>

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i<=N; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (Y/N)");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHours, addicionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(name, hours, valuePerHours));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee employee in employeeList)
                {
                    Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2"),  CultureInfo.InvariantCulture);
                }
                Console.ReadLine();
            }
        }
    }
}
