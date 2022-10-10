using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telthemweb.TelUI
{
    public partial class SuccessDialogdb : Form
    {
        public SuccessDialogdb()
        {
            InitializeComponent();
        }
        public SuccessDialogdb(Form cparent)
        {
            InitializeComponent();
        }

        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
