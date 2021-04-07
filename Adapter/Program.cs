using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            // Wait for user

            Console.ReadKey();
        }
    }
}
