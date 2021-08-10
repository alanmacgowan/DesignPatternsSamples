using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            FluentSqlConnection.CreateConnection(config =>
                                {
                                    config.ConnectionName = "myconfig";
                                })
                               .ForServer("myserver")
                               .AndDatabase("mydb")
                               .AsUser("user")
                               .WithPassword("pass")
                               .Connect();
        }
    }
}
