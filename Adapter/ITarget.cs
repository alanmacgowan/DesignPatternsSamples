using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
