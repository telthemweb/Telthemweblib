using System.Data;
using TelDatabaseManger.Data;

namespace Telthemweb.Database
{
    public class TelSqlHelper
    {
        IDbConnection cn;
        TelDatabaseConfigCL db = new TelDatabaseConfigCL();
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
