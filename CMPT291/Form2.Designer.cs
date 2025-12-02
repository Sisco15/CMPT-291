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
            lstCustomerResults = new ListBox();
            txtSearchCustomer = new TextBox();
            btnRent = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvRented = new DataGridView();
            dgvQueue = new DataGridView();
            cmbMovie = new ComboBox();
            MoviesTab = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ReportsTab = new TabPage();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            buttonRunReport4 = new Button();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            comboBox4 = new ComboBox();
            button8 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button7 = new Button();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            button6 = new Button();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)CustomerList).BeginInit();
            tabs.SuspendLayout();
            Customer.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRented).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            MoviesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ReportsTab.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerList
            // 
            CustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerList.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FirstName, LastName, AccountNum, Email, Province, City });
            CustomerList.Location = new Point(0, 33);
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
            tabs.Controls.Add(MoviesTab);
            tabs.Controls.Add(ReportsTab);
            tabs.Location = new Point(11, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(944, 641);
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
            Customer.Padding = new Padding(3, 3, 3, 3);
            Customer.Size = new Size(936, 608);
            Customer.TabIndex = 0;
            Customer.Text = "Customers";
            Customer.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            select.Location = new Point(647, 3);
            select.Name = "select";
            select.RightToLeft = RightToLeft.Yes;
            select.Size = new Size(127, 25);
            select.TabIndex = 6;
            select.Text = "Search";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(7, 367);
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
            addButton.Location = new Point(624, 359);
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
            tabPage2.Controls.Add(lstCustomerResults);
            tabPage2.Controls.Add(txtSearchCustomer);
            tabPage2.Controls.Add(btnRent);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dgvRented);
            tabPage2.Controls.Add(dgvQueue);
            tabPage2.Controls.Add(cmbMovie);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(936, 608);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rental";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstCustomerResults
            // 
            lstCustomerResults.FormattingEnabled = true;
            lstCustomerResults.Location = new Point(0, 64);
            lstCustomerResults.Margin = new Padding(3, 4, 3, 4);
            lstCustomerResults.Name = "lstCustomerResults";
            lstCustomerResults.Size = new Size(165, 504);
            lstCustomerResults.TabIndex = 18;
            lstCustomerResults.Visible = false;
            lstCustomerResults.SelectedIndexChanged += lstCustomerResults_SelectedIndexChanged;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(3, 25);
            txtSearchCustomer.Margin = new Padding(3, 4, 3, 4);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(162, 27);
            txtSearchCustomer.TabIndex = 17;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(693, 480);
            btnRent.Margin = new Padding(3, 4, 3, 4);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(168, 89);
            btnRent.TabIndex = 4;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 16;
            label4.Text = "Customer Rental History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 251);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 15;
            label3.Text = "Customer Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 25);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "Movie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 13;
            label1.Text = "Customer";
            // 
            // dgvRented
            // 
            dgvRented.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRented.Location = new Point(529, 25);
            dgvRented.Margin = new Padding(3, 4, 3, 4);
            dgvRented.Name = "dgvRented";
            dgvRented.RowHeadersWidth = 51;
            dgvRented.Size = new Size(331, 284);
            dgvRented.TabIndex = 12;
            // 
            // dgvQueue
            // 
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Location = new Point(193, 275);
            dgvQueue.Margin = new Padding(3, 4, 3, 4);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.RowHeadersWidth = 51;
            dgvQueue.Size = new Size(329, 295);
            dgvQueue.TabIndex = 11;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(193, 49);
            cmbMovie.Margin = new Padding(3, 4, 3, 4);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(117, 28);
            cmbMovie.TabIndex = 10;
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
            MoviesTab.Location = new Point(4, 29);
            MoviesTab.Margin = new Padding(2, 3, 2, 3);
            MoviesTab.Name = "MoviesTab";
            MoviesTab.Size = new Size(936, 608);
            MoviesTab.TabIndex = 2;
            MoviesTab.Text = "Movies";
            MoviesTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(621, 335);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(61, 27);
            button4.TabIndex = 15;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(142, 335);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(56, 27);
            button3.TabIndex = 14;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(82, 335);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(56, 27);
            button2.TabIndex = 13;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 27);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(475, 27);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Movies";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 59);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(600, 259);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(621, 27);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(61, 27);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportsTab
            // 
            ReportsTab.Controls.Add(label17);
            ReportsTab.Controls.Add(label16);
            ReportsTab.Controls.Add(label15);
            ReportsTab.Controls.Add(buttonRunReport4);
            ReportsTab.Controls.Add(dateTimePickerEnd);
            ReportsTab.Controls.Add(dateTimePickerStart);
            ReportsTab.Controls.Add(comboBox4);
            ReportsTab.Controls.Add(button8);
            ReportsTab.Controls.Add(label14);
            ReportsTab.Controls.Add(label13);
            ReportsTab.Controls.Add(label12);
            ReportsTab.Controls.Add(button7);
            ReportsTab.Controls.Add(comboBox3);
            ReportsTab.Controls.Add(label10);
            ReportsTab.Controls.Add(label11);
            ReportsTab.Controls.Add(button6);
            ReportsTab.Controls.Add(comboBox2);
            ReportsTab.Controls.Add(label9);
            ReportsTab.Controls.Add(label8);
            ReportsTab.Controls.Add(button5);
            ReportsTab.Controls.Add(comboBox1);
            ReportsTab.Controls.Add(label7);
            ReportsTab.Controls.Add(label6);
            ReportsTab.Location = new Point(4, 29);
            ReportsTab.Margin = new Padding(2, 3, 2, 3);
            ReportsTab.Name = "ReportsTab";
            ReportsTab.Size = new Size(936, 608);
            ReportsTab.TabIndex = 3;
            ReportsTab.Text = "Reports";
            ReportsTab.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(305, 341);
            label17.Name = "label17";
            label17.Size = new Size(28, 20);
            label17.TabIndex = 27;
            label17.Text = "To:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(59, 341);
            label16.Name = "label16";
            label16.Size = new Size(46, 20);
            label16.TabIndex = 26;
            label16.Text = "From:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 293);
            label15.Name = "label15";
            label15.Size = new Size(332, 20);
            label15.TabIndex = 25;
            label15.Text = "Movies that have not been rented in time period:";
            // 
            // buttonRunReport4
            // 
            buttonRunReport4.Location = new Point(530, 371);
            buttonRunReport4.Margin = new Padding(3, 4, 3, 4);
            buttonRunReport4.Name = "buttonRunReport4";
            buttonRunReport4.Size = new Size(97, 31);
            buttonRunReport4.TabIndex = 24;
            buttonRunReport4.Text = "Run Report 4";
            buttonRunReport4.UseVisualStyleBackColor = true;
            buttonRunReport4.Click += buttonRunReport4_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(337, 333);
            dateTimePickerEnd.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(174, 27);
            dateTimePickerEnd.TabIndex = 23;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(110, 333);
            dateTimePickerStart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(177, 27);
            dateTimePickerStart.TabIndex = 22;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July ", "August", "September", "October", "November", "December" });
            comboBox4.Location = new Point(395, 471);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(127, 28);
            comboBox4.TabIndex = 21;
            // 
            // button8
            // 
            button8.Location = new Point(530, 471);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(97, 31);
            button8.TabIndex = 20;
            button8.Text = "Run Report 5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 476);
            label14.Name = "label14";
            label14.Size = new Size(414, 20);
            label14.TabIndex = 19;
            label14.Text = "Employees who distributed the most movies in a time frame: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(1, 437);
            label13.Name = "label13";
            label13.Size = new Size(82, 25);
            label13.TabIndex = 18;
            label13.Text = "Report 5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(3, 249);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 17;
            label12.Text = "Report 4";
            // 
            // button7
            // 
            button7.Location = new Point(530, 196);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(97, 31);
            button7.TabIndex = 11;
            button7.Text = "Run Report 3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox3.Location = new Point(250, 199);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 28);
            comboBox3.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 207);
            label10.Name = "label10";
            label10.Size = new Size(230, 20);
            label10.TabIndex = 9;
            label10.Text = "Most Active Customers in Month: ";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(3, 165);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 8;
            label11.Text = "Report 3";
            // 
            // button6
            // 
            button6.Location = new Point(530, 125);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(97, 31);
            button6.TabIndex = 7;
            button6.Text = "Run Report 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(374, 128);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 137);
            label9.Name = "label9";
            label9.Size = new Size(362, 20);
            label9.TabIndex = 5;
            label9.Text = "Revenue generated by genre of movie for the quarter";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(3, 96);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 4;
            label8.Text = "Report 2";
            // 
            // button5
            // 
            button5.Location = new Point(530, 57);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(97, 31);
            button5.TabIndex = 3;
            button5.Text = "Run Report 1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(374, 59);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 61);
            label7.Name = "label7";
            label7.Size = new Size(349, 20);
            label7.TabIndex = 1;
            label7.Text = "Top rated movies by genre of movie for the quarter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(3, 20);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 0;
            label6.Text = "Report 1";
            label6.Click += label6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 656);
            Controls.Add(tabs);
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
            ReportsTab.ResumeLayout(false);
            ReportsTab.PerformLayout();
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
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private ComboBox comboBox2;
        private Label label9;
        private Label label8;
        private Button button7;
        private ComboBox comboBox3;
        private Label label10;
        private Label label11;
        private ListBox lstCustomerResults;
        private TextBox txtSearchCustomer;
        private ComboBox comboBox4;
        private Button button8;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label15;
        private Button buttonRunReport4;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label17;
        private Label label16;
    }
}
