using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MovieTab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = LAPTOP-U1T93UQT\\MSSQLSERVER01;Database=Proj2025F;Trusted_Connection=True;";
            String SQL = "SELECT * FROM Movie";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter datadapter = new SqlDataAdapter(SQL, connection);
            DataSet ds = new DataSet();
            connection.Open();
            datadapter.Fill(ds);
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
