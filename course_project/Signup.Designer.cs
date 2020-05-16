using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace course_project
{
    partial class Signup
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
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pwd_edt = new System.Windows.Forms.TextBox();
            this.login_edt = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.rptpwd_lbl = new System.Windows.Forms.Label();
            this.rpt_pwd_edt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.Location = new System.Drawing.Point(11, 47);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(156, 13);
            this.pwd_lbl.TabIndex = 12;
            this.pwd_lbl.Text = "Password";
            this.pwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_lbl
            // 
            this.login_lbl.Location = new System.Drawing.Point(11, 8);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(156, 13);
            this.login_lbl.TabIndex = 11;
            this.login_lbl.Text = "Login";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd_edt
            // 
            this.pwd_edt.Location = new System.Drawing.Point(11, 63);
            this.pwd_edt.Name = "pwd_edt";
            this.pwd_edt.PasswordChar = '•';
            this.pwd_edt.Size = new System.Drawing.Size(156, 20);
            this.pwd_edt.TabIndex = 1;
            // 
            // login_edt
            // 
            this.login_edt.Location = new System.Drawing.Point(11, 24);
            this.login_edt.Name = "login_edt";
            this.login_edt.Size = new System.Drawing.Size(156, 20);
            this.login_edt.TabIndex = 0;
            // 
            // signup_btn
            // 
            this.signup_btn.AutoSize = true;
            this.signup_btn.Location = new System.Drawing.Point(62, 126);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(61, 23);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "Sign Up!";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // rptpwd_lbl
            // 
            this.rptpwd_lbl.Location = new System.Drawing.Point(11, 84);
            this.rptpwd_lbl.Name = "rptpwd_lbl";
            this.rptpwd_lbl.Size = new System.Drawing.Size(156, 13);
            this.rptpwd_lbl.TabIndex = 14;
            this.rptpwd_lbl.Text = "Repeat password";
            this.rptpwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpt_pwd_edt
            // 
            this.rpt_pwd_edt.Location = new System.Drawing.Point(11, 100);
            this.rpt_pwd_edt.Name = "rpt_pwd_edt";
            this.rpt_pwd_edt.PasswordChar = '•';
            this.rpt_pwd_edt.Size = new System.Drawing.Size(156, 20);
            this.rpt_pwd_edt.TabIndex = 2;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.rptpwd_lbl);
            this.Controls.Add(this.rpt_pwd_edt);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.pwd_edt);
            this.Controls.Add(this.login_edt);
            this.Controls.Add(this.signup_btn);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox pwd_edt;
        private System.Windows.Forms.TextBox login_edt;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label rptpwd_lbl;
        private System.Windows.Forms.TextBox rpt_pwd_edt;
        private OracleConnection connection;
        private Form parent;
    }
}