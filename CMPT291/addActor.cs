using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMPT291
{
    public partial class addActor : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private int movieID;

        public addActor(int movieID)
        {
            InitializeComponent();
            this.movieID = movieID;

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

                loadActors();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void loadActors()
        {
            myCommand.CommandText = @"
                SELECT A.ActorID, A.Name, A.Gender, A.DateOfBrith
                FROM Actor A
                WHERE A.ActorID NOT IN (
                SELECT ActorID FROM ActorAppear WHERE MovieID = " + movieID + ")";

            myCommand.Parameters.AddWithValue("@MovieID", movieID);

            myReader = myCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myReader);
            myReader.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ActorID"].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int actorID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ActorID"].Value);

                myCommand.CommandText = "INSERT INTO ActorAppear VALUES (@MovieID, @ActorID)";
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@MovieID", movieID);
                myCommand.Parameters.AddWithValue("@ActorID", actorID);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Actor successfully added");
                this.Close();
            }
            else
                MessageBox.Show("Select an actor first!");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
