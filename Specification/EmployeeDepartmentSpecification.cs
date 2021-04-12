using System;
using System.Collections.Generic;
using System.Text;

namespace Specification
{
    public class EmployeeDepartmentSpecification : IEmployeeSpecification
    {
        private readonly string _department;

        public EmployeeDepartmentSpecification(string depatrment)
        {
            _department = depatrment;
        }

        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.Department.Equals(_department);
        }
    }
}
