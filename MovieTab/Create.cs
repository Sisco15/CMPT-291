using System.Data.SqlClient;
namespace MovieTab
{
    public partial class Create : Form
    {
        public SqlConnection connection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Create()
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

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {

                myCommand.CommandText = "INSERT into MOVIE values ('" + tbName.Text + "'" + ", '" + tbType.Text + "', " + tbFee.Text + ", " + tbCopy.Text + ")";
                MessageBox.Show("Movie successfully added.");

                myCommand.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
