using System.Data;
using System.Data.SqlClient;
using Telthemweb.DTO;

namespace Telthemweb.Database
{
    /// <summary>
    /// Developer Innocent Tauzeni
    /// Zimbabwe
    /// This class will allow to interact with Microsoft Sql server
    /// </summary>
    public class TelMssqlDatabase : TelDatabaseContext
    {
        /// <summary>
        /// You pass connection string from app.config
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection Connection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Query command will be executed here
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new SqlCommand(cmdText, (SqlConnection)conn);
        }


        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        public IDataReader dataReader(IDbCommand command)
        {
            SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
            return reader;
        }
    }
}
