using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class IBM : Stock
    {
        // Constructor

        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
