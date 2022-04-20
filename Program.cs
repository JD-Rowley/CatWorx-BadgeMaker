using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
    //   Collect user values until the value is an empty string
        while (true)
        {
            Console.WriteLine("Please enter a name: (leave empty to exit): ");
            // Get a name from the console and assign it to a variable
            string input = Console.ReadLine();
            // break if the user hits enter without typing a name
            if (input == "")
            {
                break;
            }
            // Create a new employee instance
            Employee currentEmployee = new Employee(input, "Smith");
            employees.Add(currentEmployee);
        }
        return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i].GetName());
        }
    }
    static void Main(string[] args)
    {
        List<Employee> employees = GetEmployees();
        PrintEmployees(employees);
    }
  }
}