using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMPT291
{
    public partial class Update : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private int movieID;

        public Update(int MovieID, string name, string type, string fee, string copies, string rating)
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection("user id=group3;" + // Username
                                    "password=group3pass;" + // Password
                                    "server=localhost;" + // IP for the server
                                                          //"Trusted_Connection=yes;" +
                                    "database=CMPT291_proj; " + // Database to connect to
                                    "connection timeout=30"); // Timeout in seconds 
            try
            {
                connection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = connection; // Link the command stream to the connection

                loadDetails(MovieID, name, type, fee, copies, rating);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void loadDetails(int MovieID, string name, string type, string fee, string copies, string rating)
        {
            movieID = MovieID;
            tbName.Text = name;
            tbType.Text = type;
            tbFee.Text = fee;
            tbCopy.Text = copies;
            tbRate.Text = rating;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "UPDATE Movie SET " +

                    "MovieName = @MovieName, " +
                    "MovieType = @MovieType, " +
                    "Fee = @Fee, " +
                    "NumOfCopy = @NumOfCopy, " +
                    "MovieAveRate = @MovieAveRate " +
                    "WHERE MovieID = @MovieID";

                myCommand.Parameters.AddWithValue("@MovieName", tbName.Text);
                myCommand.Parameters.AddWithValue("@MovieType", tbType.Text);
                myCommand.Parameters.AddWithValue("@Fee", tbFee.Text);
                myCommand.Parameters.AddWithValue("@NumOfCopy", tbCopy.Text);
                myCommand.Parameters.AddWithValue("@MovieAveRate", tbRate.Text);
                myCommand.Parameters.AddWithValue("@MovieID", movieID);

                //MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }
    }
}


