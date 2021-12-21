namespace ServerMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbParameter = new System.Windows.Forms.GroupBox();
            this.btnTip = new System.Windows.Forms.Button();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.rbIPv6 = new System.Windows.Forms.RadioButton();
            this.rbIPv4 = new System.Windows.Forms.RadioButton();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.labelIntervalUnit = new System.Windows.Forms.Label();
            this.txtCloseCommand = new System.Windows.Forms.TextBox();
            this.labelCloseCommand = new System.Windows.Forms.Label();
            this.txtStartCommand = new System.Windows.Forms.TextBox();
            this.labelStartCommand = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbSettingCollection = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbSettingCollection = new System.Windows.Forms.ListBox();
            this.niIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMessageLog = new System.Windows.Forms.Button();
            this.gbParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.gbSettingCollection.SuspendLayout();
            this.cmsRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(140, 426);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "刪除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbParameter
            // 
            this.gbParameter.Controls.Add(this.btnTip);
            this.gbParameter.Controls.Add(this.chkEnable);
            this.gbParameter.Controls.Add(this.rbIPv6);
            this.gbParameter.Controls.Add(this.rbIPv4);
            this.gbParameter.Controls.Add(this.numInterval);
            this.gbParameter.Controls.Add(this.numPort);
            this.gbParameter.Controls.Add(this.labelIntervalUnit);
            this.gbParameter.Controls.Add(this.txtCloseCommand);
            this.gbParameter.Controls.Add(this.labelCloseCommand);
            this.gbParameter.Controls.Add(this.txtStartCommand);
            this.gbParameter.Controls.Add(this.labelStartCommand);
            this.gbParameter.Controls.Add(this.labelInterval);
            this.gbParameter.Controls.Add(this.labelPort);
            this.gbParameter.Controls.Add(this.txtHost);
            this.gbParameter.Controls.Add(this.btnSave);
            this.gbParameter.Controls.Add(this.labelHost);
            this.gbParameter.Location = new System.Drawing.Point(235, 12);
            this.gbParameter.Name = "gbParameter";
            this.gbParameter.Size = new System.Drawing.Size(435, 425);
            this.gbParameter.TabIndex = 1;
            this.gbParameter.TabStop = false;
            this.gbParameter.Text = "參數";
            // 
            // btnTip
            // 
            this.btnTip.Location = new System.Drawing.Point(48, 235);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(25, 23);
            this.btnTip.TabIndex = 11;
            this.btnTip.Text = "?";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Enabled = false;
            this.chkEnable.Location = new System.Drawing.Point(25, 20);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(48, 16);
            this.chkEnable.TabIndex = 0;
            this.chkEnable.Text = "啟用";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // rbIPv6
            // 
            this.rbIPv6.AutoSize = true;
            this.rbIPv6.Enabled = false;
            this.rbIPv6.Location = new System.Drawing.Point(370, 50);
            this.rbIPv6.Name = "rbIPv6";
            this.rbIPv6.Size = new System.Drawing.Size(45, 16);
            this.rbIPv6.TabIndex = 4;
            this.rbIPv6.Text = "IPv6";
            this.rbIPv6.UseVisualStyleBackColor = true;
            // 
            // rbIPv4
            // 
            this.rbIPv4.AutoSize = true;
            this.rbIPv4.Checked = true;
            this.rbIPv4.Enabled = false;
            this.rbIPv4.Location = new System.Drawing.Point(370, 25);
            this.rbIPv4.Name = "rbIPv4";
            this.rbIPv4.Size = new System.Drawing.Size(45, 16);
            this.rbIPv4.TabIndex = 3;
            this.rbIPv4.TabStop = true;
            this.rbIPv4.Text = "IPv4";
            this.rbIPv4.UseVisualStyleBackColor = true;
            // 
            // numInterval
            // 
            this.numInterval.Enabled = false;
            this.numInterval.Location = new System.Drawing.Point(93, 138);
            this.numInterval.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 22);
            this.numInterval.TabIndex = 8;
            this.numInterval.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numPort
            // 
            this.numPort.Enabled = false;
            this.numPort.Location = new System.Drawing.Point(93, 93);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(120, 22);
            this.numPort.TabIndex = 6;
            this.numPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelIntervalUnit
            // 
            this.labelIntervalUnit.AutoSize = true;
            this.labelIntervalUnit.Location = new System.Drawing.Point(228, 140);
            this.labelIntervalUnit.Name = "labelIntervalUnit";
            this.labelIntervalUnit.Size = new System.Drawing.Size(17, 12);
            this.labelIntervalUnit.TabIndex = 9;
            this.labelIntervalUnit.Text = "秒";
            // 
            // txtCloseCommand
            // 
            this.txtCloseCommand.Enabled = false;
            this.txtCloseCommand.Location = new System.Drawing.Point(93, 302);
            this.txtCloseCommand.Multiline = true;
            this.txtCloseCommand.Name = "txtCloseCommand";
            this.txtCloseCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCloseCommand.Size = new System.Drawing.Size(320, 75);
            this.txtCloseCommand.TabIndex = 14;
            // 
            // labelCloseCommand
            // 
            this.labelCloseCommand.AutoSize = true;
            this.labelCloseCommand.Location = new System.Drawing.Point(23, 305);
            this.labelCloseCommand.Name = "labelCloseCommand";
            this.labelCloseCommand.Size = new System.Drawing.Size(53, 12);
            this.labelCloseCommand.TabIndex = 13;
            this.labelCloseCommand.Text = "關服指令";
            // 
            // txtStartCommand
            // 
            this.txtStartCommand.Enabled = false;
            this.txtStartCommand.Location = new System.Drawing.Point(93, 207);
            this.txtStartCommand.Multiline = true;
            this.txtStartCommand.Name = "txtStartCommand";
            this.txtStartCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStartCommand.Size = new System.Drawing.Size(320, 75);
            this.txtStartCommand.TabIndex = 12;
            // 
            // labelStartCommand
            // 
            this.labelStartCommand.AutoSize = true;
            this.labelStartCommand.Location = new System.Drawing.Point(23, 210);
            this.labelStartCommand.Name = "labelStartCommand";
            this.labelStartCommand.Size = new System.Drawing.Size(53, 12);
            this.labelStartCommand.TabIndex = 10;
            this.labelStartCommand.Text = "開服指令";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(23, 140);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(53, 12);
            this.labelInterval.TabIndex = 7;
            this.labelInterval.Text = "掃描時間";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(23, 95);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 12);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "端口";
            // 
            // txtHost
            // 
            this.txtHost.Enabled = false;
            this.txtHost.Location = new System.Drawing.Point(93, 47);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(250, 22);
            this.txtHost.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(338, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(23, 50);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(29, 12);
            this.labelHost.TabIndex = 1;
            this.labelHost.Text = "主機";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(470, 449);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始監視";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbSettingCollection
            // 
            this.gbSettingCollection.Controls.Add(this.btnEdit);
            this.gbSettingCollection.Controls.Add(this.lbSettingCollection);
            this.gbSettingCollection.Controls.Add(this.btnRemove);
            this.gbSettingCollection.Controls.Add(this.btnAdd);
            this.gbSettingCollection.Location = new System.Drawing.Point(12, 12);
            this.gbSettingCollection.Name = "gbSettingCollection";
            this.gbSettingCollection.Size = new System.Drawing.Size(205, 460);
            this.gbSettingCollection.TabIndex = 0;
            this.gbSettingCollection.TabStop = false;
            this.gbSettingCollection.Text = "設定值";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(77, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "更名";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbSettingCollection
            // 
            this.lbSettingCollection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSettingCollection.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSettingCollection.FormattingEnabled = true;
            this.lbSettingCollection.HorizontalScrollbar = true;
            this.lbSettingCollection.ItemHeight = 17;
            this.lbSettingCollection.Location = new System.Drawing.Point(15, 25);
            this.lbSettingCollection.Name = "lbSettingCollection";
            this.lbSettingCollection.Size = new System.Drawing.Size(175, 395);
            this.lbSettingCollection.TabIndex = 0;
            this.lbSettingCollection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSettingCollection_DrawItem);
            this.lbSettingCollection.SelectedIndexChanged += new System.EventHandler(this.lbSettingCollection_SelectedIndexChanged);
            // 
            // niIcon
            // 
            this.niIcon.BalloonTipText = "程式仍在執行中";
            this.niIcon.BalloonTipTitle = "伺服器狀態監視工具";
            this.niIcon.ContextMenuStrip = this.cmsRightClickMenu;
            this.niIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcon.Icon")));
            this.niIcon.Text = "伺服器狀態監視工具";
            this.niIcon.Visible = true;
            this.niIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niIcon_MouseDoubleClick);
            // 
            // cmsRightClickMenu
            // 
            this.cmsRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetting,
            this.tsmiPause,
            this.tsmiExit});
            this.cmsRightClickMenu.Name = "cmsRightClickMenu";
            this.cmsRightClickMenu.Size = new System.Drawing.Size(99, 70);
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(98, 22);
            this.tsmiSetting.Text = "設定";
            this.tsmiSetting.Click += new System.EventHandler(this.tsmiSetting_Click);
            // 
            // tsmiPause
            // 
            this.tsmiPause.Name = "tsmiPause";
            this.tsmiPause.Size = new System.Drawing.Size(98, 22);
            this.tsmiPause.Text = "暫停";
            this.tsmiPause.Click += new System.EventHandler(this.tsmiPause_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(98, 22);
            this.tsmiExit.Text = "結束";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // btnMessageLog
            // 
            this.btnMessageLog.Location = new System.Drawing.Point(235, 449);
            this.btnMessageLog.Name = "btnMessageLog";
            this.btnMessageLog.Size = new System.Drawing.Size(75, 23);
            this.btnMessageLog.TabIndex = 2;
            this.btnMessageLog.Text = "訊息紀錄";
            this.btnMessageLog.UseVisualStyleBackColor = true;
            this.btnMessageLog.Click += new System.EventHandler(this.btnMessageLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(689, 486);
            this.Controls.Add(this.btnMessageLog);
            this.Controls.Add(this.gbSettingCollection);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbParameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "伺服器狀態監視工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.gbParameter.ResumeLayout(false);
            this.gbParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.gbSettingCollection.ResumeLayout(false);
            this.cmsRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbParameter;
        private System.Windows.Forms.TextBox txtCloseCommand;
        private System.Windows.Forms.Label labelCloseCommand;
        private System.Windows.Forms.TextBox txtStartCommand;
        private System.Windows.Forms.Label labelStartCommand;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbSettingCollection;
        private System.Windows.Forms.NotifyIcon niIcon;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelIntervalUnit;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.RadioButton rbIPv6;
        private System.Windows.Forms.RadioButton rbIPv4;
        private System.Windows.Forms.Button btnMessageLog;
        private System.Windows.Forms.ContextMenuStrip cmsRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiPause;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.ListBox lbSettingCollection;
        private System.Windows.Forms.Button btnTip;
    }
}

