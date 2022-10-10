using System.Configuration;
using System;
using System.Data;
using TelDatabaseManger.Helper;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Telthemweb.Database
{
    // <summary>
    /// This class will cater Database activities
    /// </summary>
    public class TelDatabaseImplementation
    {
        IDbConnection conn;
        IDbCommand cmd;
        IDataAdapter da;
        TelHelpersdb datmhelper = new TelHelpersdb();
        TelMssqlDatabase telMssqlDatabase = new TelMssqlDatabase();
        TelMysqlDatabase telMysqlDatabase = new TelMysqlDatabase();
        TelPostgresDatabase telPostgresDatabase = new TelPostgresDatabase();
        TelOracleDatabase telOracleDatabase = new TelOracleDatabase();
        TelSqliteDatabase telSqliteDatabase = new TelSqliteDatabase();
        TelAccessDatabase telAccessDatabase = new TelAccessDatabase();
        TelDatabaseConfiguration telDatabaseConfiguration =new TelDatabaseConfiguration();

        /// <summary>
        /// This will test server availability
        /// </summary>
        /// <param name="servertype"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public IDbConnection TestconnectDatabase(string servertype, string connectionString)
        {
            if (conn == null)
            {
                if (servertype == "MYSQL")
                {
                    if (conn == null)
                    {
                        conn = telMysqlDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "MSSQL")
                {
                    if (conn == null)
                    {
                        conn = telMssqlDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "POSTGRESSQL") //Npgsql
                {

                    if (conn == null)
                    {
                        conn = telPostgresDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }

                else if (servertype == "ORACLE")
                {

                    if (conn == null)
                    {
                        conn = telOracleDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "SQLITE")
                {

                    if (conn == null)
                    {
                        conn = telSqliteDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "ACCESSDB")
                {

                    if (conn == null)
                    {
                        conn = telAccessDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
                else if (servertype == "HEROKU")
                {

                    if (conn == null)
                    {
                        conn = telMysqlDatabase.Connection(connectionString);
                    }
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                }
            }

            return conn;
        }



        /// <summary>
        /// check the database and server connection: if the connection is there this will return connection string
        /// </summary>
        /// <returns></returns>
        public IDbConnection TelDatabaseConnection()
        {
            var cstr = datmhelper.TelDecryptData(telDatabaseConfiguration.GetConnectionStringCL("constring"));
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {
                if (conn == null)
                {
                    conn = telMssqlDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

            }
            else if (DbProviderPlugin == "MSSQL")
            {
                if (conn == null)
                {
                    conn = telMssqlDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            else if (DbProviderPlugin == "POSTGRESSQL") //Npgsql
            {

                if (conn == null)
                {
                    conn = telPostgresDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }

            else if (DbProviderPlugin == "ORACLE") //Npgsql
            {

                if (conn == null)
                {
                    conn = telOracleDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            else if (DbProviderPlugin == "SQLITE")
            {

                if (conn == null)
                {
                    conn = telSqliteDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            else if (DbProviderPlugin == "ACCESSDB")
            {

                if (conn == null)
                {
                    conn = telSqliteDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            else if (DbProviderPlugin == "HEROKU")
            {

                if (conn == null)
                {
                    conn = telMysqlDatabase.Connection(cstr);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            return conn;
        }



        /// <summary>
        ///  Create Company database Dynamically  : From Company Name
        /// </summary>
        /// <param name="dbname"></param>
        /// <param name="servertype"></param>
        /// <param name="connectionString"></param>
        public void CreateDatabase(string dbname, string servertype, string connectionString)
        {
            try
            {
                string query = "CREATE DATABASE " + dbname;
                if (servertype == "MYSQL")
                {
                    cmd = telMysqlDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "MSSQL")
                {
                    cmd = telMssqlDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "POSTGRESSQL")
                {
                    cmd = telPostgresDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }

                else if (servertype == "ORACLE")
                {
                    cmd = telOracleDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "SQLITE")
                {
                    cmd = telSqliteDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                else if (servertype == "ACCESSDB")
                {
                    cmd = telAccessDatabase.Command(query, TestconnectDatabase(servertype, connectionString));
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Importing All stored procedures
        /// </summary>
        /// <param name="query"></param>
        public void TelProgrammableProcedureDb(string query)
        {
            try
            {
                cmd = TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// add all views to the database
        /// </summary>
        /// <param name="query"></param>
        public void TelProgrammableView(string query)
        {
            try
            {
                cmd = TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// database table comands which will take sql
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IDbCommand TelCommand(string query)
        {
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {
                cmd = telMysqlDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "MSSQL")
            {
                cmd = telMssqlDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "POSTGRESSQL")
            {
                cmd = telPostgresDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "ORACLE")
            {
                cmd = telOracleDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "ACCESSDB")
            {
                cmd = telAccessDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "SQLITE")
            {
                cmd = telSqliteDatabase.Command(query, TelDatabaseConnection());
            }
            else if (DbProviderPlugin == "HEROKU")
            {
                cmd = telMysqlDatabase.Command(query, TelDatabaseConnection());
            }
            return cmd;
        }




        /// <summary>
        /// dataadpter
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        public IDataAdapter TeldataAdapter(IDbCommand command)
        {
            string DbProviderPlugin = datmhelper.TelDecryptData(ConfigurationManager.AppSettings["databaseType"]);
            if (DbProviderPlugin == "MYSQL")
            {

                da = telMysqlDatabase.DataAdapter((MySqlCommand)command);
            }
            else if (DbProviderPlugin == "MSSQL")
            {
                da = telMssqlDatabase.DataAdapter((SqlCommand)command);
            }
            else if (DbProviderPlugin == "POSTGRESSQL")
            {
                da = telPostgresDatabase.DataAdapter((NpgsqlCommand)command);
            }
            else if (DbProviderPlugin == "ORACLE")
            {
                da = telOracleDatabase.DataAdapter((OracleCommand)command);
            }
            else if (DbProviderPlugin == "ACCESSDB")
            {
                da = telAccessDatabase.DataAdapter((OleDbCommand)command);
            }
            else if (DbProviderPlugin == "SQLITE")
            {
                da = telSqliteDatabase.DataAdapter((SQLiteCommand)command);
            }
            else if (DbProviderPlugin == "HEROKU")
            {
                da = telMysqlDatabase.DataAdapter((SQLiteCommand)command);
            }
            return da;
        }















    }
}
