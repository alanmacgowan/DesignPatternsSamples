﻿namespace Specification
{
    public class EmployeeDepartmentSpecification : ISpecification<Employee>
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
