using System.Data;
using Telthemweb.DTO;
using Npgsql;

namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with Postgres
    /// </summary>
    public class TelPostgresDatabase : TelDatabaseContext
    {
        /// <summary>
        ///  pass this connection string
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection Connection(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new NpgsqlCommand(cmdText, (NpgsqlConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new NpgsqlDataAdapter((NpgsqlCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            NpgsqlDataReader reader = (NpgsqlDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
