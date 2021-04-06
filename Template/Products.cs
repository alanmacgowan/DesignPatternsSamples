using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Template
{
    class Products : DataAccessObject
    {
        public override void Select()
        {
        }

        public override void Process()
        {
            Console.WriteLine("Processing Products ---- ");

            Console.WriteLine();
        }
    }
}
