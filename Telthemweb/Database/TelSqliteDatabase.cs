using System.Data.SQLite;
using System.Data;
using Telthemweb.DTO;

namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with SQLIte
    /// </summary>
    public class TelSqliteDatabase : TelDatabaseContext
    {
        /// <summary>
        ///  pass connection string
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>

        public IDbConnection Connection(string connectionString)
        {
            return new SQLiteConnection(connectionString);
        }

        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new SQLiteCommand(cmdText, (SQLiteConnection)conn);
        }


        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new SQLiteDataAdapter((SQLiteCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            SQLiteDataReader reader = (SQLiteDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
