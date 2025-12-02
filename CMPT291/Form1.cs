using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
namespace CMPT291
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection("user id=group3;" + // Username
                                    "password=group3pass;" + // Password
                                    "server=localhost;" + // IP for the server
                                                          //"Trusted_Connection=yes;" +
                                    "database=CMPT291_proj; " + // Database to connect to
                                    "connection timeout=30"); // Timeout in seconds 

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        public string ComputeMd5Hash(string rawData)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                myCommand.CommandText = "select EmployeeID from user_log where username = '" + textBox1.Text + "' and pass_word = '" + ComputeMd5Hash(textBox2.Text) + "'";
                //MessageBox.Show(myCommand.CommandText);

                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Succsess");
                        
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                            //MessageBox.Show(id.ToString());
                            this.Hide();
                            Form2 mainForm = new Form2(id);
                            mainForm.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

