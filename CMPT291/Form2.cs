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

        //String connectionString = "user id=group3;" + "password=group3pass;" + "server=localhost;" + "database=CMPT291_Proj;";





        //SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds
        myConnection = new SqlConnection("user id=group3;" + // Username
                                     "password=group3pass;" + // Password
                                     "server=localhost;" + // IP for the server
                                                           //"Trusted_Connection=yes;" +
                                     "database=CMPT291_proj; " + // Database to connect to
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


    private void select_Click(object sender, EventArgs e)
    {
        SqlCommand myCommand;
        string sql;
        if (IsPlaceholderOrEmpty(searchBox, "Search"))
        {
            sql = "select * from customer";
            myCommand = new SqlCommand(sql, myConnection);
        }
        else
        {
            sql = @"SELECT * FROM Customer WHERE FirstName + ' ' + LastName LIKE @search or FirstName LIKE @search OR LastName LIKE @search OR AccountNum LIKE @search OR Email LIKE @search";

            myCommand = new SqlCommand(sql, myConnection);
            myCommand.Parameters.AddWithValue("@search", "%" + searchBox.Text + "%");
        }

        try
        {
            //MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();
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
}




