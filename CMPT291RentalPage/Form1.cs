using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CMPT291RentalPage
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        // Hard coded employee
        int employeeID = 1000;

        public Form1()
        {
            InitializeComponent();

            // Setup Customer Queue columns
            dgvQueue.ColumnCount = 2;
            dgvQueue.Columns[0].Name = "Movie Name";
            dgvQueue.Columns[1].Name = "Sort Number";
            dgvQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQueue.ReadOnly = true;
            dgvQueue.DefaultCellStyle.SelectionBackColor = dgvQueue.DefaultCellStyle.BackColor;
            dgvQueue.DefaultCellStyle.SelectionForeColor = dgvQueue.DefaultCellStyle.ForeColor;


            // Setup Rented Movies Grid
            dgvRented.ColumnCount = 2;
            dgvRented.Columns[0].Name = "Movie Name";
            dgvRented.Columns[1].Name = "Checkout Time";
            dgvRented.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRented.ReadOnly = true;
            dgvRented.DefaultCellStyle.SelectionBackColor = dgvQueue.DefaultCellStyle.BackColor;
            dgvRented.DefaultCellStyle.SelectionForeColor = dgvQueue.DefaultCellStyle.ForeColor;



            String connectionString = "Data Source=DESKTOP-PKV5THG; Initial Catalog=lab3; Integrated Security=True; TrustServerCertificate=True;";


            try
            {
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Connection Error");
                this.Close();
            }
        }

        private void LoadCustomers()
        {
            try
            {
                cmbCustomer.Items.Clear();

                myCommand.CommandText =
                    "SELECT CustomerID, FirstName + ' ' + LastName AS FullName FROM Customer";

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader["CustomerID"] != DBNull.Value &&
                        myReader["FullName"] != DBNull.Value)
                    {
                        cmbCustomer.Items.Add(
                            new ComboItem(
                                myReader["FullName"].ToString() ?? "",
                                Convert.ToInt32(myReader["CustomerID"])
                            )
                        );
                    }
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error loading customers");
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMovie.Items.Clear();
            cmbMovie.Text = "";

            if (cmbCustomer.SelectedItem == null) return;

            ComboItem cust = (ComboItem)cmbCustomer.SelectedItem;
            LoadQueue(cust.Value);
            LoadRentedMovies(cust.Value);
        }

        private void LoadQueue(int customerID)
        {
            try
            {
                dgvQueue.Rows.Clear();
                cmbMovie.Items.Clear();

                myCommand.CommandText =
                    "SELECT cq.MovieID, m.MovieName, cq.SortNum " +
                    "FROM CustomerQueue cq, Movie m " +
                    "WHERE cq.CustomerID = @CID and cq.MovieID = m.MovieID " +
                    "ORDER BY cq.SortNum";

                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@CID", customerID);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    int movieID = Convert.ToInt32(myReader["MovieID"]);
                    string movieName = myReader["MovieName"].ToString() ?? "";
                    int sortNum = Convert.ToInt32(myReader["SortNum"]);

                    dgvQueue.Rows.Add(movieName, sortNum);
                    cmbMovie.Items.Add(new ComboItem(movieName, movieID));
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error loading queue");
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedItem == null || cmbMovie.SelectedItem == null)
                {
                    MessageBox.Show("Select a customer and a movie.");
                    return;
                }

                ComboItem cust = (ComboItem)cmbCustomer.SelectedItem;
                ComboItem movie = (ComboItem)cmbMovie.SelectedItem;

                // Check if the movie is already being rented
                if (CustomerAlreadyRenting(cust.Value, movie.Value))
                {
                    MessageBox.Show("This customer is already renting this movie. It must be returned before renting again.");
                    return;
                }

                // Insert rental record
                myCommand.Parameters.Clear();
                myCommand.CommandText =
                    "INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate) " +
                    "VALUES (@Emp, @Cust, @Movie, NULL)";

                myCommand.Parameters.AddWithValue("@Emp", employeeID);
                myCommand.Parameters.AddWithValue("@Cust", cust.Value);
                myCommand.Parameters.AddWithValue("@Movie", movie.Value);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Movie rented successfully");

                cmbMovie.Items.Clear();
                cmbMovie.Text = "";

                // Refresh displays
                LoadQueue(cust.Value);
                LoadRentedMovies(cust.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Rental Error");
            }
        }

        private void LoadRentedMovies(int customerID)
        {
            try
            {
                dgvRented.Rows.Clear();

                myCommand.Parameters.Clear();
                myCommand.CommandText =
                    "SELECT rr.RentalRecordID, m.MovieName, rr.CheckoutTime " +
                    "FROM RentalRecord rr " +
                    "JOIN Movie m ON rr.MovieID = m.MovieID " +
                    "WHERE rr.CustomerID = @CID AND rr.ReturnTime IS NULL";

                myCommand.Parameters.AddWithValue("@CID", customerID);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    dgvRented.Rows.Add(
                        myReader["MovieName"].ToString(),
                        myReader["CheckoutTime"].ToString()
                    );
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error loading rented movies");
            }
        }
        private bool CustomerAlreadyRenting(int customerID, int movieID)
        {
            myCommand.Parameters.Clear();
            myCommand.CommandText =
                "SELECT COUNT(*) FROM RentalRecord " +
                "WHERE CustomerID = @Cust AND MovieID = @Movie AND ReturnTime IS NULL";

            myCommand.Parameters.AddWithValue("@Cust", customerID);
            myCommand.Parameters.AddWithValue("@Movie", movieID);

            int count = (int)myCommand.ExecuteScalar();
            return count > 0;
        }
    }


    public class ComboItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}

