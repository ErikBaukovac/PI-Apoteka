using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MailLib;
using PI20_014_Apoteka.Entity_Framework;
using PI20_014_Apoteka.Forms;

namespace Analiza
{
    public partial class AnalizaLijekova : ServiceBase
    {
        MainZaposlenikFrm form= new MainZaposlenikFrm();
        MailKlijent mailKlijent = new MailKlijent();
        MailSettings setting = new MailSettings();


        Timer mailTimer;
        private int getCallType;

        public AnalizaLijekova()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            mailTimer.AutoReset = true;
            mailTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            mailTimer.AutoReset = false;
            mailTimer.Enabled = false;
        }
        public void Scheduler()
        {
            InitializeComponent();
            int strTime = Convert.ToInt32(ConfigurationManager.AppSettings["callDuration"]);
            var getCallType = Convert.ToInt32(ConfigurationManager.AppSettings["CallType"]);
            if (getCallType == 1)
            {
                mailTimer = new System.Timers.Timer();
                double inter = (double)GetNextInterval();
                mailTimer.Interval = inter;
                mailTimer.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
            else
            {
                mailTimer = new System.Timers.Timer();
                mailTimer.Interval = strTime * 1000;
                mailTimer.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
        }
        private double GetNextInterval()
        {
            var timeString = ConfigurationManager.AppSettings["StartTime"];
            DateTime t = DateTime.Parse(timeString);
            TimeSpan ts = new TimeSpan();
            ts = t - System.DateTime.Now;
            if (ts.TotalMilliseconds < 0)
            {
                ts = t.AddDays(1) - System.DateTime.Now;
            }
            return ts.TotalMilliseconds;
        }
        private void SetTimer()
        {
            try
            {
                double inter = (double)GetNextInterval();
                mailTimer.Interval = inter;
                mailTimer.Start();
            }
            catch (Exception ex)
            {
            }
        }

        private void ServiceTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            var user = form.DohvatiPrijavljenog();
            var lijekovi = form.DohvatiLijekoveKojiNestaju();
            var dani = setting.BrojDanaNestanka;

            mailKlijent.AutomatskiMail("System",user.KorisnickoIme,user.Email,lijekovi,dani);

            if (getCallType == 1)
            {
                mailTimer.Stop();
                System.Threading.Thread.Sleep(1000000);
                SetTimer();
            }
        }

    }
}
