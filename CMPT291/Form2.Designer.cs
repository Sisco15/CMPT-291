namespace CMPT291
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomerList = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            AccountNum = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Province = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            tabs = new TabControl();
            Customer = new TabPage();
            select = new Button();
            delButton = new Button();
            addButton = new Button();
            searchBox = new TextBox();
            modify = new Button();
            tabPage2 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)CustomerList).BeginInit();
            tabs.SuspendLayout();
            Customer.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerList
            // 
            CustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerList.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FirstName, LastName, AccountNum, Email, Province, City });
            CustomerList.Location = new Point(0, 34);
            CustomerList.Name = "CustomerList";
            CustomerList.RowHeadersWidth = 51;
            CustomerList.Size = new Size(771, 216);
            CustomerList.TabIndex = 0;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Visible = false;
            CustomerID.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // AccountNum
            // 
            AccountNum.HeaderText = "AccountNum";
            AccountNum.MinimumWidth = 6;
            AccountNum.Name = "AccountNum";
            AccountNum.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Province
            // 
            Province.HeaderText = "Province";
            Province.MinimumWidth = 6;
            Province.Name = "Province";
            Province.Width = 125;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // tabs
            // 
            tabs.Controls.Add(Customer);
            tabs.Controls.Add(tabPage2);
            tabs.Location = new Point(11, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(784, 438);
            tabs.TabIndex = 1;
            // 
            // Customer
            // 
            Customer.Controls.Add(select);
            Customer.Controls.Add(delButton);
            Customer.Controls.Add(addButton);
            Customer.Controls.Add(searchBox);
            Customer.Controls.Add(modify);
            Customer.Controls.Add(CustomerList);
            Customer.Location = new Point(4, 29);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(776, 405);
            Customer.TabIndex = 0;
            Customer.Text = "Customers";
            Customer.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            select.Location = new Point(647, 3);
            select.Name = "select";
            select.RightToLeft = RightToLeft.Yes;
            select.Size = new Size(126, 25);
            select.TabIndex = 6;
            select.Text = "Search";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(6, 367);
            delButton.Name = "delButton";
            delButton.RightToLeft = RightToLeft.Yes;
            delButton.Size = new Size(133, 32);
            delButton.TabIndex = 5;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(624, 358);
            addButton.Name = "addButton";
            addButton.RightToLeft = RightToLeft.Yes;
            addButton.Size = new Size(133, 32);
            addButton.TabIndex = 4;
            addButton.Text = "Add Customer";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(1, 1);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(633, 27);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search";
            // 
            // modify
            // 
            modify.Location = new Point(624, 265);
            modify.Name = "modify";
            modify.RightToLeft = RightToLeft.Yes;
            modify.Size = new Size(133, 32);
            modify.TabIndex = 2;
            modify.Text = "Modify";
            modify.UseVisualStyleBackColor = true;
            modify.Click += modify_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabs);
            Name = "Form2";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)CustomerList).EndInit();
            tabs.ResumeLayout(false);
            Customer.ResumeLayout(false);
            Customer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CustomerList;
        private TabControl tabs;
        private TabPage Customer;
        private TabPage tabPage2;
        private Button modify;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox searchBox;
        private Button delButton;
        private Button addButton;
        private Button select;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn AccountNum;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn City;
    }
}