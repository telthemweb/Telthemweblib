using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telthemweb.TelUI;

namespace Telthemweb.Services
{
    /// <summary>
    ///  This will load progress loading form
    ///  04/09/2022
    ///  Hatcliffe, Harare
    /// </summary>
    public class TelSuccessDialogAsync
    {
        SuccessDialogdb loadingForm;
        Thread loadthread;


        public void TelShowthem()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }

        public void TelShowthem(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(parent);
        }

        public void TelShowthem(string message)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(message);
        }

        public void TelClosethem()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new ThreadStart(loadingForm.CloseLoadingForm));
                loadingForm = null;
                loadthread = null;
            }
        }

        private void LoadingProcessEx()
        {
            loadingForm = new SuccessDialogdb();
            loadingForm.ShowDialog();
        }

        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loadingForm = new SuccessDialogdb(Cparent);
            loadingForm.ShowDialog();
        }

    }
}
