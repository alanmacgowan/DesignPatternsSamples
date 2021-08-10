using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FluentInterface
{
    //based on https://www.youtube.com/watch?v=1JAdZul-aRQ
    public class FluentSqlConnection : IServerSelectionStage,
                                       IDatabaseSelectionStage,
                                       IUserSelectionStage,
                                       IPasswordSelectionStage,
                                       IConnectionInitializerStage
    {
        private string _server;
        private string _database;
        private string _user;
        private string _password;

        private FluentSqlConnection()
        {

        }

        public static IServerSelectionStage CreateConnection(Action<ConnectionConfiguration> config)
        {
            var configuration = new ConnectionConfiguration();
            config?.Invoke(configuration);
            return new FluentSqlConnection();
        }

        public IDatabaseSelectionStage ForServer(string server)
        {
            _server = server;
            return this;
        }

        public IUserSelectionStage AndDatabase(string database)
        {
            _database = database;
            return this;
        }

        public IPasswordSelectionStage AsUser(string user)
        {
            _user = user;
            return this;
        }

        public IConnectionInitializerStage WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public IDbConnection Connect()
        {
            var connection = new SqlConnection($"Server={_server};Database={_database};User Id={_user};Password={_password};");
            connection.Open();
            return connection;
        }

    }

    public class ConnectionConfiguration
    {
        public string ConnectionName { get; set; }
    }

    public interface IServerSelectionStage
    {
        public IDatabaseSelectionStage ForServer(string server);
    }

    public interface IDatabaseSelectionStage
    {
        public IUserSelectionStage AndDatabase(string database);
    }

    public interface IUserSelectionStage
    {
        public IPasswordSelectionStage AsUser(string user);
    }

    public interface IPasswordSelectionStage
    {
        public IConnectionInitializerStage WithPassword(string password);
    }

    public interface IConnectionInitializerStage
    {
        public IDbConnection Connect();
    }
}
