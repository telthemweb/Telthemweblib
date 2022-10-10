using Oracle.ManagedDataAccess.Client;
using System.Data;
using Telthemweb.DTO;

namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with Oracle Database
    /// </summary>
    public class TelOracleDatabase: TelDatabaseContext
    {
        /// <summary>
        ///  pass connection string here
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection Connection(string connectionString)
        {
            return new OracleConnection(connectionString);
        }
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new OracleCommand(cmdText, (OracleConnection)conn);
        }

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new OracleDataAdapter((OracleCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            OracleDataReader reader = (OracleDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
