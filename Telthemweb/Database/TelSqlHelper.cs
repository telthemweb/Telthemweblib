using System.Data;

namespace Telthemweb.Database
{
    public class TelSqlHelper
    {
        IDbConnection cn;
        TelDatabaseImplementation db = new TelDatabaseImplementation();
        public TelSqlHelper(string servertype, string connectionString)
        {
            cn = db.TestconnectDatabase(servertype, connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
