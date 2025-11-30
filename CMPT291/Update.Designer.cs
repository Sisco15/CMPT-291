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
            lbMovieID = new Label();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(601, 377);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 27;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(472, 377);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(111, 33);
            bAdd.TabIndex = 26;
            bAdd.Text = "Update";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbCopy
            // 
            tbCopy.Location = new Point(257, 255);
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(454, 31);
            tbCopy.TabIndex = 25;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(49, 255);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(146, 25);
            lbNumOfCpy.TabIndex = 24;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // tbFee
            // 
            tbFee.Location = new Point(257, 200);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(454, 31);
            tbFee.TabIndex = 23;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(49, 213);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(39, 25);
            lbFee.TabIndex = 22;
            lbFee.Text = "Fee";
            // 
            // tbType
            // 
            tbType.Location = new Point(257, 150);
            tbType.Name = "tbType";
            tbType.Size = new Size(453, 31);
            tbType.TabIndex = 21;
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(49, 163);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(103, 25);
            lbMovieType.TabIndex = 20;
            lbMovieType.Text = "Movie Type";
            // 
            // tbName
            // 
            tbName.Location = new Point(257, 98);
            tbName.Name = "tbName";
            tbName.Size = new Size(454, 31);
            tbName.TabIndex = 19;
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(49, 112);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(113, 25);
            lbMovieName.TabIndex = 18;
            lbMovieName.Text = "Movie Name";
            // 
            // lbMovieID
            // 
            lbMovieID.AutoSize = true;
            lbMovieID.Location = new Point(49, 65);
            lbMovieID.Name = "lbMovieID";
            lbMovieID.Size = new Size(84, 25);
            lbMovieID.TabIndex = 17;
            lbMovieID.Text = "Movie ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(49, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(124, 25);
            lbTitle.TabIndex = 16;
            lbTitle.Text = "Update Movie";
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Label lbMovieID;
        private Label lbTitle;
    }
}