using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ServerMonitor
{
    public partial class MainForm : Form
    {
        private const int TOOL_TIP_SHOW_DURATION = 5000;

        private static readonly Config config = Program.config;
        private static readonly MessageForm message = Program.message;
        private readonly IList<MonitorTask> monitorTaskList;

        public MainForm()
        {
            InitializeComponent();
            monitorTaskList = new List<MonitorTask>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SettingNameDialog dialog = new SettingNameDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (config.setting.ContainsKey(dialog.result))
                    {
                        MessageBox.Show("設定名稱已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    config.setting.Add(dialog.result, new MonitorSetting());
                    config.saveSetting();
                    updateSettingUI(dialog.result);
                }
            }
        }

        private void updateSettingUI(string select = null)
        {
            lbSettingCollection.Items.Clear();
            foreach (string name in config.setting.Keys)
            {
                lbSettingCollection.Items.Add(name);
            }
            if (select != null)
            {
                lbSettingCollection.SelectedItem = select;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lbSettingCollection.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("請指定設定名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SettingNameDialog dialog = new SettingNameDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (config.setting.ContainsKey(dialog.result))
                    {
                        MessageBox.Show("設定名稱已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string origin = lbSettingCollection.SelectedItem.ToString();
                    MonitorSetting current = config.getSetting(origin);
                    config.setting.Remove(origin);
                    config.setting.Add(dialog.result, current);
                    config.saveSetting();
                    updateSettingUI(dialog.result);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbSettingCollection.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("請選擇設定", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            config.setting.Remove(lbSettingCollection.SelectedItem.ToString());
            config.saveSetting();
            updateSettingUI();
            loadParameterControl(null);
        }

        private MonitorSetting generateSetting()
        {
            return new MonitorSetting(txtHost.Text, Convert.ToInt32(numPort.Value), Convert.ToInt32(numInterval.Value), txtCloseCommand.Text, txtStartCommand.Text, rbIPv4.Checked ? (int)IPType.IPV4 : (int)IPType.IPV6, chkEnable.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtHost.Text = Util.removeWhiteSpace(txtHost.Text);
            try
            {
                MonitorSetting current = generateSetting();
                string name = lbSettingCollection.SelectedItem.ToString();

                config.setting[name] = current;
                config.saveSetting();
                loadParameter(name);
                MessageBox.Show("設定儲存完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法儲存設定 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (monitorTaskList.Count <= 0)
            {
                if (config.setting.Count <= 0)
                {
                    MessageBox.Show("找不到任何設定", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!config.canStart())
                {
                    MessageBox.Show("設定參數錯誤 無法執行", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (MonitorSetting setting in config.setting.Values)
                {
                    if (setting.enable)
                    {
                        MonitorTask task = new MonitorTask(setting);
                        task.start();
                        monitorTaskList.Add(task);
                    }
                }
                if (monitorTaskList.Count <= 0)
                {
                    MessageBox.Show("沒有任何可執行項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                enableSettingControl(false);
                enableParameterControl(false);
                if (lbSettingCollection.SelectedIndex >= 0)
                {
                    loadParameter(lbSettingCollection.SelectedItem.ToString());
                }

                message.appendMessageLog("開始運作");
                btnStart.Text = "停止監視";
            }
            else
            {
                foreach (MonitorTask task in monitorTaskList)
                {
                    task.stop();
                }
                monitorTaskList.Clear();
                message.appendMessageLog("停止運作");
                btnStart.Text = "開始監視";

                enableParameterControl(true);
                enableSettingControl(true);
                if (lbSettingCollection.SelectedIndex == -1)
                {
                    lbSettingCollection.SelectedIndex = 0;
                }
            }
        }

        private void enableSettingControl(bool enable)
        {
            lbSettingCollection.Enabled = btnAdd.Enabled = btnEdit.Enabled
                = btnRemove.Enabled = enable;
        }

        private void enableParameterControl(bool enable)
        {
            chkEnable.Enabled = rbIPv4.Enabled = rbIPv6.Enabled
                = txtHost.Enabled = numPort.Enabled = numInterval.Enabled
                = btnTip.Enabled = txtStartCommand.Enabled = txtCloseCommand.Enabled
                = btnSave.Enabled = enable;
        }

        private void loadParameter(string name)
        {
            MonitorSetting current = config.getSetting(name);
            chkEnable.Checked = current.enable;
            txtHost.Text = current.host;
            if (current.ipType == IPType.IPV4)
            {
                rbIPv4.Checked = true;
            }
            else
            {
                rbIPv6.Checked = true;
            }

            Util.forceUpdateNumericUpDownValue(numPort, current.port);
            Util.forceUpdateNumericUpDownValue(numInterval, current.interval);
            txtStartCommand.Text = current.startCommand;
            txtCloseCommand.Text = current.closeCommand;
        }

        private void loadParameterControl(string name)
        {
            if (name == null)
            {
                enableParameterControl(false);
                chkEnable.Checked = false;
                rbIPv4.Checked = true;
                txtHost.Text = txtStartCommand.Text = txtCloseCommand.Text = string.Empty;
                Util.forceUpdateNumericUpDownValue(numPort, MonitorSetting.DEFAULT_PORT);
                Util.forceUpdateNumericUpDownValue(numInterval, MonitorSetting.DEFAULT_INTERVAL);
            }
            else
            {
                loadParameter(name);
                enableParameterControl(true);
            }
        }

        private void lbSettingCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadParameterControl(lbSettingCollection.SelectedIndex == -1 ? null : lbSettingCollection.SelectedItem.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateSettingUI();
            if (lbSettingCollection.Items.Count > 0)
            {
                lbSettingCollection.SelectedIndex = 0;
            }
        }

        private void btnMessageLog_Click(object sender, EventArgs e)
        {
            Program.message.Show();
        }

        private void lbSettingCollection_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }
            Rectangle bound = new Rectangle(e.Bounds.Location, new Size(e.Bounds.Width, lbSettingCollection.ItemHeight));
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, bound, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.Yellow);
            }
            e.DrawBackground();
            e.Graphics.DrawString(lbSettingCollection.Items[e.Index].ToString(), e.Font, Brushes.Black, bound, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("啟動指令不應包含阻塞與等待", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                niIcon.ShowBalloonTip(TOOL_TIP_SHOW_DURATION);
            }
        }

        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void tsmiPause_Click(object sender, EventArgs e)
        {
            tsmiPause.Checked = !tsmiPause.Checked;
            MonitorTask.pause = tsmiPause.Checked;
        }

        private void exit()
        {
            niIcon.Visible = false;
            Environment.Exit(Environment.ExitCode);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit();
        }

        private void niIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
    }
}