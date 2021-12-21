using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ServerMonitor
{
    public partial class MessageForm : Form
    {
        private readonly StringBuilder messageLog;
        private readonly IList<KeyValuePair<string, string>> consoleLog;
        private readonly object messageLogLock, consoleLogLock;

        public MessageForm()
        {
            InitializeComponent();
            messageLog = new StringBuilder();
            consoleLog = new List<KeyValuePair<string, string>>();
            messageLogLock = new object();
            consoleLogLock = new object();
        }

        public static string getCurrentTime()
        {
            return DateTime.Now.ToString("yyyy - MM - dd tt hh : mm : ss");
        }

        public void appendMessageLog(string message)
        {
            string time = getCurrentTime();
            lock (messageLogLock)
            {
                messageLog.Append("[").Append(time).Append("] ").AppendLine(message);
            }
        }

        public void appendConsoleLog(string name, string content)
        {
            lock (consoleLogLock)
            {
                consoleLog.Add(new KeyValuePair<string, string>(name, content));
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            string data = txtLog.Text;
            if (data == string.Empty)
            {
                Clipboard.Clear();
            }
            else
            {
                Clipboard.SetText(data);
            }
        }

        private void tsmiClearMessage_Click(object sender, EventArgs e)
        {
            lock (messageLogLock)
            {
                messageLog.Clear();
            }
            updateUI();
        }

        private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void tsmiClearConsole_Click(object sender, EventArgs e)
        {
            lock (consoleLogLock)
            {
                consoleLog.Clear();
            }
            updateUI();
        }

        private string getConsoleLog(int index)
        {
            lock (consoleLogLock)
            {
                return consoleLog[index].Value;
            }
        }

        private void updateUI()
        {
            lbLog.Items.Clear();
            txtLog.Text = string.Empty;

            lbLog.Items.Add("訊息紀錄");
            lock (consoleLogLock)
            {
                foreach (KeyValuePair<string, string> data in consoleLog)
                {
                    lbLog.Items.Add(data.Key);
                }
            }
            lbLog.SelectedIndex = 0;
        }

        private void tsmiUpdateUI_Click(object sender, EventArgs e)
        {
            updateUI();
        }

        private void lbLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLog.SelectedIndex == -1)
            {
                return;
            }

            if (lbLog.SelectedIndex == 0)
            {
                lock (messageLogLock)
                {
                    txtLog.Text = messageLog.ToString();
                }
            }
            else
            {
                txtLog.Text = getConsoleLog(lbLog.SelectedIndex - 1);
            }
        }

        private void MessageForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                updateUI();
            }
        }
    }
}