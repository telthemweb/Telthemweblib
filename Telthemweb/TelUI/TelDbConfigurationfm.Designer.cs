namespace Telthemweb.TelUI
{
    partial class TelDbConfigurationfm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCheckCon = new System.Windows.Forms.Button();
            this.chkPortstatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServername = new System.Windows.Forms.TextBox();
            this.txtDatabasename = new System.Windows.Forms.TextBox();
            this.cmbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATABASE CONFIGURATIONS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 10);
            this.panel2.TabIndex = 1;
            // 
            // grpSetup
            // 
            this.grpSetup.BackColor = System.Drawing.Color.White;
            this.grpSetup.Controls.Add(this.btnCancel);
            this.grpSetup.Controls.Add(this.btnSave);
            this.grpSetup.Controls.Add(this.btnCheckCon);
            this.grpSetup.Controls.Add(this.chkPortstatus);
            this.grpSetup.Controls.Add(this.label7);
            this.grpSetup.Controls.Add(this.label6);
            this.grpSetup.Controls.Add(this.label5);
            this.grpSetup.Controls.Add(this.label4);
            this.grpSetup.Controls.Add(this.label3);
            this.grpSetup.Controls.Add(this.label2);
            this.grpSetup.Controls.Add(this.txtServerPort);
            this.grpSetup.Controls.Add(this.txtPassword);
            this.grpSetup.Controls.Add(this.txtUsername);
            this.grpSetup.Controls.Add(this.txtServername);
            this.grpSetup.Controls.Add(this.txtDatabasename);
            this.grpSetup.Controls.Add(this.cmbDatabaseType);
            this.grpSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSetup.Location = new System.Drawing.Point(12, 51);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(626, 336);
            this.grpSetup.TabIndex = 2;
            this.grpSetup.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(448, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(239, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Connection";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCheckCon
            // 
            this.btnCheckCon.BackColor = System.Drawing.Color.Green;
            this.btnCheckCon.FlatAppearance.BorderSize = 0;
            this.btnCheckCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCon.ForeColor = System.Drawing.Color.White;
            this.btnCheckCon.Location = new System.Drawing.Point(37, 274);
            this.btnCheckCon.Name = "btnCheckCon";
            this.btnCheckCon.Size = new System.Drawing.Size(196, 38);
            this.btnCheckCon.TabIndex = 13;
            this.btnCheckCon.Text = "Test Connection";
            this.btnCheckCon.UseVisualStyleBackColor = false;
            this.btnCheckCon.Click += new System.EventHandler(this.btnCheckCon_Click);
            // 
            // chkPortstatus
            // 
            this.chkPortstatus.AutoSize = true;
            this.chkPortstatus.Checked = true;
            this.chkPortstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPortstatus.Location = new System.Drawing.Point(465, 235);
            this.chkPortstatus.Name = "chkPortstatus";
            this.chkPortstatus.Size = new System.Drawing.Size(90, 24);
            this.chkPortstatus.TabIndex = 12;
            this.chkPortstatus.Text = "Add Port";
            this.chkPortstatus.UseVisualStyleBackColor = true;
            this.chkPortstatus.CheckedChanged += new System.EventHandler(this.chkPortstatus_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "PORT NUMBER#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SERVER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATABASE NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DATABASE TYPE";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPort.Location = new System.Drawing.Point(210, 229);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(249, 32);
            this.txtServerPort.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(210, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(353, 32);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(210, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(353, 32);
            this.txtUsername.TabIndex = 3;
            // 
            // txtServername
            // 
            this.txtServername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServername.Location = new System.Drawing.Point(210, 109);
            this.txtServername.Name = "txtServername";
            this.txtServername.Size = new System.Drawing.Size(353, 32);
            this.txtServername.TabIndex = 2;
            // 
            // txtDatabasename
            // 
            this.txtDatabasename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabasename.Location = new System.Drawing.Point(210, 69);
            this.txtDatabasename.Name = "txtDatabasename";
            this.txtDatabasename.Size = new System.Drawing.Size(353, 32);
            this.txtDatabasename.TabIndex = 1;
            // 
            // cmbDatabaseType
            // 
            this.cmbDatabaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabaseType.FormattingEnabled = true;
            this.cmbDatabaseType.Location = new System.Drawing.Point(210, 28);
            this.cmbDatabaseType.Name = "cmbDatabaseType";
            this.cmbDatabaseType.Size = new System.Drawing.Size(353, 33);
            this.cmbDatabaseType.TabIndex = 0;
            this.cmbDatabaseType.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(597, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "v5.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(15, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Powered by Telthemweb";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // TelDbConfigurationfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelDbConfigurationfm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelDbConfigurationfm";
            this.Load += new System.EventHandler(this.TelDbConfigurationfm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServername;
        private System.Windows.Forms.TextBox txtDatabasename;
        private System.Windows.Forms.ComboBox cmbDatabaseType;
        private System.Windows.Forms.CheckBox chkPortstatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCheckCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider err;
    }
}