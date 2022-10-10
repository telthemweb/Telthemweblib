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
    public partial class MessageBoxdata : Form
    {
        public MessageBoxdata()
        {
            InitializeComponent();
        }
        public MessageBoxdata(Form cparent)
        {
            InitializeComponent();
        }

        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void MessageBoxdata_Load(object sender, EventArgs e)
        {

        }
    }
}
