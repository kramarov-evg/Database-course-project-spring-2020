using Oracle.ManagedDataAccess.Client;

namespace course_project
{
    partial class Main
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
            this.login_btn = new System.Windows.Forms.Button();
            this.login_edt = new System.Windows.Forms.TextBox();
            this.pwd_edt = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.signup_lnk = new System.Windows.Forms.LinkLabel();
            this.signup_suggestion_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.AutoSize = true;
            this.login_btn.Location = new System.Drawing.Point(59, 90);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(59, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_edt
            // 
            this.login_edt.Location = new System.Drawing.Point(12, 25);
            this.login_edt.Name = "login_edt";
            this.login_edt.Size = new System.Drawing.Size(156, 20);
            this.login_edt.TabIndex = 0;
            // 
            // pwd_edt
            // 
            this.pwd_edt.Location = new System.Drawing.Point(12, 64);
            this.pwd_edt.Name = "pwd_edt";
            this.pwd_edt.PasswordChar = '•';
            this.pwd_edt.Size = new System.Drawing.Size(156, 20);
            this.pwd_edt.TabIndex = 1;
            // 
            // login_lbl
            // 
            this.login_lbl.Location = new System.Drawing.Point(12, 9);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(156, 13);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "Login";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.Location = new System.Drawing.Point(12, 48);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(156, 13);
            this.pwd_lbl.TabIndex = 7;
            this.pwd_lbl.Text = "Password";
            this.pwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signup_lnk
            // 
            this.signup_lnk.AutoSize = true;
            this.signup_lnk.Location = new System.Drawing.Point(120, 120);
            this.signup_lnk.Name = "signup_lnk";
            this.signup_lnk.Size = new System.Drawing.Size(48, 13);
            this.signup_lnk.TabIndex = 3;
            this.signup_lnk.TabStop = true;
            this.signup_lnk.Text = "Sign Up!";
            this.signup_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_lnk_LinkClicked);
            // 
            // signup_suggestion_lbl
            // 
            this.signup_suggestion_lbl.AutoSize = true;
            this.signup_suggestion_lbl.Location = new System.Drawing.Point(13, 120);
            this.signup_suggestion_lbl.Name = "signup_suggestion_lbl";
            this.signup_suggestion_lbl.Size = new System.Drawing.Size(59, 13);
            this.signup_suggestion_lbl.TabIndex = 9;
            this.signup_suggestion_lbl.Text = "New here?";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.signup_suggestion_lbl);
            this.Controls.Add(this.signup_lnk);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.pwd_edt);
            this.Controls.Add(this.login_edt);
            this.Controls.Add(this.login_btn);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_edt;
        private System.Windows.Forms.TextBox pwd_edt;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.LinkLabel signup_lnk;
        private System.Windows.Forms.Label signup_suggestion_lbl;
        private OracleConnection connection;
    }
}

