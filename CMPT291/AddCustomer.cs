using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291
{
    public partial class addCust : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public addCust()
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection("user id=group3;" + // Username
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

        }


 

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsPlaceholderOrEmpty(nameBox, "Full Name") ||
                IsPlaceholderOrEmpty(addressBox, "Address") ||
                IsPlaceholderOrEmpty(cityBox, "City") ||
                IsPlaceholderOrEmpty(provinceBox, "Province") ||
                IsPlaceholderOrEmpty(postalCodeBox, "Postal Code") ||
                IsPlaceholderOrEmpty(emailBox, "Email") ||
                IsPlaceholderOrEmpty(accountBox, "Account Number") ||
                IsPlaceholderOrEmpty(cardNum, "Credit Card Number") ||
                IsPlaceholderOrEmpty(expirationBox, "Credit Card Exp.") ||
                IsPlaceholderOrEmpty(cVVBox, "Credit Card CVV"))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information",
                                MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] fullName = nameBox.Text.Split();
                if (fullName.Length != 2)
                {
                    MessageBox.Show("Input a FullName", "Error", MessageBoxButtons.OK);
                    return;
                }
                string firstName = fullName[0];
                string lastName = fullName[1];
                myCommand.CommandText = "INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv) VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, '" + lastName
                    + "', '" + firstName + "' , '" + addressBox.Text + "' , '" + cityBox.Text + "' , '" + provinceBox.Text + "', '" + postalCodeBox.Text + "', '" + emailBox.Text + "', '" + accountBox.Text + "', '" + cardNum.Text + "', '" +
                    expirationBox.Text + "', '" + cVVBox.Text + "')";

                MessageBox.Show("Added Customer","Success" ,MessageBoxButtons.OK);
                myCommand.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
        private bool IsPlaceholderOrEmpty(TextBox box, string placeholder)
        {
            return string.IsNullOrWhiteSpace(box.Text) || box.Text == placeholder;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
