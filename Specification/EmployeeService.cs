using System.Collections.Generic;
using System.Linq;

namespace Specification
{
    public class EmployeeService
    {
        public static List<Employee> GetEmployeeBy(ISpecification<Employee> specification, Employee[] employees)
        {
            return employees.Where(x => specification.IsSatisfiedBy(x)).ToList();
        }
    }
}
