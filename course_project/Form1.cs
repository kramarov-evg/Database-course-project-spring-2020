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

namespace course_project
{
    public partial class Form1 : Form
    {
        public Form1()
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
            String password = this.pwd_edt.Text;
            String fetched_password = get_password(login);
            if (password == fetched_password)
            {
                Console.WriteLine("FINE");
            } else
            {
                // TODO: add Form for incorrect password
            }
        }

        private String get_password(String login)
        {
            String query = "SELECT login, password FROM c##egor.users \"users\" WHERE \"users\".login = @login";
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            OracleParameter login_param = cmd.Parameters.Add("@login", SqlDbType.VarChar);
            login_param.Value = login;
            String password = "";
            this.connection.Open();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    password = reader.GetString(0);
                } else
                {
                    // TODO: add Form for user inexistance suggesting to sign up
                }
            }
            return password;
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