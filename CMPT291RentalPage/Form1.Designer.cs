namespace CMPT291RentalPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbCustomer = new ComboBox();
            cmbMovie = new ComboBox();
            dgvQueue = new DataGridView();
            btnRent = new Button();
            dgvRented = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRented).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(51, 41);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(121, 23);
            cmbCustomer.TabIndex = 0;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(51, 101);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(121, 23);
            cmbMovie.TabIndex = 1;
            // 
            // dgvQueue
            // 
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Location = new Point(51, 176);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.Size = new Size(326, 250);
            dgvQueue.TabIndex = 2;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(595, 359);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(147, 67);
            btnRent.TabIndex = 3;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // dgvRented
            // 
            dgvRented.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRented.Location = new Point(435, 41);
            dgvRented.Name = "dgvRented";
            dgvRented.Size = new Size(307, 241);
            dgvRented.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 158);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "Customer Queue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 23);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 8;
            label4.Text = "Customer Rental History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRented);
            Controls.Add(btnRent);
            Controls.Add(dgvQueue);
            Controls.Add(cmbMovie);
            Controls.Add(cmbCustomer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRented).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbCustomer;
        private ComboBox cmbMovie;
        private DataGridView dgvQueue;
        private Button btnRent;
        private DataGridView dgvRented;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
