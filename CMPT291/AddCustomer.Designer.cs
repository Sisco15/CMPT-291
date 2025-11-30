namespace CMPT291
{
    partial class addCust
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
            postalCodeBox = new TextBox();
            cityBox = new TextBox();
            addressBox = new TextBox();
            emailBox = new TextBox();
            nameBox = new TextBox();
            accountBox = new TextBox();
            provinceBox = new TextBox();
            cardNum = new TextBox();
            expirationBox = new TextBox();
            cVVBox = new TextBox();
            addButton = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // postalCodeBox
            // 
            postalCodeBox.Location = new Point(12, 286);
            postalCodeBox.Name = "postalCodeBox";
            postalCodeBox.Size = new Size(143, 27);
            postalCodeBox.TabIndex = 14;
            postalCodeBox.Text = "Postal Code";
            // 
            // cityBox
            // 
            cityBox.Location = new Point(12, 163);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(143, 27);
            cityBox.TabIndex = 13;
            cityBox.Text = "City";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(12, 101);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(143, 27);
            addressBox.TabIndex = 12;
            addressBox.Text = "Address";
          
            // 
            // emailBox
            // 
            emailBox.Location = new Point(178, 39);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(143, 27);
            emailBox.TabIndex = 11;
            emailBox.Text = "Email";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 39);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(143, 27);
            nameBox.TabIndex = 10;
            nameBox.Text = "Full Name";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(178, 101);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(143, 27);
            accountBox.TabIndex = 9;
            accountBox.Text = "Account Number";
            // 
            // provinceBox
            // 
            provinceBox.Location = new Point(12, 227);
            provinceBox.Name = "provinceBox";
            provinceBox.Size = new Size(143, 27);
            provinceBox.TabIndex = 15;
            provinceBox.Text = "Province";
            // 
            // cardNum
            // 
            cardNum.Location = new Point(178, 163);
            cardNum.Name = "cardNum";
            cardNum.Size = new Size(143, 27);
            cardNum.TabIndex = 16;
            cardNum.Text = "Credit Card Number";
            // 
            // expirationBox
            // 
            expirationBox.Location = new Point(178, 227);
            expirationBox.Name = "expirationBox";
            expirationBox.Size = new Size(143, 27);
            expirationBox.TabIndex = 17;
            expirationBox.Text = "Credit Card Exp.";
            
            // 
            // cVVBox
            // 
            cVVBox.Location = new Point(178, 286);
            cVVBox.Name = "cVVBox";
            cVVBox.Size = new Size(143, 27);
            cVVBox.TabIndex = 18;
            cVVBox.Text = "Credit Card CVV";
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ActiveBorder;
            addButton.Location = new Point(428, 257);
            addButton.Name = "addButton";
            addButton.Size = new Size(108, 64);
            addButton.TabIndex = 19;
            addButton.Text = "Add Customer";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // back
            // 
            back.BackColor = SystemColors.ControlDark;
            back.Location = new Point(12, 409);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 20;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // addCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(addButton);
            Controls.Add(cVVBox);
            Controls.Add(expirationBox);
            Controls.Add(cardNum);
            Controls.Add(provinceBox);
            Controls.Add(postalCodeBox);
            Controls.Add(cityBox);
            Controls.Add(addressBox);
            Controls.Add(emailBox);
            Controls.Add(nameBox);
            Controls.Add(accountBox);
            Name = "addCust";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox postalCode;
        private TextBox cityBox;
        private TextBox addressBox;
        private TextBox emailBox;
        private TextBox nameBox;
        private TextBox textBox1;
        private TextBox provinceBox;
        private TextBox cardNum;
        private TextBox postalCodeBox;
        private TextBox accountBox;
        private TextBox expirationBox;
        private TextBox cVVBox;
        private Button addButton;
        private Button back;
    }
}