﻿namespace Specification
{
    public class EmployeeYearSpecification : ISpecification<Employee>
    {
        private readonly int _year;

        public EmployeeYearSpecification(int year)
        {
            _year = year;
        }
        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.YearOfResumption.Equals(_year);
        }
    }
}
