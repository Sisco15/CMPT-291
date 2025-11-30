namespace CMPT291
{
    partial class Form4
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
            cVVBox = new TextBox();
            expirationBox = new TextBox();
            cardNum = new TextBox();
            provinceBox = new TextBox();
            postalCodeBox = new TextBox();
            cityBox = new TextBox();
            addressBox = new TextBox();
            emailBox = new TextBox();
            firstNameBox = new TextBox();
            accountBox = new TextBox();
            modifyButton = new Button();
            back = new Button();
            dataGridView1 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AccountNumber = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Province = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            CreditCardNum = new DataGridViewTextBoxColumn();
            cardExp = new DataGridViewTextBoxColumn();
            CreditCVV = new DataGridViewTextBoxColumn();
            lastNameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cVVBox
            // 
            cVVBox.Location = new Point(416, 308);
            cVVBox.Name = "cVVBox";
            cVVBox.Size = new Size(143, 27);
            cVVBox.TabIndex = 28;
            cVVBox.Text = "Credit Card CVV";
            // 
            // expirationBox
            // 
            expirationBox.Location = new Point(582, 266);
            expirationBox.Name = "expirationBox";
            expirationBox.Size = new Size(143, 27);
            expirationBox.TabIndex = 27;
            expirationBox.Text = "Credit Card Exp.";
            // 
            // cardNum
            // 
            cardNum.Location = new Point(582, 221);
            cardNum.Name = "cardNum";
            cardNum.Size = new Size(143, 27);
            cardNum.TabIndex = 26;
            cardNum.Text = "Credit Card Number";
            // 
            // provinceBox
            // 
            provinceBox.Location = new Point(416, 266);
            provinceBox.Name = "provinceBox";
            provinceBox.Size = new Size(143, 27);
            provinceBox.TabIndex = 25;
            provinceBox.Text = "Province";
            // 
            // postalCodeBox
            // 
            postalCodeBox.Location = new Point(233, 308);
            postalCodeBox.Name = "postalCodeBox";
            postalCodeBox.Size = new Size(143, 27);
            postalCodeBox.TabIndex = 24;
            postalCodeBox.Text = "Postal Code";
            // 
            // cityBox
            // 
            cityBox.Location = new Point(67, 308);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(143, 27);
            cityBox.TabIndex = 23;
            cityBox.Text = "City";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(67, 264);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(143, 27);
            addressBox.TabIndex = 22;
            addressBox.Text = "Address";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(416, 221);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(143, 27);
            emailBox.TabIndex = 21;
            emailBox.Text = "Email";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(67, 221);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(143, 27);
            firstNameBox.TabIndex = 20;
            firstNameBox.Text = "First Name";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(233, 264);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(143, 27);
            accountBox.TabIndex = 19;
            accountBox.Text = "Account Number";
            // 
            // modifyButton
            // 
            modifyButton.BackColor = SystemColors.ActiveBorder;
            modifyButton.Location = new Point(635, 409);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(153, 29);
            modifyButton.TabIndex = 29;
            modifyButton.Text = "Modify Customer";
            modifyButton.UseVisualStyleBackColor = false;
            modifyButton.Click += modifyButton_Click;
            // 
            // back
            // 
            back.BackColor = SystemColors.ControlDark;
            back.Location = new Point(12, 409);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 30;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Email, AccountNumber, City, Province, Address, PostalCode, CreditCardNum, cardExp, CreditCVV });
            dataGridView1.Location = new Point(22, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 119);
            dataGridView1.TabIndex = 31;
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
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // AccountNumber
            // 
            AccountNumber.HeaderText = "Account Number";
            AccountNumber.MinimumWidth = 6;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.Width = 125;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // Province
            // 
            Province.HeaderText = "Province";
            Province.MinimumWidth = 6;
            Province.Name = "Province";
            Province.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // PostalCode
            // 
            PostalCode.HeaderText = "Postal Code";
            PostalCode.MinimumWidth = 6;
            PostalCode.Name = "PostalCode";
            PostalCode.Width = 125;
            // 
            // CreditCardNum
            // 
            CreditCardNum.HeaderText = "Credit Card Number";
            CreditCardNum.MinimumWidth = 6;
            CreditCardNum.Name = "CreditCardNum";
            CreditCardNum.Width = 125;
            // 
            // cardExp
            // 
            cardExp.HeaderText = "Credit Card Expiration";
            cardExp.MinimumWidth = 6;
            cardExp.Name = "cardExp";
            cardExp.Width = 125;
            // 
            // CreditCVV
            // 
            CreditCVV.HeaderText = "Credit Card CVV";
            CreditCVV.MinimumWidth = 6;
            CreditCVV.Name = "CreditCVV";
            CreditCVV.Width = 125;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(233, 221);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(143, 27);
            lastNameBox.TabIndex = 32;
            lastNameBox.Text = "Last Name";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastNameBox);
            Controls.Add(dataGridView1);
            Controls.Add(back);
            Controls.Add(modifyButton);
            Controls.Add(cVVBox);
            Controls.Add(expirationBox);
            Controls.Add(cardNum);
            Controls.Add(provinceBox);
            Controls.Add(postalCodeBox);
            Controls.Add(cityBox);
            Controls.Add(addressBox);
            Controls.Add(emailBox);
            Controls.Add(firstNameBox);
            Controls.Add(accountBox);
            Name = "Form4";
            Text = "Modify Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cVVBox;
        private TextBox expirationBox;
        private TextBox cardNum;
        private TextBox provinceBox;
        private TextBox postalCodeBox;
        private TextBox cityBox;
        private TextBox addressBox;
        private TextBox emailBox;
        private TextBox firstNameBox;
        private TextBox accountBox;
        private Button modifyButton;
        private Button back;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn CreditCardNum;
        private DataGridViewTextBoxColumn cardExp;
        private DataGridViewTextBoxColumn CreditCVV;
        private TextBox lastNameBox;
    }
}