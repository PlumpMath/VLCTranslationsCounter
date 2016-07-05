using System;
using System.Windows.Forms;

namespace VLCTranslationsCounter
{
    static class Program
    {

        private static System.Timers.Timer aTimer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            form.GetInfoFromCmd();

            // For making new count every 30 seconds
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 30000;
            aTimer.Elapsed += form.OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();

            Application.Run(form);
        }
    }
}
