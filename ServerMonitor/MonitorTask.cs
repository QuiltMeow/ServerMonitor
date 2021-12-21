using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ThreadTimer = System.Threading.Timer;

namespace ServerMonitor
{
    public class MonitorTask
    {
        private const int SLEEP_TIME = 1000;
        private static readonly MessageForm message = Program.message;

        public static bool pause
        {
            get;
            set;
        }

        public MonitorSetting setting
        {
            get;
            private set;
        }

        public ThreadTimer timer
        {
            get;
            private set;
        }

        public object lockObject
        {
            get;
            private set;
        }

        public MonitorTask(MonitorSetting setting)
        {
            this.setting = setting;
            lockObject = new object();
        }

        private static string[] getCommand(string input)
        {
            return input.Split(new string[] {
                Environment.NewLine
            }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void start()
        {
            int interval = setting.interval * 1000;
            timer = new ThreadTimer(run, null, Timeout.Infinite, interval);
            timer.Change(interval, interval);
        }

        public void stop()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void run(object state)
        {
            if (pause)
            {
                return;
            }
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    bool success = false;
                    try
                    {
                        using (TcpClient client = new TcpClient(setting.ipType == IPType.IPV4 ? AddressFamily.InterNetwork : AddressFamily.InterNetworkV6))
                        {
                            client.Connect(setting.host, setting.port);
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        message.appendMessageLog("目標伺服器無法連線 : " + ex.Message);
                    }

                    if (!success)
                    {
                        string time = MessageForm.getCurrentTime();
                        StringBuilder console = new StringBuilder().Append("主機 : ").AppendLine(setting.host).Append("端口 : ").AppendLine(setting.port.ToString()).AppendLine();
                        try
                        {
                            string close = setting.closeCommand;
                            if (close != string.Empty)
                            {
                                console.AppendLine("===== 關閉主控台 =====").AppendLine(CommandHelper.runCommand(getCommand(close)));
                                message.appendMessageLog("伺服器關閉指令執行完畢");
                                Thread.Sleep(SLEEP_TIME);
                            }

                            string start = setting.startCommand;
                            if (start != string.Empty)
                            {
                                console.AppendLine("===== 啟動主控台 =====").AppendLine(CommandHelper.runCommand(getCommand(start)));
                                message.appendMessageLog("伺服器啟動指令執行完畢");
                                Thread.Sleep(SLEEP_TIME);
                            }
                            setting.addRun();
                            console.AppendLine("===== 統計資訊 =====").Append("伺服器已重啟 " + setting.run + " 次");
                            message.appendConsoleLog(time, console.ToString());
                        }
                        catch (Exception ex)
                        {
                            message.appendMessageLog("執行指令時發生例外狀況 : " + ex.Message);
                        }
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
        }
    }
}