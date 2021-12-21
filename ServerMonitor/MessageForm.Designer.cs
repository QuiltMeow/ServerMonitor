namespace ServerMonitor
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateUI = new System.Windows.Forms.ToolStripMenuItem();
            this.scDock = new System.Windows.Forms.SplitContainer();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDock)).BeginInit();
            this.scDock.Panel1.SuspendLayout();
            this.scDock.Panel2.SuspendLayout();
            this.scDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFunction,
            this.tsmiUpdateUI});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(684, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "選單";
            // 
            // tsmiFunction
            // 
            this.tsmiFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiClearMessage,
            this.tsmiClearConsole});
            this.tsmiFunction.Name = "tsmiFunction";
            this.tsmiFunction.Size = new System.Drawing.Size(43, 20);
            this.tsmiFunction.Text = "功能";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(158, 22);
            this.tsmiCopy.Text = "複製";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiClearMessage
            // 
            this.tsmiClearMessage.Name = "tsmiClearMessage";
            this.tsmiClearMessage.Size = new System.Drawing.Size(158, 22);
            this.tsmiClearMessage.Text = "清除訊息紀錄";
            this.tsmiClearMessage.Click += new System.EventHandler(this.tsmiClearMessage_Click);
            // 
            // tsmiClearConsole
            // 
            this.tsmiClearConsole.Name = "tsmiClearConsole";
            this.tsmiClearConsole.Size = new System.Drawing.Size(158, 22);
            this.tsmiClearConsole.Text = "清除主控台紀錄";
            this.tsmiClearConsole.Click += new System.EventHandler(this.tsmiClearConsole_Click);
            // 
            // tsmiUpdateUI
            // 
            this.tsmiUpdateUI.Name = "tsmiUpdateUI";
            this.tsmiUpdateUI.Size = new System.Drawing.Size(43, 20);
            this.tsmiUpdateUI.Text = "更新";
            this.tsmiUpdateUI.Click += new System.EventHandler(this.tsmiUpdateUI_Click);
            // 
            // scDock
            // 
            this.scDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDock.Location = new System.Drawing.Point(0, 24);
            this.scDock.Name = "scDock";
            // 
            // scDock.Panel1
            // 
            this.scDock.Panel1.Controls.Add(this.lbLog);
            // 
            // scDock.Panel2
            // 
            this.scDock.Panel2.Controls.Add(this.txtLog);
            this.scDock.Size = new System.Drawing.Size(684, 437);
            this.scDock.SplitterDistance = 175;
            this.scDock.TabIndex = 1;
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(175, 437);
            this.lbLog.TabIndex = 0;
            this.lbLog.SelectedIndexChanged += new System.EventHandler(this.lbLog_SelectedIndexChanged);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Azure;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(505, 437);
            this.txtLog.TabIndex = 0;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.scDock);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.msMenu;
            this.Name = "MessageForm";
            this.Text = "訊息紀錄";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.MessageForm_VisibleChanged);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.scDock.Panel1.ResumeLayout(false);
            this.scDock.Panel2.ResumeLayout(false);
            this.scDock.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDock)).EndInit();
            this.scDock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFunction;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearConsole;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateUI;
        private System.Windows.Forms.SplitContainer scDock;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox txtLog;
    }
}