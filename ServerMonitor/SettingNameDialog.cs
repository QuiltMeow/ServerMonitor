using System;
using System.Windows.Forms;

namespace ServerMonitor
{
    public partial class SettingNameDialog : Form
    {
        public string result
        {
            get;
            private set;
        }

        public SettingNameDialog()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("名稱不得為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            result = text;
            DialogResult = DialogResult.OK;
        }
    }
}