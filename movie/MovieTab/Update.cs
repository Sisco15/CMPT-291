using System.Data.SqlClient;
namespace MovieTab
{
    public partial class Update : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private int movieID;

        public Update(int MovieID, string name, string type, string fee, string copies)
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection("user id=Group3;" + // Username
                                         "password=pass;" + // Password
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

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void loadDetails(int MovieID, string name, string type, string fee, string copies)
        {
            movieID = MovieID;
            tbName.Text = name;
            tbType.Text = type;
            tbFee.Text = fee;
            tbCopy.Text = copies;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "UPDATE MOVIE SET MovieName = '" + tbName.Text + "', " +
                    "MovieType = '" + tbType.Text + "', " +
                    "Fee = " + tbFee.Text + ", " +
                    "NumOfCopy = " + tbCopy.Text + " " +
                    "WHERE MovieID = " + movieID;

                myCommand.Parameters.AddWithValue("@MovieName", tbName.Text);
                myCommand.Parameters.AddWithValue("@MovieType", tbType.Text);
                myCommand.Parameters.AddWithValue("@Fee", tbFee.Text);
                myCommand.Parameters.AddWithValue("@NumOfCopy", tbCopy.Text);

                MessageBox.Show(myCommand.CommandText);
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
