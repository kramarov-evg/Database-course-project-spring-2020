using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;

namespace course_project
{
    public partial class Signup : Form
    {
        public Signup(OracleConnection connection, Form parent)
        {
            InitializeComponent();
            this.connection = connection;
            this.parent = parent;
            this.FormClosing += Signup_FormClosing;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                addUser();
                this.Close();
            }
        }

        private Boolean checkFields()
        {
            if ((login_edt.TextLength == 0) || (pwd_edt.TextLength == 0) || rpt_pwd_edt.TextLength == 0)
            {
                return signupError("All fields here are necessary");
            }
            else if (pwd_edt.Text != rpt_pwd_edt.Text)
            {
                return signupError("Passwords don't match");
            } 
            else if (!checkUniqueUsername())
            {
                return signupError("Username must be unique. This username is already taken");
            }
            return true;
        }

        private Boolean signupError(String msg)
        {
            DialogResult result = MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void addUser()
        {
            String query = "INSERT INTO c##egor.users (login, password, privilege) VALUES (:login, :password, :privelege)";
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add(new OracleParameter("login", login_edt.Text));
            cmd.Parameters.Add(new OracleParameter("password", getHash(pwd_edt.Text)));
            cmd.Parameters.Add(new OracleParameter("privelege", 100));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            DialogResult result = MessageBox.Show(
                        "Successfully added user!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Signup_FormClosing(Object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
        private void signup_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signupForm = new Signup(this.connection, this);
            this.Hide();
            signupForm.ShowDialog();
        }
        public static string getHash(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private bool checkUniqueUsername()
        {
            String query = "SELECT * FROM c##egor.users \"users\" WHERE \"users\".login = :login";
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add(new OracleParameter("login", login_edt.Text));
            connection.Open();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    connection.Close();
                    return false;
                }
                connection.Close();
            }
            connection.Close();
            return true;
        }
    }
}
