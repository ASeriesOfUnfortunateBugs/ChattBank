namespace ChattBank
{
    partial class Form1
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
            this.custBtn = new System.Windows.Forms.Button();
            this.acctBtn = new System.Windows.Forms.Button();
            this.custTB = new System.Windows.Forms.TextBox();
            this.acctTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // custBtn
            // 
            this.custBtn.Location = new System.Drawing.Point(363, 188);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(75, 23);
            this.custBtn.TabIndex = 0;
            this.custBtn.Text = "Customer";
            this.custBtn.UseVisualStyleBackColor = true;
            this.custBtn.Click += new System.EventHandler(this.custBtn_Click);
            // 
            // acctBtn
            // 
            this.acctBtn.Location = new System.Drawing.Point(363, 239);
            this.acctBtn.Name = "acctBtn";
            this.acctBtn.Size = new System.Drawing.Size(75, 23);
            this.acctBtn.TabIndex = 1;
            this.acctBtn.Text = "Account";
            this.acctBtn.UseVisualStyleBackColor = true;
            this.acctBtn.Click += new System.EventHandler(this.acctBtn_Click);
            // 
            // custTB
            // 
            this.custTB.Location = new System.Drawing.Point(220, 188);
            this.custTB.Name = "custTB";
            this.custTB.Size = new System.Drawing.Size(100, 22);
            this.custTB.TabIndex = 2;
            // 
            // acctTB
            // 
            this.acctTB.Location = new System.Drawing.Point(220, 239);
            this.acctTB.Name = "acctTB";
            this.acctTB.Size = new System.Drawing.Size(100, 22);
            this.acctTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acctTB);
            this.Controls.Add(this.custTB);
            this.Controls.Add(this.acctBtn);
            this.Controls.Add(this.custBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.Button acctBtn;
        private System.Windows.Forms.TextBox custTB;
        private System.Windows.Forms.TextBox acctTB;
    }
}

