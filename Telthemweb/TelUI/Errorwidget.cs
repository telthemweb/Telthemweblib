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
    public partial class Errorwidget : Form
    {
        public Errorwidget()
        {
            InitializeComponent();
        }
        public Errorwidget(Form cparent)
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

        private void Errorwidget_Load(object sender, EventArgs e)
        {

        }
    }
}
