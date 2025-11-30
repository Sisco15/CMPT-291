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
    public partial class Form4 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public int customerId;

        public Form4(int id)
        {
            InitializeComponent();
            customerId = id;
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            loadCustomer();



        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            var updates = new List<string>();
            var command = new SqlCommand();
            command.Connection = myConnection;
            if (!isPlaceholderOrEmpty(firstNameBox, "First Name"))
            {
                updates.Add("FirstName = @FirstName");
                command.Parameters.AddWithValue("@FirstName", firstNameBox.Text);
            }
            if (!isPlaceholderOrEmpty(lastNameBox, "Last Name"))
            {
                updates.Add("LastName = @LastName");
                command.Parameters.AddWithValue("@LastName", lastNameBox.Text);
            }
            if (!isPlaceholderOrEmpty(emailBox, "Email"))
            {
                updates.Add("Email = @Email");
                command.Parameters.AddWithValue("@Email", emailBox.Text);
            }
            if (!isPlaceholderOrEmpty(accountBox, "Account Number"))
            {
                updates.Add("AccountNum = @AccountNum");
                command.Parameters.AddWithValue("@AccountNum", accountBox.Text);
            }
            if (!isPlaceholderOrEmpty(cityBox, "City"))
            {
                updates.Add("City = @City");
                command.Parameters.AddWithValue("@City", cityBox.Text);
            }
            if (!isPlaceholderOrEmpty(provinceBox, "Province"))
            {
                updates.Add("Province = @Province");
                command.Parameters.AddWithValue("@Province", provinceBox.Text);
            }
            if (!isPlaceholderOrEmpty(addressBox, "Address"))
            {
                updates.Add("Address = @Address");
                command.Parameters.AddWithValue("@Address", addressBox.Text);
            }
            if (!isPlaceholderOrEmpty(postalCodeBox, "Postal Code") && postalCodeBox.Text.Length <= 6)
            {
                updates.Add("PostalCode = @PostalCode");
                command.Parameters.AddWithValue("@PostalCode", postalCodeBox.Text);
            }
            if (!isPlaceholderOrEmpty(cardNum, "Credit Card Number"))
            {
                updates.Add("CreditCardNum = @CreditCardNum");
                command.Parameters.AddWithValue("@CreditCardNum", cardNum.Text);
            }
            if (!isPlaceholderOrEmpty(expirationBox, "Credit Card Exp."))
            {
                updates.Add("CreditCardExp = @CreditCardExp");
                command.Parameters.AddWithValue("@CreditCardExp", expirationBox.Text);
            }
            if (!isPlaceholderOrEmpty(cVVBox, "Credit Card CVV"))
            {
                updates.Add("CreditCardCvv = @CreditCardCvv");
                command.Parameters.AddWithValue("@CreditCardCvv", cVVBox.Text);
            }
            if (updates.Count == 0)
            {
                MessageBox.Show("No fields to update.");
                return;
            }
            string updateSql = string.Join(", ", updates);
            command.CommandText = $"UPDATE Customer SET {updateSql} WHERE CustomerID = @ID";
            command.Parameters.AddWithValue("@ID", customerId);

            command.ExecuteNonQuery();
            MessageBox.Show("Customer information updated successfully.");
            loadCustomer();
        }

        private bool isPlaceholderOrEmpty(TextBox box, string placeholder)
        {
            return string.IsNullOrWhiteSpace(box.Text) || box.Text == placeholder;
        }

        private void loadCustomer()
        {
            myCommand.CommandText = "select * from Customer Where CustomerID = " + customerId;

            myReader = myCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader["FirstName"].ToString(), myReader["LastName"], myReader["Email"].ToString(), myReader["AccountNum"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(),
                    myReader["Address"].ToString(), myReader["PostalCode"].ToString());
            }

            myReader.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
