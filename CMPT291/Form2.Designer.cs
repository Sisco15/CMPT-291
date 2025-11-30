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
            btnRent = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvRented = new DataGridView();
            dgvQueue = new DataGridView();
            cmbMovie = new ComboBox();
            cmbCustomer = new ComboBox();
            MoviesTab = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ReportsTab = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)CustomerList).BeginInit();
            tabs.SuspendLayout();
            Customer.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRented).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            MoviesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CustomerList
            // 
            CustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerList.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FirstName, LastName, AccountNum, Email, Province, City });
            CustomerList.Location = new Point(0, 42);
            CustomerList.Margin = new Padding(4);
            CustomerList.Name = "CustomerList";
            CustomerList.RowHeadersWidth = 51;
            CustomerList.Size = new Size(964, 270);
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
            tabs.Controls.Add(MoviesTab);
            tabs.Controls.Add(ReportsTab);
            tabs.Location = new Point(14, 0);
            tabs.Margin = new Padding(4);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(980, 548);
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
            Customer.Location = new Point(4, 34);
            Customer.Margin = new Padding(4);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(4);
            Customer.Size = new Size(972, 510);
            Customer.TabIndex = 0;
            Customer.Text = "Customers";
            Customer.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            select.Location = new Point(809, 4);
            select.Margin = new Padding(4);
            select.Name = "select";
            select.RightToLeft = RightToLeft.Yes;
            select.Size = new Size(158, 31);
            select.TabIndex = 6;
            select.Text = "Search";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(8, 459);
            delButton.Margin = new Padding(4);
            delButton.Name = "delButton";
            delButton.RightToLeft = RightToLeft.Yes;
            delButton.Size = new Size(166, 40);
            delButton.TabIndex = 5;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(780, 448);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.RightToLeft = RightToLeft.Yes;
            addButton.Size = new Size(166, 40);
            addButton.TabIndex = 4;
            addButton.Text = "Add Customer";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(1, 1);
            searchBox.Margin = new Padding(4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(790, 31);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search";
            // 
            // modify
            // 
            modify.Location = new Point(780, 331);
            modify.Margin = new Padding(4);
            modify.Name = "modify";
            modify.RightToLeft = RightToLeft.Yes;
            modify.Size = new Size(166, 40);
            modify.TabIndex = 2;
            modify.Text = "Modify";
            modify.UseVisualStyleBackColor = true;
            modify.Click += modify_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRent);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dgvRented);
            tabPage2.Controls.Add(dgvQueue);
            tabPage2.Controls.Add(cmbMovie);
            tabPage2.Controls.Add(cmbCustomer);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(972, 510);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rental";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(722, 366);
            btnRent.Margin = new Padding(4, 5, 4, 5);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(210, 111);
            btnRent.TabIndex = 4;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 1);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 25);
            label4.TabIndex = 16;
            label4.Text = "Customer Rental History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 199);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 15;
            label3.Text = "Customer Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 14;
            label2.Text = "Movie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 13;
            label1.Text = "Customer";
            // 
            // dgvRented
            // 
            dgvRented.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRented.Location = new Point(549, 31);
            dgvRented.Margin = new Padding(4, 5, 4, 5);
            dgvRented.Name = "dgvRented";
            dgvRented.RowHeadersWidth = 51;
            dgvRented.Size = new Size(414, 278);
            dgvRented.TabIndex = 12;
            // 
            // dgvQueue
            // 
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Location = new Point(0, 229);
            dgvQueue.Margin = new Padding(4, 5, 4, 5);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.RowHeadersWidth = 51;
            dgvQueue.Size = new Size(450, 278);
            dgvQueue.TabIndex = 11;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(0, 131);
            cmbMovie.Margin = new Padding(4, 5, 4, 5);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(146, 33);
            cmbMovie.TabIndex = 10;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(0, 31);
            cmbCustomer.Margin = new Padding(4, 5, 4, 5);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(146, 33);
            cmbCustomer.TabIndex = 9;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // MoviesTab
            // 
            MoviesTab.Controls.Add(button4);
            MoviesTab.Controls.Add(button3);
            MoviesTab.Controls.Add(button2);
            MoviesTab.Controls.Add(textBox1);
            MoviesTab.Controls.Add(label5);
            MoviesTab.Controls.Add(dataGridView1);
            MoviesTab.Controls.Add(button1);
            MoviesTab.Location = new Point(4, 34);
            MoviesTab.Name = "MoviesTab";
            MoviesTab.Size = new Size(972, 510);
            MoviesTab.TabIndex = 2;
            MoviesTab.Text = "Movies";
            MoviesTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(778, 419);
            button4.Name = "button4";
            button4.Size = new Size(74, 33);
            button4.TabIndex = 15;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(163, 419);
            button3.Name = "button3";
            button3.Size = new Size(56, 33);
            button3.TabIndex = 14;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 419);
            button2.Name = "button2";
            button2.Size = new Size(54, 33);
            button2.TabIndex = 13;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(593, 31);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 39);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 11;
            label5.Text = "Movies";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 323);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(776, 34);
            button1.Name = "button1";
            button1.Size = new Size(76, 33);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportsTab
            // 
            ReportsTab.Location = new Point(4, 34);
            ReportsTab.Name = "ReportsTab";
            ReportsTab.Size = new Size(972, 510);
            ReportsTab.TabIndex = 3;
            ReportsTab.Text = "Reports";
            ReportsTab.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(tabs);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)CustomerList).EndInit();
            tabs.ResumeLayout(false);
            Customer.ResumeLayout(false);
            Customer.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRented).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            MoviesTab.ResumeLayout(false);
            MoviesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvRented;
        private DataGridView dgvQueue;
        private ComboBox cmbMovie;
        private ComboBox cmbCustomer;
        private Button btnRent;
        private TabPage MoviesTab;
        private TabPage ReportsTab;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button1;
    }
}