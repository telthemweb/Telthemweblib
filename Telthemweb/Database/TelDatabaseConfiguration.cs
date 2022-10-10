using System;
using System.Configuration;
using TelDatabaseManger.Helper;

namespace Telthemweb.Database
{
    /// <summary>
    /// This class will help you to create database configurations in app.config
    /// </summary>
    public class TelDatabaseConfiguration
    {
        Configuration config;
        TelHelpersdb dhelper = new TelHelpersdb();
        public TelDatabaseConfiguration()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        /// <summary>
        /// Create database configuratiions in app.config
        /// </summary>
        /// <param name="dbprovider"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void TelSaveConnectionString(string dbprovider, string dbname, string key, string value, string servername, string username, string password)
        {
            ConfigurationManager.RefreshSection("telthemString");
            config.AppSettings.Settings.Add("databaseType", dbprovider);
            config.AppSettings.Settings.Add("databasename", dbname);
            config.AppSettings.Settings.Add(key, value);
            config.AppSettings.Settings.Add("servername", servername);
            config.AppSettings.Settings.Add("serverusername", username);
            if (!string.IsNullOrEmpty(password) || !string.IsNullOrWhiteSpace(password))
            {
                config.AppSettings.Settings.Add("serverpassword", dhelper.TelEncryptData(password));
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("telthemString");
        }

        public void TelSaveConnectionString(string value)
        {
            ConfigurationManager.RefreshSection("telthemString");
            config.AppSettings.Settings.Add("status", value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("telthemString");
        }

        public string GetConnectionStringCL(string key)
        {
            string result = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "0";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;

        }

        /// <summary>
        /// this will add or update configuration
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void TelAddUpdateAppSettings(string key, string value)
        {
            try
            {

                var settings = config.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        /// <summary>
        /// This will remove specified key
        /// </summary>
        /// <param name="key"></param>
        public void TelRemoveConnectionString(string key)
        {
            var settings = config.AppSettings.Settings;
            settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("telthemString");
        }


    }
}
