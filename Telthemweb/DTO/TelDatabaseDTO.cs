using System.Data;

namespace Telthemweb.DTO
{
    /// <summary>
    ///  Designed by Innocent Tauzeni
    ///  Harare,Zimbabwe 
    ///  Company : Telthemweb 
    ///  www.innotauzeni.co.zw
    ///  Date: 28/09/2022
    ///  
    /// Note: defining the Interface is a core part to provide all options to the Data Access Layer.
    /// </summary>
    public interface TelDatabaseContext
    {
        IDbConnection Connection(string connectionString);

        IDbCommand Command(string cmdText, IDbConnection conn);

        IDbDataAdapter DataAdapter(IDbCommand command);

        IDataReader dataReader(IDbCommand command);
    }
}
