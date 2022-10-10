
using System;
using System.Data;
using System.Windows.Forms;
using Telthemweb.Database;
using Telthemweb.Helpers;
using Telthemweb.Services;
using Telthemweb.TelUI;

namespace Telthemweb
{
    /// <summary>
    ///   ALL DATABASE TABLE TRANSACTION
    ///   Author:  Innocent Tauzeni
    ///   06/09/2022
    ///   HATCLIFFE
    ///   One day i will conquer the world: God have mercy on me!
    ///   My vision will not die but produce quality results that will help whole world
    ///   with God nothing is impossible
    ///   Telthemweb to the world
    /// </summary>
    /// <returns></returns>
    /// 
    public class TelthemwebLib
    {

        TelDatabaseImplementation telDatabaseImplementation = new TelDatabaseImplementation();
        IDbCommand cmd;
        IDbDataAdapter da;
        TelHelpersdb datmhelper = new TelHelpersdb();
        TelErrorMessageDialogAsync errorm = new TelErrorMessageDialogAsync();
        TelProccessFormLoadingAsync loadingap= new TelProccessFormLoadingAsync();
        TelSuccessDialogAsync succesap =new TelSuccessDialogAsync();

        /// <summary>
        /// Retrieve all records or a record from database 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable TelRetrieve(string query)
        {
            try
            {
                cmd = telDatabaseImplementation.TelCommand(query);
                IDataReader dataR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataR);
                return dt;
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// retrieve data using stored procedure 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable TelRetrieveStoredProcedureData(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = telDatabaseImplementation.TelCommand(query);
                IDataReader dataR = cmd.ExecuteReader();
                cmd.CommandType = CommandType.StoredProcedure;
                dt.Load(dataR);
                return dt;
            }
            catch
            {
                return null;
            }

        }


        /// <summary>
        /// Add all stored proceducers in database
        /// </summary>
        /// <param name="query"></param>
        public void TelRunStoredProcedure(string query)
        {
            try
            {
                cmd = telDatabaseImplementation.TelCommand(query);
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
        /// run all views
        /// </summary>
        /// <param name="query"></param>
        public void TelRunAllViewDb(string query)
        {
            try
            {
                cmd = telDatabaseImplementation.TelCommand(query);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Run all functions
        /// </summary>
        /// <param name="query"></param>
        public void TelRunFunctions(string query)
        {
            try
            {
                cmd = telDatabaseImplementation.TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Run all triggers
        /// </summary>
        /// <param name="query"></param>
        public void TelRunTriggers(string query)
        {
            try
            {
                cmd = telDatabaseImplementation.TelCommand(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Insert new record into the table
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelInsert(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseImplementation.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }


        /// <summary>
        /// Insert new record using stored procedure
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        public bool TelInsertStoredProcedure(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseImplementation.TelCommand(query);
                cmd.CommandType = CommandType.StoredProcedure;
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }



        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelUpdate(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseImplementation.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelDelete(string query)
        {
            try
            {
                int numRows = 0;
                cmd = telDatabaseImplementation.TelCommand(query);
                numRows = cmd.ExecuteNonQuery();
                if (numRows > 0)
                { return true; }
                else
                { return false; }
            }
            catch
            { return false; }

        }

        /// <summary>
        /// this will check if record exist in the database
        /// return true if the record is there
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool TelCheckExist(string query)
        {
            DataTable isexist = TelRetrieve(query);
            if (isexist.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /*
         |=========================================================
         |               OTHER FUNCTIONS
         |=========================================================
         */
        /// <summary>
        /// save config settings
        /// Set database status to true
        /// </summary>
        public void TelUpdateDatabaseConfigStatus()
        {
             TelDatabaseConfiguration databaseconfig = new TelDatabaseConfiguration();
            databaseconfig.TelSaveConnectionString("true");

        }


        /// <summary>
        /// This will open the configuration form 
        /// </summary>
        /// <param name="trigger"> boolean either true or false</param>
        public void telshowConfigurationForm(bool trigger)
        {
            if (trigger == true)
            {
                TelDbConfigurationfm telform = new TelDbConfigurationfm();
                telform.ShowDialog();
            }
        }

        /// <summary>
        /// To encryp data
        /// </summary>
        /// <param name="encryption"></param>
        /// <returns></returns>
        public string TelEncriptHash(string encryption)
        {
            return datmhelper.TelEncryptData(encryption);
        }


        /// <summary>
        /// to decrypt data
        /// </summary>
        /// <param name="encryption"></param>
        /// <returns></returns>
        public string TelDecriptHash(string encryption)
        {
            return datmhelper.TelDecryptData(encryption);
        }








    }
}
