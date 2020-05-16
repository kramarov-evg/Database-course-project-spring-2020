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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.connection = GetDBConnection("127.0.0.1", 1521, "xe", "c##egor", "pass");
        }

        private static OracleConnection GetDBConnection(string host, int port, String sid, String user, String password)
        {
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
            
            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String login = this.login_edt.Text;
            String password = getHash(this.pwd_edt.Text);
            String fetched_password = get_password(login);
            if (password == fetched_password)
            {
                Console.WriteLine("FINE");
            } else if (fetched_password != "")
            {
                DialogResult result = MessageBox.Show("Invalid password", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String get_password(String login)
        {
            String query = "SELECT login, password FROM c##egor.users \"users\" WHERE \"users\".login = :login";
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add(new OracleParameter("login", login));
            String password = "";
            connection.Open();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    password = reader.GetString(1);
                    connection.Close();
                } else
                {
                    connection.Close();
                    DialogResult result = MessageBox.Show(
                        "There's no user with this login.\nWould you like to sign up?",
                        "Sign up?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Form signupForm = new Signup(this.connection, this);
                        this.Hide();
                        signupForm.ShowDialog();
                    }
                }
            }
            return password;
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
    }
}


//OracleConnection test = GetDBConnection("127.0.0.1", 1521, "xe", "c##egor", "pass");
//test.Open();
//string sql = "Select 42 from dual";
//OracleCommand cmd = new OracleCommand();
//cmd.Connection = test;
//cmd.CommandText = sql;
//using (DbDataReader reader = cmd.ExecuteReader())
//{
//    if (reader.HasRows)
//    {

//        while (reader.Read())
//        {
//            long empId = Convert.ToInt64(reader.GetValue(0));
//            Console.WriteLine("empIdIndex:" + empId);
//        }
//    }
//}
//test.Close();