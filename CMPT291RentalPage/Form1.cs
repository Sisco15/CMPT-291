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
        List<ComboItem> allCustomers = new List<ComboItem>();


        public Form1()
        {
            InitializeComponent();

            // Setup Customer Queue columns
            dgvQueue.ColumnCount = 3;
            dgvQueue.Columns[0].Name = "Movie Name";
            dgvQueue.Columns[1].Name = "Sort Number";
            dgvQueue.Columns[2].Name = "Available Copies";
            dgvQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQueue.ReadOnly = true;
            dgvQueue.DefaultCellStyle.SelectionBackColor = dgvQueue.DefaultCellStyle.BackColor;
            dgvQueue.DefaultCellStyle.SelectionForeColor = dgvQueue.DefaultCellStyle.ForeColor;


            // Setup Rented Movies Grid
            dgvRented.ColumnCount = 3;
            dgvRented.Columns[0].Name = "Movie Name";
            dgvRented.Columns[1].Name = "Checkout Time";
            dgvRented.Columns[2].Name = "Returned";
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

        private ComboItem selectedCustomer = null;
        private void LoadCustomers()
        {
            try
            {
                allCustomers.Clear();

                myCommand.CommandText =
                    "SELECT CustomerID, FirstName + ' ' + LastName AS FullName FROM Customer";

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader["CustomerID"] != DBNull.Value &&
                        myReader["FullName"] != DBNull.Value)
                    {
                        allCustomers.Add(
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

        private void LoadQueue(int customerID)
        {
            try
            {
                dgvQueue.Rows.Clear();
                cmbMovie.Items.Clear();

                myCommand.CommandText =
                    "SELECT cq.MovieID, m.MovieName, cq.SortNum, m.NumOfCopy " +
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
                    int copies = Convert.ToInt32(myReader["NumOfCopy"]);
                    dgvQueue.Rows.Add(movieName, sortNum, copies);
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
                if (selectedCustomer == null)
                {
                    MessageBox.Show("Select a customer first.");
                    return;
                }

                if (cmbMovie.SelectedItem == null)
                {
                    MessageBox.Show("Select a movie.");
                    return;
                }

                ComboItem cust = selectedCustomer;
                ComboItem movie = (ComboItem)cmbMovie.SelectedItem;

                // Check if already renting
                if (CustomerAlreadyRenting(cust.Value, movie.Value))
                {
                    MessageBox.Show("This customer is already renting this movie.");
                    return;
                }

                if (!CopiesAvailable(movie.Value))
                {
                    MessageBox.Show("No copies available to rent.");
                    return;
                }

                myCommand.Parameters.Clear();
                myCommand.CommandText =
                    "UPDATE Movie SET NumOfCopy = NumOfCopy - 1 WHERE MovieID = @Movie";
                myCommand.Parameters.AddWithValue("@Movie", movie.Value);
                myCommand.ExecuteNonQuery();

                myCommand.Parameters.Clear();
                myCommand.CommandText =
                    "INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate) " +
                    "VALUES (@Emp, @Cust, @Movie, NULL)";

                myCommand.Parameters.AddWithValue("@Emp", employeeID);
                myCommand.Parameters.AddWithValue("@Cust", cust.Value);
                myCommand.Parameters.AddWithValue("@Movie", movie.Value);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Movie rented successfully!");

                cmbMovie.Items.Clear();
                cmbMovie.Text = "";

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
                    "SELECT m.MovieName, rr.CheckoutTime, rr.ReturnTime " +
                    "FROM RentalRecord rr, Movie m " +
                    "WHERE rr.CustomerID = @CID and rr.MovieID = m.MovieID";


                myCommand.Parameters.AddWithValue("@CID", customerID);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string movieName = myReader["MovieName"].ToString();
                    string checkout = myReader["CheckoutTime"].ToString();
                    string returned;
                    if (myReader["ReturnTime"] == DBNull.Value)
                        returned = "No";
                    else
                        returned = "Yes";

                    dgvRented.Rows.Add(movieName, checkout, returned);
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

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchCustomer.Text.Trim().ToLower();
            lstCustomerResults.Items.Clear();

            if (string.IsNullOrEmpty(search))
            {
                lstCustomerResults.Visible = false;
                return;
            }

            List<ComboItem> matches = new List<ComboItem>();

            foreach (ComboItem c in allCustomers)
            {
                if (c.Text.ToLower().Contains(search))
                {
                    matches.Add(c);
                    lstCustomerResults.Items.Add(c);
                }
            }

            lstCustomerResults.Visible = matches.Count > 0;


        }

        private void lstCustomerResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomerResults.SelectedItem is ComboItem customer)
            {
                selectedCustomer = customer;
                txtSearchCustomer.Text = customer.Text;
                lstCustomerResults.Visible = false;

                int customerID = customer.Value;
                LoadQueue(customerID);
                LoadRentedMovies(customerID);
            }
        }
        private bool CopiesAvailable(int movieID)
        {
            myCommand.Parameters.Clear();
            myCommand.CommandText = "SELECT NumOfCopy FROM Movie WHERE MovieID = @M";
            myCommand.Parameters.AddWithValue("@M", movieID);

            int copies = Convert.ToInt32(myCommand.ExecuteScalar());
            return copies > 0;
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

