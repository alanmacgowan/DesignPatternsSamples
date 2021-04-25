using System;
using System.Collections.Generic;
using System.Text;

namespace Specification
{
    public interface ISpecification<T> where T : class
    {
        bool IsSatisfiedBy(T entity);
    }

}
