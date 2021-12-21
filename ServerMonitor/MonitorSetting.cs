using System;

namespace ServerMonitor
{
    public class MonitorSetting
    {
        private const int MAX_INTERVAL = 86400;
        public const int DEFAULT_PORT = 80;
        public const int DEFAULT_INTERVAL = 180;

        public string host
        {
            get;
            private set;
        }

        public int port
        {
            get;
            private set;
        }

        public int interval
        {
            get;
            private set;
        }

        public string closeCommand
        {
            get;
            private set;
        }

        public string startCommand
        {
            get;
            private set;
        }

        public IPType ipType
        {
            get;
            private set;
        }

        public int run
        {
            get;
            private set;
        }

        public bool enable
        {
            get;
            private set;
        }

        public MonitorSetting()
        {
            host = closeCommand = startCommand = string.Empty;
            port = DEFAULT_PORT;
            interval = DEFAULT_INTERVAL;
            ipType = IPType.IPV4;
            enable = true;
        }

        public MonitorSetting(string host, int port, int interval, string closeCommand, string startCommand, int ipType, bool enable)
        {
            if (port <= 0 || port > 65535)
            {
                throw new EWException("無效的端口");
            }
            if (interval <= 0 || interval > MAX_INTERVAL)
            {
                throw new EWException("無效的掃描時間");
            }
            if (!Enum.IsDefined(typeof(IPType), ipType))
            {
                throw new EWException("無效的位址類型");
            }
            this.host = host;
            this.port = port;
            this.interval = interval;
            this.closeCommand = closeCommand;
            this.startCommand = startCommand;
            this.ipType = (IPType)ipType;
            this.enable = enable;
        }

        public void addRun()
        {
            ++run;
        }
    }
}