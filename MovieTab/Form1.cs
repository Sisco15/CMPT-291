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
            loadMovies();
            loadActors();
        }

        private void loadMovies()
        {
            String connectionString = "Server = LAPTOP-U1T93UQT\\MSSQLSERVER01;Database = Proj2025F;Trusted_Connection = True;";
            String SQL = "SELECT * FROM Movie";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter movieAdapter = new SqlDataAdapter(SQL, connection);

            DataSet ds = new DataSet();

            connection.Open();
            movieAdapter.Fill(ds);
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void loadActors()
        {
            String connectionString = "Server = LAPTOP-U1T93UQT\\MSSQLSERVER01;Database = Proj2025F;Trusted_Connection = True;";
            String SQL = "SELECT * FROM Actor";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter movieAdapter = new SqlDataAdapter(SQL, connection);

            DataSet ds = new DataSet();

            connection.Open();
            movieAdapter.Fill(ds);
            connection.Close();

            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = LAPTOP-U1T93UQT\\MSSQLSERVER01;Database = Proj2025F;Trusted_Connection = True;";
            String SQL = "SELECT * FROM Movie WHERE MovieName LIKE @search";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter movieAdapter = new SqlDataAdapter(SQL, connection);

            movieAdapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");

            DataSet ds = new DataSet();

            connection.Open();
            movieAdapter.Fill(ds);
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
