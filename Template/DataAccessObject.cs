using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Template
{
    abstract class DataAccessObject
    {
        protected string connectionString;

        public virtual void Connect()
        {
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
