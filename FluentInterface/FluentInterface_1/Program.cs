using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Juan Perez")
                    .Born("02/11/1977")
                    .WorkingOn("Dev")
                    .StaysAt("Argentina");

            Console.Read();
        }
    }
}
