namespace ChattBank
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomePnl = new System.Windows.Forms.Panel();
            this.ContentLbl = new System.Windows.Forms.Label();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.SignInPnl = new System.Windows.Forms.Panel();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignInPassTB = new System.Windows.Forms.TextBox();
            this.SignInIDTB = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.SignInIDLbl = new System.Windows.Forms.Label();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.LoginMenuStrip.SuspendLayout();
            this.WelcomePnl.SuspendLayout();
            this.SignInPnl.SuspendLayout();
            this.HeaderPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem,
            this.ClearMenuItem});
            this.LoginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            this.LoginMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.LoginMenuStrip.Size = new System.Drawing.Size(782, 44);
            this.LoginMenuStrip.TabIndex = 1;
            this.LoginMenuStrip.Text = "menuStrip1";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.ExitMenuItem.Size = new System.Drawing.Size(57, 38);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ClearMenuItem
            // 
            this.ClearMenuItem.Name = "ClearMenuItem";
            this.ClearMenuItem.Size = new System.Drawing.Size(70, 38);
            this.ClearMenuItem.Text = "Clear";
            this.ClearMenuItem.Click += new System.EventHandler(this.ClearMenuItem_Click);
            // 
            // WelcomePnl
            // 
            this.WelcomePnl.Controls.Add(this.ContentLbl);
            this.WelcomePnl.Location = new System.Drawing.Point(0, 152);
            this.WelcomePnl.Name = "WelcomePnl";
            this.WelcomePnl.Size = new System.Drawing.Size(348, 296);
            this.WelcomePnl.TabIndex = 2;
            // 
            // ContentLbl
            // 
            this.ContentLbl.AutoSize = true;
            this.ContentLbl.Location = new System.Drawing.Point(45, 4);
            this.ContentLbl.MaximumSize = new System.Drawing.Size(260, 0);
            this.ContentLbl.Name = "ContentLbl";
            this.ContentLbl.Size = new System.Drawing.Size(259, 288);
            this.ContentLbl.TabIndex = 1;
            this.ContentLbl.Text = resources.GetString("ContentLbl.Text");
            this.ContentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(49, 33);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(312, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Chatt Bank Sign In";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInPnl
            // 
            this.SignInPnl.Controls.Add(this.SignInBtn);
            this.SignInPnl.Controls.Add(this.SignInPassTB);
            this.SignInPnl.Controls.Add(this.SignInIDTB);
            this.SignInPnl.Controls.Add(this.PassLbl);
            this.SignInPnl.Controls.Add(this.SignInIDLbl);
            this.SignInPnl.Location = new System.Drawing.Point(354, 47);
            this.SignInPnl.Name = "SignInPnl";
            this.SignInPnl.Size = new System.Drawing.Size(428, 401);
            this.SignInPnl.TabIndex = 0;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.SignInBtn.Location = new System.Drawing.Point(139, 264);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Padding = new System.Windows.Forms.Padding(3);
            this.SignInBtn.Size = new System.Drawing.Size(150, 50);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignInPassTB
            // 
            this.SignInPassTB.Location = new System.Drawing.Point(69, 195);
            this.SignInPassTB.Name = "SignInPassTB";
            this.SignInPassTB.PasswordChar = '*';
            this.SignInPassTB.Size = new System.Drawing.Size(294, 32);
            this.SignInPassTB.TabIndex = 1;
            // 
            // SignInIDTB
            // 
            this.SignInIDTB.Location = new System.Drawing.Point(69, 113);
            this.SignInIDTB.Name = "SignInIDTB";
            this.SignInIDTB.Size = new System.Drawing.Size(294, 32);
            this.SignInIDTB.TabIndex = 0;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(65, 168);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(101, 24);
            this.PassLbl.TabIndex = 1;
            this.PassLbl.Text = "Password:";
            // 
            // SignInIDLbl
            // 
            this.SignInIDLbl.AutoSize = true;
            this.SignInIDLbl.Location = new System.Drawing.Point(65, 86);
            this.SignInIDLbl.Name = "SignInIDLbl";
            this.SignInIDLbl.Size = new System.Drawing.Size(38, 24);
            this.SignInIDLbl.TabIndex = 0;
            this.SignInIDLbl.Text = "ID:";
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.Controls.Add(this.HeaderLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(0, 47);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(348, 99);
            this.HeaderPnl.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.SignInPnl);
            this.Controls.Add(this.WelcomePnl);
            this.Controls.Add(this.LoginMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.LoginMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Chatt Bank | Login";
            this.LoginMenuStrip.ResumeLayout(false);
            this.LoginMenuStrip.PerformLayout();
            this.WelcomePnl.ResumeLayout(false);
            this.WelcomePnl.PerformLayout();
            this.SignInPnl.ResumeLayout(false);
            this.SignInPnl.PerformLayout();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip LoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.Panel WelcomePnl;
        private System.Windows.Forms.Label ContentLbl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Panel SignInPnl;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox SignInPassTB;
        private System.Windows.Forms.TextBox SignInIDTB;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label SignInIDLbl;
        private System.Windows.Forms.Panel HeaderPnl;
    }
}