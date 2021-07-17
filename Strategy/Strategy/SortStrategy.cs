using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
