namespace ChattBank
{
    partial class MngFunds
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
            this.MngFundsMenu = new System.Windows.Forms.MenuStrip();
            this.BackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.MessagePnl = new System.Windows.Forms.Panel();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.AcctMngPnl = new System.Windows.Forms.Panel();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.AmtTB = new System.Windows.Forms.TextBox();
            this.AmtLbl = new System.Windows.Forms.Label();
            this.WithdrawRDO = new System.Windows.Forms.RadioButton();
            this.DepRDO = new System.Windows.Forms.RadioButton();
            this.AcctLbl = new System.Windows.Forms.Label();
            this.AcctLstBx = new System.Windows.Forms.ListBox();
            this.MngFundsMenu.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.MessagePnl.SuspendLayout();
            this.AcctMngPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MngFundsMenu
            // 
            this.MngFundsMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.MngFundsMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngFundsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MngFundsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBtn});
            this.MngFundsMenu.Location = new System.Drawing.Point(0, 0);
            this.MngFundsMenu.Name = "MngFundsMenu";
            this.MngFundsMenu.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.MngFundsMenu.Size = new System.Drawing.Size(782, 44);
            this.MngFundsMenu.TabIndex = 3;
            // 
            // BackBtn
            // 
            this.BackBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Padding = new System.Windows.Forms.Padding(5);
            this.BackBtn.Size = new System.Drawing.Size(66, 38);
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.Controls.Add(this.HeaderLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(0, 47);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(782, 71);
            this.HeaderPnl.TabIndex = 4;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(272, 19);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(306, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Deposit/Withdraw";
            // 
            // MessagePnl
            // 
            this.MessagePnl.Controls.Add(this.MsgLbl);
            this.MessagePnl.Location = new System.Drawing.Point(0, 124);
            this.MessagePnl.Name = "MessagePnl";
            this.MessagePnl.Size = new System.Drawing.Size(782, 126);
            this.MessagePnl.TabIndex = 5;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Location = new System.Drawing.Point(18, 3);
            this.MsgLbl.MaximumSize = new System.Drawing.Size(750, 0);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(746, 120);
            this.MsgLbl.TabIndex = 0;
            this.MsgLbl.Text = "Use the form below to make a deposit or withdrawal from one of your Chatt Bank ac" +
    "counts.\r\n\r\nTo avoid mistakes, make sure to check the information provided before" +
    " submitting your request.";
            this.MsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcctMngPnl
            // 
            this.AcctMngPnl.Controls.Add(this.WithdrawBtn);
            this.AcctMngPnl.Controls.Add(this.DepositBtn);
            this.AcctMngPnl.Controls.Add(this.AmtTB);
            this.AcctMngPnl.Controls.Add(this.AmtLbl);
            this.AcctMngPnl.Controls.Add(this.WithdrawRDO);
            this.AcctMngPnl.Controls.Add(this.DepRDO);
            this.AcctMngPnl.Controls.Add(this.AcctLbl);
            this.AcctMngPnl.Controls.Add(this.AcctLstBx);
            this.AcctMngPnl.Location = new System.Drawing.Point(0, 256);
            this.AcctMngPnl.Name = "AcctMngPnl";
            this.AcctMngPnl.Size = new System.Drawing.Size(782, 185);
            this.AcctMngPnl.TabIndex = 6;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.WithdrawBtn.Location = new System.Drawing.Point(625, 43);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Padding = new System.Windows.Forms.Padding(3);
            this.WithdrawBtn.Size = new System.Drawing.Size(110, 50);
            this.WithdrawBtn.TabIndex = 8;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            this.WithdrawBtn.Visible = false;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.DepositBtn.Location = new System.Drawing.Point(625, 43);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Padding = new System.Windows.Forms.Padding(3);
            this.DepositBtn.Size = new System.Drawing.Size(110, 50);
            this.DepositBtn.TabIndex = 7;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // AmtTB
            // 
            this.AmtTB.Location = new System.Drawing.Point(52, 96);
            this.AmtTB.Name = "AmtTB";
            this.AmtTB.Size = new System.Drawing.Size(300, 32);
            this.AmtTB.TabIndex = 6;
            // 
            // AmtLbl
            // 
            this.AmtLbl.AutoSize = true;
            this.AmtLbl.Location = new System.Drawing.Point(48, 69);
            this.AmtLbl.Name = "AmtLbl";
            this.AmtLbl.Size = new System.Drawing.Size(86, 24);
            this.AmtLbl.TabIndex = 5;
            this.AmtLbl.Text = "Amount:";
            // 
            // WithdrawRDO
            // 
            this.WithdrawRDO.AutoSize = true;
            this.WithdrawRDO.Location = new System.Drawing.Point(416, 71);
            this.WithdrawRDO.Name = "WithdrawRDO";
            this.WithdrawRDO.Size = new System.Drawing.Size(116, 28);
            this.WithdrawRDO.TabIndex = 4;
            this.WithdrawRDO.Text = "Withdraw";
            this.WithdrawRDO.UseVisualStyleBackColor = true;
            this.WithdrawRDO.CheckedChanged += new System.EventHandler(this.WithdrawRDO_CheckedChanged);
            // 
            // DepRDO
            // 
            this.DepRDO.AutoSize = true;
            this.DepRDO.Checked = true;
            this.DepRDO.Location = new System.Drawing.Point(416, 36);
            this.DepRDO.Name = "DepRDO";
            this.DepRDO.Size = new System.Drawing.Size(99, 28);
            this.DepRDO.TabIndex = 3;
            this.DepRDO.TabStop = true;
            this.DepRDO.Text = "Deposit";
            this.DepRDO.UseVisualStyleBackColor = true;
            this.DepRDO.CheckedChanged += new System.EventHandler(this.DepRDO_CheckedChanged);
            // 
            // AcctLbl
            // 
            this.AcctLbl.AutoSize = true;
            this.AcctLbl.Location = new System.Drawing.Point(48, 7);
            this.AcctLbl.Name = "AcctLbl";
            this.AcctLbl.Size = new System.Drawing.Size(121, 24);
            this.AcctLbl.TabIndex = 1;
            this.AcctLbl.Text = "Account no.:";
            // 
            // AcctLstBx
            // 
            this.AcctLstBx.FormattingEnabled = true;
            this.AcctLstBx.ItemHeight = 24;
            this.AcctLstBx.Location = new System.Drawing.Point(52, 34);
            this.AcctLstBx.Name = "AcctLstBx";
            this.AcctLstBx.Size = new System.Drawing.Size(300, 28);
            this.AcctLstBx.TabIndex = 0;
            // 
            // MngFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.AcctMngPnl);
            this.Controls.Add(this.MessagePnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.MngFundsMenu);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MngFunds";
            this.Text = "Chatt Bank | Manage Funds";
            this.MngFundsMenu.ResumeLayout(false);
            this.MngFundsMenu.PerformLayout();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.MessagePnl.ResumeLayout(false);
            this.MessagePnl.PerformLayout();
            this.AcctMngPnl.ResumeLayout(false);
            this.AcctMngPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MngFundsMenu;
        private System.Windows.Forms.ToolStripMenuItem BackBtn;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Panel MessagePnl;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Panel AcctMngPnl;
        private System.Windows.Forms.TextBox AmtTB;
        private System.Windows.Forms.Label AmtLbl;
        private System.Windows.Forms.RadioButton WithdrawRDO;
        private System.Windows.Forms.RadioButton DepRDO;
        private System.Windows.Forms.Label AcctLbl;
        private System.Windows.Forms.ListBox AcctLstBx;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button DepositBtn;
    }
}