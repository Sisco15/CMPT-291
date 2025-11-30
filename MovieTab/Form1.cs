using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieTab
{
    public partial class Form1 : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection("user id=group3;" + // Username
                                         "password=group3pass;" + // Password
                                         "server=LAPTOP-U1T93UQT\\MSSQLSERVER01;" + // IP for the server
                                                                                    //"Trusted_Connection=yes;" +
                                         "database=Proj2025F; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds

            try
            {
                connection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = connection; // Link the command stream to the connection

                loadMovies();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "SELECT * FROM Movie WHERE MovieName LIKE '%" + textBox1.Text + "%'";
                myReader = myCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(myReader);
                myReader.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MovieID"].Visible = false;

                myCommand.Parameters.Clear();
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void loadMovies()
        {
            try
            {
                myCommand.CommandText = "SELECT * FROM Movie";
                myReader = myCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(myReader);
                myReader.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MovieID"].Visible = false;
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object movieID = dataGridView1.SelectedRows[0].Cells["MovieID"].Value;

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this movie?",
                    "Delete Movie",
                    MessageBoxButtons.YesNo
                );

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        myCommand.CommandText = @"DELETE FROM ActorAppear WHERE MovieID = " + movieID + ";" +
                            "DELETE FROM Movie WHERE MovieID = " + movieID + ";";

                        myCommand.Parameters.AddWithValue("@MovieID", movieID);
                        myCommand.ExecuteNonQuery();

                        MessageBox.Show("Movie deleted successfully.");

                        loadMovies();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Create addMovie = new Create();
            addMovie.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells["MovieID"].Value);
            string name = row.Cells["MovieName"].Value.ToString();
            string type = row.Cells["MovieType"].Value.ToString();
            string fee = row.Cells["Fee"].Value.ToString();
            string copies = row.Cells["NumOfCopy"].Value.ToString();

            Update updateForm = new Update(id, name, type, fee, copies);

            updateForm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["MovieID"].Value);
                string name = row.Cells["MovieName"].Value.ToString();
                string type = row.Cells["MovieType"].Value.ToString();
                string fee = row.Cells["Fee"].Value.ToString();
                string copies = row.Cells["NumOfCopy"].Value.ToString();

                ViewDetails viewForm = new ViewDetails(id, name, type, fee, copies);
                viewForm.ShowDialog();
            }
        }
    }
}
