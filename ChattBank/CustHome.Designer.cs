namespace ChattBank
{
    partial class CustHome
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
            this.CustHomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SignOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcctPnl = new System.Windows.Forms.Panel();
            this.AcctLstVw = new System.Windows.Forms.ListView();
            this.AcctNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AcctType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AcctBal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.BtnPnl = new System.Windows.Forms.Panel();
            this.MngFundsBtn = new System.Windows.Forms.Button();
            this.NewAcctBtn = new System.Windows.Forms.Button();
            this.CustHomeMenuStrip.SuspendLayout();
            this.AcctPnl.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.BtnPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustHomeMenuStrip
            // 
            this.CustHomeMenuStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.CustHomeMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustHomeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CustHomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignOutMenuItem});
            this.CustHomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CustHomeMenuStrip.Name = "CustHomeMenuStrip";
            this.CustHomeMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.CustHomeMenuStrip.Size = new System.Drawing.Size(782, 44);
            this.CustHomeMenuStrip.TabIndex = 2;
            // 
            // SignOutMenuItem
            // 
            this.SignOutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SignOutMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOutMenuItem.Name = "SignOutMenuItem";
            this.SignOutMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.SignOutMenuItem.Size = new System.Drawing.Size(97, 38);
            this.SignOutMenuItem.Text = "Sign out";
            this.SignOutMenuItem.Click += new System.EventHandler(this.SignOutMenuItem_Click);
            // 
            // AcctPnl
            // 
            this.AcctPnl.Controls.Add(this.AcctLstVw);
            this.AcctPnl.Location = new System.Drawing.Point(0, 141);
            this.AcctPnl.Name = "AcctPnl";
            this.AcctPnl.Size = new System.Drawing.Size(598, 306);
            this.AcctPnl.TabIndex = 3;
            // 
            // AcctLstVw
            // 
            this.AcctLstVw.BackColor = System.Drawing.SystemColors.Window;
            this.AcctLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AcctNo,
            this.AcctType,
            this.AcctBal});
            this.AcctLstVw.HideSelection = false;
            this.AcctLstVw.Location = new System.Drawing.Point(12, 3);
            this.AcctLstVw.Name = "AcctLstVw";
            this.AcctLstVw.Size = new System.Drawing.Size(583, 297);
            this.AcctLstVw.TabIndex = 0;
            this.AcctLstVw.UseCompatibleStateImageBehavior = false;
            this.AcctLstVw.View = System.Windows.Forms.View.Details;
            // 
            // AcctNo
            // 
            this.AcctNo.Text = "Account No.";
            this.AcctNo.Width = 200;
            // 
            // AcctType
            // 
            this.AcctType.Text = "Account Type";
            this.AcctType.Width = 200;
            // 
            // AcctBal
            // 
            this.AcctBal.Text = "Balance";
            this.AcctBal.Width = 179;
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.Controls.Add(this.HeaderLbl);
            this.HeaderPnl.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderPnl.Location = new System.Drawing.Point(0, 47);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(598, 88);
            this.HeaderPnl.TabIndex = 4;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Location = new System.Drawing.Point(217, 28);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(165, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Accounts";
            // 
            // BtnPnl
            // 
            this.BtnPnl.Controls.Add(this.MngFundsBtn);
            this.BtnPnl.Controls.Add(this.NewAcctBtn);
            this.BtnPnl.Location = new System.Drawing.Point(604, 47);
            this.BtnPnl.Name = "BtnPnl";
            this.BtnPnl.Size = new System.Drawing.Size(178, 400);
            this.BtnPnl.TabIndex = 5;
            // 
            // MngFundsBtn
            // 
            this.MngFundsBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.MngFundsBtn.Location = new System.Drawing.Point(14, 258);
            this.MngFundsBtn.Name = "MngFundsBtn";
            this.MngFundsBtn.Padding = new System.Windows.Forms.Padding(3);
            this.MngFundsBtn.Size = new System.Drawing.Size(150, 50);
            this.MngFundsBtn.TabIndex = 4;
            this.MngFundsBtn.Text = "Manage funds";
            this.MngFundsBtn.UseVisualStyleBackColor = false;
            this.MngFundsBtn.Click += new System.EventHandler(this.MngFundsBtn_Click);
            // 
            // NewAcctBtn
            // 
            this.NewAcctBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.NewAcctBtn.Location = new System.Drawing.Point(14, 326);
            this.NewAcctBtn.Name = "NewAcctBtn";
            this.NewAcctBtn.Padding = new System.Windows.Forms.Padding(3);
            this.NewAcctBtn.Size = new System.Drawing.Size(150, 50);
            this.NewAcctBtn.TabIndex = 3;
            this.NewAcctBtn.Text = "New account";
            this.NewAcctBtn.UseVisualStyleBackColor = false;
            this.NewAcctBtn.Click += new System.EventHandler(this.NewAcctBtn_Click);
            // 
            // CustHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.BtnPnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.AcctPnl);
            this.Controls.Add(this.CustHomeMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CustHome";
            this.Text = "Chatt Bank | Customer Home";
            this.CustHomeMenuStrip.ResumeLayout(false);
            this.CustHomeMenuStrip.PerformLayout();
            this.AcctPnl.ResumeLayout(false);
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.BtnPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CustHomeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SignOutMenuItem;
        private System.Windows.Forms.Panel AcctPnl;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Panel BtnPnl;
        private System.Windows.Forms.Button MngFundsBtn;
        private System.Windows.Forms.Button NewAcctBtn;
        private System.Windows.Forms.ListView AcctLstVw;
        private System.Windows.Forms.ColumnHeader AcctNo;
        private System.Windows.Forms.ColumnHeader AcctType;
        private System.Windows.Forms.ColumnHeader AcctBal;
    }
}