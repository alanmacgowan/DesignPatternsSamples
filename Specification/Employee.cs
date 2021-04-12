using System;
using System.Collections.Generic;
using System.Text;

namespace Specification
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        private int _yearOfResumption;
        public int YearOfResumption
        {
            get { return _yearOfResumption; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    _yearOfResumption = DateTime.Now.Year;
                }
                else { _yearOfResumption = value; }
            }
        }
    }
}
