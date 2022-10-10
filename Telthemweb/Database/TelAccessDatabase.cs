using System.Data.OleDb;
using System.Data;
using Telthemweb.DTO;

namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with Microsoft SAccess Database
    /// </summary>
    public class TelAccessDatabase : TelDatabaseContext
    {
        /// <summary>
        /// Pass access database connection string here
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection Connection(string connectionString)
        {
            return new OleDbConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new OleDbCommand(cmdText, (OleDbConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new OleDbDataAdapter((OleDbCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            OleDbDataReader reader = (OleDbDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
