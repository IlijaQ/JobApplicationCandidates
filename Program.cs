using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidateLog
{
    internal static class Program
    {
        private static IDisposable _signalRServer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartSignalRServer();
            Application.Run(new Candidates());
        }

        public static void StartSignalRServer()
        {
            string url = "http://localhost:8080";
            _signalRServer = WebApp.Start<Startup>(url);
            MessageBox.Show("Server started at " + url);
        }
    }
}
