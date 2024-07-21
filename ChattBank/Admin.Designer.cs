namespace ChattBank
{
    partial class Admin
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
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SignOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.WelcomePnl = new System.Windows.Forms.Panel();
            this.ContentLbl = new System.Windows.Forms.Label();
            this.custManagePnl = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.CustPassTB = new System.Windows.Forms.TextBox();
            this.CustIDTB = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.CustPassLbl = new System.Windows.Forms.Label();
            this.CustIDLbl = new System.Windows.Forms.Label();
            this.AdminMenuStrip.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.WelcomePnl.SuspendLayout();
            this.custManagePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminMenuStrip
            // 
            this.AdminMenuStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.AdminMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignOutMenuItem,
            this.ClearMenuItem});
            this.AdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminMenuStrip.Name = "AdminMenuStrip";
            this.AdminMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.AdminMenuStrip.Size = new System.Drawing.Size(782, 44);
            this.AdminMenuStrip.TabIndex = 1;
            this.AdminMenuStrip.Text = "menuStrip1";
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
            // ClearMenuItem
            // 
            this.ClearMenuItem.Name = "ClearMenuItem";
            this.ClearMenuItem.Size = new System.Drawing.Size(70, 38);
            this.ClearMenuItem.Text = "Clear";
            this.ClearMenuItem.Click += new System.EventHandler(this.ClearMenuItem_Click);
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.Controls.Add(this.HeaderLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(0, 47);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(348, 99);
            this.HeaderPnl.TabIndex = 4;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(49, 33);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(308, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Chatt Bank Admin";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomePnl
            // 
            this.WelcomePnl.Controls.Add(this.ContentLbl);
            this.WelcomePnl.Location = new System.Drawing.Point(0, 152);
            this.WelcomePnl.Name = "WelcomePnl";
            this.WelcomePnl.Size = new System.Drawing.Size(348, 296);
            this.WelcomePnl.TabIndex = 5;
            // 
            // ContentLbl
            // 
            this.ContentLbl.AutoSize = true;
            this.ContentLbl.Location = new System.Drawing.Point(48, 28);
            this.ContentLbl.MaximumSize = new System.Drawing.Size(260, 0);
            this.ContentLbl.Name = "ContentLbl";
            this.ContentLbl.Size = new System.Drawing.Size(252, 240);
            this.ContentLbl.TabIndex = 1;
            this.ContentLbl.Text = "You are now signed in with a Chatt Bank admin account.\r\n\r\nChatt Bank admins can u" +
    "se the form to the right to create new customer accounts or search for and manag" +
    "e current customer accounts.\r\n";
            this.ContentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custManagePnl
            // 
            this.custManagePnl.Controls.Add(this.DeleteBtn);
            this.custManagePnl.Controls.Add(this.UpdateBtn);
            this.custManagePnl.Controls.Add(this.AddBtn);
            this.custManagePnl.Controls.Add(this.FindBtn);
            this.custManagePnl.Controls.Add(this.EmailTB);
            this.custManagePnl.Controls.Add(this.AddressTB);
            this.custManagePnl.Controls.Add(this.LNameTB);
            this.custManagePnl.Controls.Add(this.FNameTB);
            this.custManagePnl.Controls.Add(this.CustPassTB);
            this.custManagePnl.Controls.Add(this.CustIDTB);
            this.custManagePnl.Controls.Add(this.EmailLbl);
            this.custManagePnl.Controls.Add(this.AddressLbl);
            this.custManagePnl.Controls.Add(this.LNameLbl);
            this.custManagePnl.Controls.Add(this.FNameLbl);
            this.custManagePnl.Controls.Add(this.CustPassLbl);
            this.custManagePnl.Controls.Add(this.CustIDLbl);
            this.custManagePnl.Location = new System.Drawing.Point(354, 47);
            this.custManagePnl.Name = "custManagePnl";
            this.custManagePnl.Size = new System.Drawing.Size(428, 401);
            this.custManagePnl.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(288, 315);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteBtn.Size = new System.Drawing.Size(100, 50);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateBtn.Location = new System.Drawing.Point(288, 129);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateBtn.Size = new System.Drawing.Size(100, 50);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.AddBtn.Location = new System.Drawing.Point(288, 222);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(3);
            this.AddBtn.Size = new System.Drawing.Size(100, 50);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.FindBtn.Location = new System.Drawing.Point(288, 36);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Padding = new System.Windows.Forms.Padding(3);
            this.FindBtn.Size = new System.Drawing.Size(100, 50);
            this.FindBtn.TabIndex = 6;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(56, 353);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(186, 32);
            this.EmailTB.TabIndex = 5;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(56, 291);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(186, 32);
            this.AddressTB.TabIndex = 4;
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(56, 229);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(186, 32);
            this.LNameTB.TabIndex = 3;
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(56, 167);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(186, 32);
            this.FNameTB.TabIndex = 2;
            // 
            // CustPassTB
            // 
            this.CustPassTB.Location = new System.Drawing.Point(56, 105);
            this.CustPassTB.Name = "CustPassTB";
            this.CustPassTB.Size = new System.Drawing.Size(186, 32);
            this.CustPassTB.TabIndex = 1;
            // 
            // CustIDTB
            // 
            this.CustIDTB.Location = new System.Drawing.Point(56, 43);
            this.CustIDTB.Name = "CustIDTB";
            this.CustIDTB.Size = new System.Drawing.Size(186, 32);
            this.CustIDTB.TabIndex = 0;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(52, 326);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(66, 24);
            this.EmailLbl.TabIndex = 5;
            this.EmailLbl.Text = "Email:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(52, 264);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(87, 24);
            this.AddressLbl.TabIndex = 4;
            this.AddressLbl.Text = "Address:";
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Location = new System.Drawing.Point(52, 202);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(110, 24);
            this.LNameLbl.TabIndex = 3;
            this.LNameLbl.Text = "Last name:";
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Location = new System.Drawing.Point(52, 140);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(111, 24);
            this.FNameLbl.TabIndex = 2;
            this.FNameLbl.Text = "First name:";
            // 
            // CustPassLbl
            // 
            this.CustPassLbl.AutoSize = true;
            this.CustPassLbl.Location = new System.Drawing.Point(52, 78);
            this.CustPassLbl.Name = "CustPassLbl";
            this.CustPassLbl.Size = new System.Drawing.Size(101, 24);
            this.CustPassLbl.TabIndex = 1;
            this.CustPassLbl.Text = "Password:";
            // 
            // CustIDLbl
            // 
            this.CustIDLbl.AutoSize = true;
            this.CustIDLbl.Location = new System.Drawing.Point(52, 16);
            this.CustIDLbl.Name = "CustIDLbl";
            this.CustIDLbl.Size = new System.Drawing.Size(129, 24);
            this.CustIDLbl.TabIndex = 0;
            this.CustIDLbl.Text = "Customer ID:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.custManagePnl);
            this.Controls.Add(this.WelcomePnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.AdminMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Admin";
            this.Text = "Chatt Bank | Admin Home";
            this.AdminMenuStrip.ResumeLayout(false);
            this.AdminMenuStrip.PerformLayout();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.WelcomePnl.ResumeLayout(false);
            this.WelcomePnl.PerformLayout();
            this.custManagePnl.ResumeLayout(false);
            this.custManagePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SignOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Panel WelcomePnl;
        private System.Windows.Forms.Label ContentLbl;
        private System.Windows.Forms.Panel custManagePnl;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox CustPassTB;
        private System.Windows.Forms.TextBox CustIDTB;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.Label CustPassLbl;
        private System.Windows.Forms.Label CustIDLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button FindBtn;
    }
}