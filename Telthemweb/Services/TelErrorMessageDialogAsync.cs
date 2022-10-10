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
    /// Developed by Innocent Tauzeni
    ///  This will load progress loading form
    ///  04/09/2022
    ///  Hatcliffe, Harare
    /// </summary>
    public class TelErrorMessageDialogAsync
    {
        Errorwidget loadingForm;
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
            loadingForm = new Errorwidget();
            loadingForm.ShowDialog();
        }

        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loadingForm = new Errorwidget(Cparent);
            loadingForm.ShowDialog();
        }
    }
}
