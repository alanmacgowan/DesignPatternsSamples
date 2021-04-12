using System;
using System.Collections.Generic;
using System.Text;

namespace Specification
{
    public interface IEmployeeSpecification
    {
        bool IsSatisfiedBy(Employee employee);
    }

}
