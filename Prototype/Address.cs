using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Address
    {
        public string address { get; set; }
        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
