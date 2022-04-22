using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees;

      Console.WriteLine("Would you like to fetch data from the API? [y/n]");

      if (Console.ReadLine() == "y")
      {
        employees = PeopleFetcher.GetFromAPI();
      } 
      else 
      {
        employees = PeopleFetcher.GetEmployees();
      }
        Util.PrintEmployees(employees);
        Util.MakeCSV(employees);
        Util.MakeBadges(employees);
    }
  }
}