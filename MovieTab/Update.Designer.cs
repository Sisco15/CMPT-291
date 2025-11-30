namespace MovieTab
{
    partial class Update
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
            lbTitle = new Label();
            lbMovieID = new Label();
            lbMovieName = new Label();
            lbMovieType = new Label();
            lbFee = new Label();
            lbNumOfCpy = new Label();
            tbName = new TextBox();
            tbType = new TextBox();
            tbFee = new TextBox();
            tbCopy = new TextBox();
            button1 = new Button();
            bAdd = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(8, 12);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(81, 15);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Update Movie";
            // 
            // lbMovieID
            // 
            lbMovieID.AutoSize = true;
            lbMovieID.Location = new Point(8, 36);
            lbMovieID.Margin = new Padding(2, 0, 2, 0);
            lbMovieID.Name = "lbMovieID";
            lbMovieID.Size = new Size(54, 15);
            lbMovieID.TabIndex = 2;
            lbMovieID.Text = "Movie ID";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(8, 64);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(75, 15);
            lbMovieName.TabIndex = 3;
            lbMovieName.Text = "Movie Name";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(8, 95);
            lbMovieType.Margin = new Padding(2, 0, 2, 0);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(68, 15);
            lbMovieType.TabIndex = 8;
            lbMovieType.Text = "Movie Type";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(8, 125);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 10;
            lbFee.Text = "Fee";
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(8, 150);
            lbNumOfCpy.Margin = new Padding(2, 0, 2, 0);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(96, 15);
            lbNumOfCpy.TabIndex = 12;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // tbName
            // 
            tbName.Location = new Point(153, 56);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(319, 23);
            tbName.TabIndex = 7;
            // 
            // tbType
            // 
            tbType.Location = new Point(153, 87);
            tbType.Margin = new Padding(2);
            tbType.Name = "tbType";
            tbType.Size = new Size(318, 23);
            tbType.TabIndex = 9;
            // 
            // tbFee
            // 
            tbFee.Location = new Point(153, 117);
            tbFee.Margin = new Padding(2);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(319, 23);
            tbFee.TabIndex = 11;
            // 
            // tbCopy
            // 
            tbCopy.Location = new Point(153, 150);
            tbCopy.Margin = new Padding(2);
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(319, 23);
            tbCopy.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(394, 223);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 15;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(304, 223);
            bAdd.Margin = new Padding(2);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(78, 20);
            bAdd.TabIndex = 14;
            bAdd.Text = "Update";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(bAdd);
            Controls.Add(tbCopy);
            Controls.Add(lbNumOfCpy);
            Controls.Add(tbFee);
            Controls.Add(lbFee);
            Controls.Add(tbType);
            Controls.Add(lbMovieType);
            Controls.Add(tbName);
            Controls.Add(lbMovieName);
            Controls.Add(lbMovieID);
            Controls.Add(lbTitle);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbMovieID;
        private Label lbMovieName;
        private Label lbMovieType;
        private Label lbFee;
        private Label lbNumOfCpy;
        private TextBox tbName;
        private TextBox tbType;
        private TextBox tbFee;
        private TextBox tbCopy;
        private Button button1;
        private Button bAdd;
    }
}