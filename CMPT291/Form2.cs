using Microsoft.VisualBasic.Devices;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CMPT291;

public partial class Form2 : Form
{
    private int employeeId;
    public SqlConnection myConnection;
    public SqlCommand myCommand;
    public SqlDataReader myReader;
    public Form2(int id)
    {
        InitializeComponent();
        employeeId = id;

        //String connectionString = "Server = DESKTOP-LGGJQU9; Database = CMPT291_AS2; Trusted_Connection = true;"; //comment

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

        //report 1 and 2
        comboBox1.Items.Add("Action");
        comboBox1.Items.Add("Drama");
        comboBox1.Items.Add("Comedy");
        comboBox1.Items.Add("Foreign");

        comboBox2.Items.Add("Action");
        comboBox2.Items.Add("Drama");
        comboBox2.Items.Add("Comedy");
        comboBox2.Items.Add("Foreign");

        //SqlConnection myConnection = new SqlConnection(connectionString); //comment
        myConnection = new SqlConnection("user id=group3;" + // Username
                                         "password=group3pass;" + // Password
                                         "server=LAPTOP-U1T93UQT\\MSSQLSERVER01;" + // IP for the server
                                                                                    //"Trusted_Connection=yes;" +
                                         "database=Proj2025F; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds

        try
        {
            myConnection.Open(); // Open connection
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Link the command stream to the connection
            LoadCustomers();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString(), "Error");
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

            myCommand.Parameters.AddWithValue("@Emp", employeeId);
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



    // ----------------------------------------------------------------------------------------------



    private void select_Click(object sender, EventArgs e)
    {
        SqlCommand localCommand;
        string sql;
        if (IsPlaceholderOrEmpty(searchBox, "Search"))
        {
            sql = "select * from customer";
            localCommand = new SqlCommand(sql, myConnection);
        }
        else
        {
            sql = @"SELECT * FROM Customer WHERE FirstName + ' ' + LastName LIKE @search or FirstName LIKE @search OR LastName LIKE @search OR AccountNum LIKE @search OR Email LIKE @search";

            localCommand = new SqlCommand(sql, myConnection);
            localCommand.Parameters.AddWithValue("@search", "%" + searchBox.Text + "%");
        }

        try
        {
            //MessageBox.Show(myCommand.CommandText);
            myReader = localCommand.ExecuteReader();
            CustomerList.Rows.Clear();

            while (myReader.Read())
            {
                CustomerList.Rows.Add(myReader["CustomerID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"], myReader["AccountNum"].ToString(), myReader["Email"].ToString(), myReader["Province"].ToString(), myReader["City"].ToString());
            }

            myReader.Close();
        }
        catch (Exception e3)
        {
            MessageBox.Show(e3.ToString(), "Error");
        }

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void addButton_Click(object sender, EventArgs e)
    {
        addCust custForm = new addCust();
        custForm.ShowDialog();
    }

    private void delButton_Click(object sender, EventArgs e)
    {
        if (CustomerList.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = CustomerList.SelectedRows[0];

            DialogResult delResult = MessageBox.Show("Are you sure you want to delete " + selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString(), "Customer Delete",
                MessageBoxButtons.YesNoCancel);

            if (delResult == DialogResult.Yes)
            {
                myCommand.CommandText = "DELETE From Customer where CustomerID = " + Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted: " + " " + selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString(), "Customer Deleted");


                myCommand.CommandText = "select * from customer";

                myReader = myCommand.ExecuteReader();
                CustomerList.Rows.Clear();

                while (myReader.Read())
                {
                    CustomerList.Rows.Add(myReader["CustomerID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"], myReader["AccountNum"].ToString(), myReader["Email"].ToString(), myReader["Province"].ToString(), myReader["City"].ToString());
                }

                myReader.Close();

            }
        }
        else
        {
            MessageBox.Show("No Customer Row Selected", "Error Deleting");
        }
    }
    private bool IsPlaceholderOrEmpty(TextBox box, string placeholder)
    {
        return string.IsNullOrWhiteSpace(box.Text) || box.Text == placeholder;
    }

    private void modify_Click(object sender, EventArgs e)
    {
        if (CustomerList.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = CustomerList.SelectedRows[0];
            Form4 modifyForm = new Form4(Convert.ToInt32(selectedRow.Cells["CustomerID"].Value));

            modifyForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("No Customer Row Selected", "Error Modifying");
        }

    }



    // -------------------------------------------------------------------------------------------------

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

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedItem == null)
        {
            MessageBox.Show("Please select a genre first.");
            return;
        }



        myCommand.CommandText = @"
        WITH RankedMovies AS (
        SELECT MovieName, CheckoutTime, MovieAveRate, MovieType,DENSE_RANK() OVER (PARTITION BY M.MovieType ORDER BY M.MovieAveRate DESC) AS Top3
        FROM RentalRecord AS R
        JOIN Movie AS M ON M.MovieID = R.MovieID
        WHERE R.CheckoutTime >= DATEADD(MONTH, -3, GETDATE()) AND M.MovieType = @Genre)
        SELECT MovieName, Top3, MovieAveRate, MovieType
        FROM RankedMovies
        WHERE Top3 <= 3
        ORDER BY MovieType, MovieAveRate DESC;";


        myCommand.Parameters.Clear();
        myCommand.Parameters.AddWithValue("@Genre", comboBox1.SelectedItem.ToString());


        DataTable dt = new DataTable();
        using (SqlDataAdapter adapter = new SqlDataAdapter(myCommand))
        {
            adapter.Fill(dt);
        }

        // Bind the DataTable to the DataGridView
        Form popup = new Form();
        popup.Text = "Top Movies by Genre";
        popup.Size = new Size(800, 600);

        // Create DataGridView and bind
        DataGridView dgv = new DataGridView();
        dgv.Dock = DockStyle.Fill;
        dgv.DataSource = dt;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Add DataGridView to the form
        popup.Controls.Add(dgv);

        // Show as a modal popup
        popup.ShowDialog();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedItem == null)
        {
            MessageBox.Show("Please select a genre first.");
            return;
        }



        myCommand.CommandText = @"";


        myCommand.Parameters.Clear();
        myCommand.Parameters.AddWithValue("@Genre", comboBox1.SelectedItem.ToString());


        DataTable dt = new DataTable();
        using (SqlDataAdapter adapter = new SqlDataAdapter(myCommand))
        {
            adapter.Fill(dt);
        }

        // Bind the DataTable to the DataGridView
        Form popup = new Form();
        popup.Text = "Top Movies by Genre";
        popup.Size = new Size(800, 600);

        // Create DataGridView and bind
        DataGridView dgv = new DataGridView();
        dgv.Dock = DockStyle.Fill;
        dgv.DataSource = dt;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Add DataGridView to the form
        popup.Controls.Add(dgv);

        // Show as a modal popup
        popup.ShowDialog();
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


