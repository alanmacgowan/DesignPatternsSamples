using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
