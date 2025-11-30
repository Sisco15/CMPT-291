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

namespace CMPT291
{
    public partial class ViewDetails : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private int movieID;

        public ViewDetails(int MovieID, string name, string type, string fee, string copies)
        {
            InitializeComponent();
            this.movieID = MovieID;

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

                loadDetails(MovieID, name, type, fee, copies);
                loadActors();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void loadDetails(int MovieID, string name, string type, string fee, string copies)
        {
            lbID.Text = MovieID.ToString();
            lbName.Text = name;
            lbType.Text = type;
            movieFee.Text = fee;
            lbCopy.Text = copies;
        }

        private void loadActors()
        {
            try
            {
                myCommand.CommandText = @"
                    SELECT A.ActorID, A.Name, A.Gender, A.DateOfBrith
                    FROM Actor A
                    INNER JOIN ActorAppear AA ON A.ActorID = AA.ActorID
                    WHERE AA.MovieID = " + movieID;

                myCommand.Parameters.AddWithValue("@MovieID", movieID);
                myReader = myCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(myReader);
                myReader.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["ActorID"].Visible = false;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            addActor add = new addActor(movieID);
            add.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            myCommand.Parameters.Clear();
            loadActors();
        }
    }
}
