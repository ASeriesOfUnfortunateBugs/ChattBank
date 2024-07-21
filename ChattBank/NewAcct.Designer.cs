namespace ChattBank
{
    partial class NewAcct
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
            this.NewAcctMenu = new System.Windows.Forms.MenuStrip();
            this.BackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.MsgPnl = new System.Windows.Forms.Panel();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.NewAcctPnl = new System.Windows.Forms.Panel();
            this.NewAcctBtn = new System.Windows.Forms.Button();
            this.AcctTypeLbl = new System.Windows.Forms.Label();
            this.AcctTypeLstBx = new System.Windows.Forms.ListBox();
            this.NewAcctMenu.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.MsgPnl.SuspendLayout();
            this.NewAcctPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewAcctMenu
            // 
            this.NewAcctMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.NewAcctMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAcctMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NewAcctMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBtn});
            this.NewAcctMenu.Location = new System.Drawing.Point(0, 0);
            this.NewAcctMenu.Name = "NewAcctMenu";
            this.NewAcctMenu.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.NewAcctMenu.Size = new System.Drawing.Size(782, 44);
            this.NewAcctMenu.TabIndex = 3;
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
            this.HeaderPnl.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderPnl.Location = new System.Drawing.Point(0, 47);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(782, 88);
            this.HeaderPnl.TabIndex = 4;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Location = new System.Drawing.Point(181, 28);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(470, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Add a New Banking Account";
            // 
            // MsgPnl
            // 
            this.MsgPnl.Controls.Add(this.MsgLbl);
            this.MsgPnl.Location = new System.Drawing.Point(0, 141);
            this.MsgPnl.Name = "MsgPnl";
            this.MsgPnl.Size = new System.Drawing.Size(782, 100);
            this.MsgPnl.TabIndex = 5;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Location = new System.Drawing.Point(22, 2);
            this.MsgLbl.MaximumSize = new System.Drawing.Size(750, 0);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(739, 96);
            this.MsgLbl.TabIndex = 0;
            this.MsgLbl.Text = "To open a new banking account, select the account type from the dropbox below.\r\n\r" +
    "\nA new account number will be generated for you, and your new account\'s balance " +
    "with be $0.";
            this.MsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewAcctPnl
            // 
            this.NewAcctPnl.Controls.Add(this.NewAcctBtn);
            this.NewAcctPnl.Controls.Add(this.AcctTypeLbl);
            this.NewAcctPnl.Controls.Add(this.AcctTypeLstBx);
            this.NewAcctPnl.Location = new System.Drawing.Point(0, 247);
            this.NewAcctPnl.Name = "NewAcctPnl";
            this.NewAcctPnl.Size = new System.Drawing.Size(782, 194);
            this.NewAcctPnl.TabIndex = 6;
            // 
            // NewAcctBtn
            // 
            this.NewAcctBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.NewAcctBtn.Location = new System.Drawing.Point(316, 89);
            this.NewAcctBtn.Name = "NewAcctBtn";
            this.NewAcctBtn.Padding = new System.Windows.Forms.Padding(3);
            this.NewAcctBtn.Size = new System.Drawing.Size(150, 75);
            this.NewAcctBtn.TabIndex = 5;
            this.NewAcctBtn.Text = "Create Account";
            this.NewAcctBtn.UseVisualStyleBackColor = false;
            this.NewAcctBtn.Click += new System.EventHandler(this.NewAcctBtn_Click);
            // 
            // AcctTypeLbl
            // 
            this.AcctTypeLbl.AutoSize = true;
            this.AcctTypeLbl.Location = new System.Drawing.Point(256, 13);
            this.AcctTypeLbl.Name = "AcctTypeLbl";
            this.AcctTypeLbl.Size = new System.Drawing.Size(137, 24);
            this.AcctTypeLbl.TabIndex = 1;
            this.AcctTypeLbl.Text = "Account Type:";
            // 
            // AcctTypeLstBx
            // 
            this.AcctTypeLstBx.FormattingEnabled = true;
            this.AcctTypeLstBx.ItemHeight = 24;
            this.AcctTypeLstBx.Items.AddRange(new object[] {
            "CHK",
            "SAV",
            "MMA"});
            this.AcctTypeLstBx.Location = new System.Drawing.Point(260, 40);
            this.AcctTypeLstBx.Name = "AcctTypeLstBx";
            this.AcctTypeLstBx.Size = new System.Drawing.Size(267, 28);
            this.AcctTypeLstBx.TabIndex = 0;
            // 
            // NewAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.NewAcctPnl);
            this.Controls.Add(this.MsgPnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.NewAcctMenu);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewAcct";
            this.Text = "Chatt Bank | New Banking Account";
            this.NewAcctMenu.ResumeLayout(false);
            this.NewAcctMenu.PerformLayout();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.MsgPnl.ResumeLayout(false);
            this.MsgPnl.PerformLayout();
            this.NewAcctPnl.ResumeLayout(false);
            this.NewAcctPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NewAcctMenu;
        private System.Windows.Forms.ToolStripMenuItem BackBtn;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Panel MsgPnl;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Panel NewAcctPnl;
        private System.Windows.Forms.Label AcctTypeLbl;
        private System.Windows.Forms.ListBox AcctTypeLstBx;
        private System.Windows.Forms.Button NewAcctBtn;
    }
}