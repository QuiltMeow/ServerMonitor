using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ServerMonitor
{
    public class Config
    {
        private const string CONFIG_PATH = "config.ew";

        public IDictionary<string, MonitorSetting> setting
        {
            get;
            private set;
        }

        public Config()
        {
            setting = new Dictionary<string, MonitorSetting>();
            try
            {
                loadSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取設定檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MonitorSetting getSetting(string name)
        {
            return setting[name];
        }

        public void loadSetting()
        {
            if (!File.Exists(CONFIG_PATH))
            {
                return;
            }
            using (FileStream fs = new FileStream(CONFIG_PATH, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    IDictionary<string, MonitorSetting> raw = new Dictionary<string, MonitorSetting>();
                    while (fs.Position != fs.Length)
                    {
                        string name = br.ReadString();
                        if (string.IsNullOrWhiteSpace(name) || raw.ContainsKey(name))
                        {
                            throw new EWException("設定名稱錯誤");
                        }

                        string host = Util.removeWhiteSpace(br.ReadString());
                        int port = br.ReadInt32();
                        int interval = br.ReadInt32();
                        string closeCommand = br.ReadString();
                        string startCommand = br.ReadString();
                        int ipType = br.ReadInt32();
                        bool enable = br.ReadBoolean();
                        MonitorSetting readSetting = new MonitorSetting(host, port, interval, closeCommand, startCommand, ipType, enable);
                        raw.Add(name, readSetting);
                    }
                    setting = raw;
                }
            }
        }

        public void saveSetting()
        {
            try
            {
                using (FileStream fs = new FileStream(CONFIG_PATH, FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        foreach (KeyValuePair<string, MonitorSetting> config in setting)
                        {
                            bw.Write(config.Key);
                            MonitorSetting value = config.Value;

                            bw.Write(value.host);
                            bw.Write(value.port);
                            bw.Write(value.interval);
                            bw.Write(value.closeCommand);
                            bw.Write(value.startCommand);
                            bw.Write((int)value.ipType);
                            bw.Write(value.enable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存設定檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool canStart()
        {
            foreach (MonitorSetting data in setting.Values)
            {
                if (string.IsNullOrWhiteSpace(data.host) && data.enable)
                {
                    return false;
                }
            }
            return true;
        }
    }
}