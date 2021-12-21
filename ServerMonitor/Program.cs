using System;
using System.Windows.Forms;

namespace ServerMonitor
{
    public static class Program
    {
        public static Config config
        {
            get;
            private set;
        }

        public static MessageForm message
        {
            get;
            private set;
        }

        public static MainForm form
        {
            get;
            private set;
        }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            config = new Config();
            message = new MessageForm();
            form = new MainForm();
            Application.Run(form);
        }
    }
}