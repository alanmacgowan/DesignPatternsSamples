using System;
using System.Collections.Generic;
using System.Text;

namespace Specification
{
    public class EmployeeService
    {
        public static List<Employee> GetEmployeeBy(ISpecification<Employee> specification, Employee[] employees)
        {
            List<Employee> NeededEmployees = new List<Employee>();


            foreach (Employee employee in employees)
            {
                if (specification.IsSatisfiedBy(employee))
                {
                    NeededEmployees.Add(employee);
                }
            }
            return NeededEmployees;
        }
    }
}
