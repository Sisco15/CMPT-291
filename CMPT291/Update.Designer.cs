namespace CMPT291
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
            button1 = new Button();
            bAdd = new Button();
            tbCopy = new TextBox();
            lbNumOfCpy = new Label();
            tbFee = new TextBox();
            lbFee = new Label();
            tbType = new TextBox();
            lbMovieType = new Label();
            tbName = new TextBox();
            lbMovieName = new Label();
            lbTitle = new Label();
            lbRate = new Label();
            tbRate = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 226);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 27;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(330, 226);
            bAdd.Margin = new Padding(2, 2, 2, 2);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(78, 20);
            bAdd.TabIndex = 26;
            bAdd.Text = "Update";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbCopy
            // 
            tbCopy.Location = new Point(180, 153);
            tbCopy.Margin = new Padding(2, 2, 2, 2);
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(319, 23);
            tbCopy.TabIndex = 25;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(34, 153);
            lbNumOfCpy.Margin = new Padding(2, 0, 2, 0);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(96, 15);
            lbNumOfCpy.TabIndex = 24;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // tbFee
            // 
            tbFee.Location = new Point(180, 120);
            tbFee.Margin = new Padding(2, 2, 2, 2);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(319, 23);
            tbFee.TabIndex = 23;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(34, 128);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 22;
            lbFee.Text = "Fee";
            // 
            // tbType
            // 
            tbType.Location = new Point(180, 90);
            tbType.Margin = new Padding(2, 2, 2, 2);
            tbType.Name = "tbType";
            tbType.Size = new Size(318, 23);
            tbType.TabIndex = 21;
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(34, 98);
            lbMovieType.Margin = new Padding(2, 0, 2, 0);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(68, 15);
            lbMovieType.TabIndex = 20;
            lbMovieType.Text = "Movie Type";
            // 
            // tbName
            // 
            tbName.Location = new Point(180, 59);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(319, 23);
            tbName.TabIndex = 19;
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(34, 67);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(75, 15);
            lbMovieName.TabIndex = 18;
            lbMovieName.Text = "Movie Name";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(34, 15);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(81, 15);
            lbTitle.TabIndex = 16;
            lbTitle.Text = "Update Movie";
            // 
            // lbRate
            // 
            lbRate.AutoSize = true;
            lbRate.Location = new Point(34, 186);
            lbRate.Margin = new Padding(2, 0, 2, 0);
            lbRate.Name = "lbRate";
            lbRate.Size = new Size(87, 15);
            lbRate.TabIndex = 28;
            lbRate.Text = "Average Rating";
            // 
            // tbRate
            // 
            tbRate.Location = new Point(179, 186);
            tbRate.Margin = new Padding(2);
            tbRate.Name = "tbRate";
            tbRate.Size = new Size(319, 23);
            tbRate.TabIndex = 29;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tbRate);
            Controls.Add(lbRate);
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
            Controls.Add(lbTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bAdd;
        private TextBox tbCopy;
        private Label lbNumOfCpy;
        private TextBox tbFee;
        private Label lbFee;
        private TextBox tbType;
        private Label lbMovieType;
        private TextBox tbName;
        private Label lbMovieName;
        private Label lbTitle;
        private Label lbRate;
        private TextBox tbRate;
    }
}
