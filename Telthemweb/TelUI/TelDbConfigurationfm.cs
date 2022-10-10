using System;
using System.Windows.Forms;
using Telthemweb.Database;
using Telthemweb.Enum;
using Telthemweb.Helpers;
using Telthemweb.Services;

namespace Telthemweb.TelUI
{
    public partial class TelDbConfigurationfm : Form
    {
        public TelDbConfigurationfm()
        {
            InitializeComponent();
        }

        private void TelDbConfigurationfm_Load(object sender, EventArgs e)
        {
            cmbDatabaseType.Items.Clear();
            cmbDatabaseType.Items.Add(DatabaseType.MYSQL);
            cmbDatabaseType.Items.Add(DatabaseType.MSSQL);
            cmbDatabaseType.Items.Add(DatabaseType.POSTGRESSQL);
            cmbDatabaseType.Items.Add(DatabaseType.ORACLE);
            cmbDatabaseType.Items.Add(DatabaseType.SQLITE);
            cmbDatabaseType.Items.Add(DatabaseType.DB2);
            cmbDatabaseType.Items.Add(DatabaseType.MONOLITE);
            cmbDatabaseType.Items.Add(DatabaseType.ACCESSDB); //Microsoft Access database
            cmbDatabaseType.Items.Add(DatabaseType.HEROKU);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtServername.Text.Trim().Length == 0)
            {
                err.SetError(txtServername, "Please select Database Type");
                txtServername.Focus();
                return;
            }
            else
            {
                try
                {
                    string passwordvalue = string.Empty;
                    string dbwithoutpasswordvalue = string.Empty;

                    TelHelpersdb datmhelper = new TelHelpersdb();
                    TelProccessFormLoadingAsync loading = new TelProccessFormLoadingAsync();
                    TelSuccessDialogAsync telsucess = new TelSuccessDialogAsync();
                    if (cmbDatabaseType.Text == "MYSQL")
                    {

                        if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            passwordvalue = string.Format("server={0};database={1};userid={2};password=;SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtDatabasename.Text, txtUsername.Text);
                            dbwithoutpasswordvalue = string.Format("server={0};userid={1};password=;SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtUsername.Text);
                        }
                        else
                        {
                            passwordvalue = string.Format("server={0};database={1};userid={2};password={3};SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtDatabasename.Text, txtUsername.Text, txtPassword.Text);
                            dbwithoutpasswordvalue = string.Format("server={0};userid={1};password={2};SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtUsername.Text, txtPassword.Text);
                        }
                    }
                    else if (cmbDatabaseType.Text == "MSSQL")
                    {
                        passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", txtServername.Text, txtDatabasename.Text, txtUsername.Text, txtPassword.Text);
                        dbwithoutpasswordvalue = string.Format("Server={0};User Id={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);
                    }
                    else if (cmbDatabaseType.Text == "POSTGRESSQL")
                    {
                        passwordvalue = string.Format("Host={0};Database={1};Username={2};Password={3}", txtServername.Text, txtDatabasename.Text, txtUsername.Text, txtPassword.Text);
                        dbwithoutpasswordvalue = string.Format("Host={0};Username={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);
                    }
                    else if (cmbDatabaseType.Text == "ORACLE")
                    {
                        passwordvalue = string.Format("Server={0};Database={1};User Id={2};Password={3}", txtServername.Text, txtDatabasename.Text, txtUsername.Text, txtPassword.Text);
                        dbwithoutpasswordvalue = string.Format("Server={0};User Id={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);

                    }

                    else if (cmbDatabaseType.Text == "SQLITE")
                    {
                        MessageBox.Show("This SQLITE library is Coming soon please keep checking", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (cmbDatabaseType.Text == "DB2")
                    {
                        MessageBox.Show("This DB2 library is Coming soon please keep checking", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cmbDatabaseType.Text == "MONOLITE")
                    {
                        MessageBox.Show("This MONOLITE library is Coming soon please keep checking ", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cmbDatabaseType.Text == "ACCESSDB")
                    {
                        passwordvalue = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\{0}", txtDatabasename.Text + ".accdb");
                    }
                    loading.TelShowthem(this);
                    string connectionString = datmhelper.TelEncryptData(passwordvalue);
                    string dbconnectionString = dbwithoutpasswordvalue;
                    TelDatabaseConfiguration databaseconfig = new TelDatabaseConfiguration();
                    TelDatabaseImplementation telDatabaseConfigCL = new TelDatabaseImplementation();
                    string keyname = "constring";
                    databaseconfig.TelSaveConnectionString(datmhelper.TelEncryptData(cmbDatabaseType.Text), datmhelper.TelEncryptData(txtDatabasename.Text), keyname, connectionString, datmhelper.TelEncryptData(txtServername.Text), datmhelper.TelEncryptData(txtUsername.Text), datmhelper.TelEncryptData(txtPassword.Text));
                    telDatabaseConfigCL.CreateDatabase(txtDatabasename.Text.Trim(), cmbDatabaseType.Text, dbconnectionString);
                    //MessageBox.Show("Database Configurations been successfully saved  (*v*)!!", "TelMessage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telsucess.TelShowthem(this);
                    loading.TelClosethem();
                }
                catch (Exception ex)
                {
                    TelErrorMessageDialogAsync erl = new TelErrorMessageDialogAsync();
                    erl.TelShowthem();
                    MessageBox.Show(ex.Message);
                }
            }
    }

        private void btnCheckCon_Click(object sender, EventArgs e)
        {
            TelProccessFormLoadingAsync loading = new TelProccessFormLoadingAsync();
            TelSuccessDialogAsync telsucess = new TelSuccessDialogAsync();
            TelErrorMessageDialogAsync erl = new TelErrorMessageDialogAsync();
            try
            {
                string passwordvalue = string.Empty;
                TelHelpersdb datmhelper = new TelHelpersdb();
                if (cmbDatabaseType.Text == "MYSQL")
                {

                    if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        passwordvalue = string.Format("server={0};userid={1};password=;SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtUsername.Text);
                    }
                    else
                    {
                        passwordvalue = string.Format("server={0};userid={1};password={2};SSL Mode=None;Port=3306;Connection Timeout=600", txtServername.Text, txtUsername.Text, txtPassword.Text);
                    }
                }
                else if (cmbDatabaseType.Text == "MSSQL")
                {
                    passwordvalue = string.Format("Server={0};User Id={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);
                }
                else if (cmbDatabaseType.Text == "POSTGRESSQL")
                {
                    //SQLITE Host=localhost;Username=postgres;Password=s$cret;Database=testdb"
                    passwordvalue = string.Format("Host={0};Username={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);
                }
                else if (cmbDatabaseType.Text == "ORACLE")
                {
                    passwordvalue = string.Format("Server={0};User Id={1};Password={2}", txtServername.Text, txtUsername.Text, txtPassword.Text);
                }
                else if (cmbDatabaseType.Text == "ACCESSDB")
                {
                    passwordvalue = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\{0}", txtDatabasename.Text + ".accdb");
                }

                else if (cmbDatabaseType.Text == "SQLITE")
                {
                    MessageBox.Show("This Database library is Coming soon please keep checking ........", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbDatabaseType.Text == "HEROKU")
                {
                    MessageBox.Show("This Database library is Coming soon please keep checking ........", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                loading.TelShowthem(this);
                string connectionString = passwordvalue;
                TelSqlHelper helper = new TelSqlHelper(cmbDatabaseType.Text, connectionString);
                if (helper.IsConnection)
                    telsucess.TelShowthem(this);
                loading.TelClosethem();
                    //MessageBox.Show("Test connection succeeded.", "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                erl.TelShowthem(this);
                MessageBox.Show(ex.Message, "Telthemweb", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabaseType.Text == "SQLITE")
            {
                txtServername.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else if (cmbDatabaseType.Text == "ACCESSDB")
            {
                txtServername.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void chkPortstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPortstatus.Checked)
            {
                chkPortstatus.Enabled = true;
            }
            else
            {
                chkPortstatus.Enabled = false;
            }
        }
    }
}
