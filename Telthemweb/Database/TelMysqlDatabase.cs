using System;
using System.Data;
using Telthemweb.DTO;
using MySql.Data.MySqlClient;
namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with Mysql Database
    /// </summary>
    public class TelMysqlDatabase : TelDatabaseContext
    {
        public MySqlConnection conn;

        /// <summary>
        ///  connection string here
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection Connection(string connectionString)
        {
            conn = new MySqlConnection(connectionString);
            return conn;
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new MySqlDataAdapter((MySqlCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            MySqlDataReader reader = (MySqlDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
