using System;
using System.Collections.Generic;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee { FirstName = "Fidel", Department = "Maths", YearOfResumption = 2017 };
            var employee2 = new Employee { FirstName = "Francis", Department = "Software", YearOfResumption = 2018 };
            var employee3 = new Employee { FirstName = "Ahmed", Department = "Maths", YearOfResumption = 2018 };
            var employee4 = new Employee { FirstName = "Ebuka", Department = "Software", YearOfResumption = 2017 };

            var employees = new Employee[] { employee1, employee2, employee3, employee4 };

            Console.WriteLine("Software Department");
            var softwareEmployees = EmployeeService.GetEmployeeBy(new EmployeeDepartmentSpecification("Software"), employees);
            foreach (var employee in softwareEmployees)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.WriteLine();

            Console.WriteLine("Employed in 2017");
            var employedIn2017 = EmployeeService.GetEmployeeBy(new EmployeeYearSpecification(2017), employees);
            foreach (var employee in employedIn2017)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.ReadKey();
        }
    }
}
