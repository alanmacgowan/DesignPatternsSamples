using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        public void Save()
        {
            Console.WriteLine("Document Saved");
        }
        public void Close()
        {
            Console.WriteLine("Document Closed");
        }
    }
}
