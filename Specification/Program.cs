using System;
using System.Collections.Generic;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { FirstName = "Fidel", Department = "Maths", YearOfResumption = 2017 };
            Employee employee2 = new Employee { FirstName = "Francis", Department = "Software", YearOfResumption = 2018 };
            Employee employee3 = new Employee { FirstName = "Ahmed", Department = "Maths", YearOfResumption = 2018 };
            Employee employee4 = new Employee { FirstName = "Ebuka", Department = "Software", YearOfResumption = 2017 };

            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

            Console.WriteLine("Software Department");
            List<Employee> SoftwareEmployees = EmployeeService.GetEmployeeBy(new EmployeeDepartmentSpecification("Software"), employees);
            foreach (var employee in SoftwareEmployees)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.WriteLine();

            Console.WriteLine("Employed in 2017");
            List<Employee> EmployedIn2017 = EmployeeService.GetEmployeeBy(new EmployeeYearSpecification(2017), employees);
            foreach (var employee in EmployedIn2017)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.ReadKey();
        }
    }
}
