using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public Address Address;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Address = Address.GetClone();
            return clone;
        }
    }
}
