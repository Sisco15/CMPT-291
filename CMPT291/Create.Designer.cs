namespace CMPT291
{
    partial class Create
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
            tbFee = new TextBox();
            tbType = new TextBox();
            tbName = new TextBox();
            lbNumOfCpy = new Label();
            lbFee = new Label();
            lbMovieType = new Label();
            lbMovieName = new Label();
            lbMovieID = new Label();
            lbTitle = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(597, 376);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 23;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(468, 376);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(111, 33);
            bAdd.TabIndex = 22;
            bAdd.Text = "Add Movie";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbCopy
            // 
            tbCopy.Location = new Point(253, 254);
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(454, 31);
            tbCopy.TabIndex = 21;
            // 
            // tbFee
            // 
            tbFee.Location = new Point(253, 199);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(454, 31);
            tbFee.TabIndex = 20;
            // 
            // tbType
            // 
            tbType.Location = new Point(253, 149);
            tbType.Name = "tbType";
            tbType.Size = new Size(453, 31);
            tbType.TabIndex = 19;
            // 
            // tbName
            // 
            tbName.Location = new Point(253, 97);
            tbName.Name = "tbName";
            tbName.Size = new Size(454, 31);
            tbName.TabIndex = 18;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(45, 254);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(146, 25);
            lbNumOfCpy.TabIndex = 17;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(45, 212);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(39, 25);
            lbFee.TabIndex = 16;
            lbFee.Text = "Fee";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(45, 162);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(103, 25);
            lbMovieType.TabIndex = 15;
            lbMovieType.Text = "Movie Type";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(45, 111);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(113, 25);
            lbMovieName.TabIndex = 14;
            lbMovieName.Text = "Movie Name";
            // 
            // lbMovieID
            // 
            lbMovieID.AutoSize = true;
            lbMovieID.Location = new Point(45, 64);
            lbMovieID.Name = "lbMovieID";
            lbMovieID.Size = new Size(84, 25);
            lbMovieID.TabIndex = 13;
            lbMovieID.Text = "Movie ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(45, 24);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(100, 25);
            lbTitle.TabIndex = 12;
            lbTitle.Text = "Add Movie";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bAdd);
            Controls.Add(tbCopy);
            Controls.Add(tbFee);
            Controls.Add(tbType);
            Controls.Add(tbName);
            Controls.Add(lbNumOfCpy);
            Controls.Add(lbFee);
            Controls.Add(lbMovieType);
            Controls.Add(lbMovieName);
            Controls.Add(lbMovieID);
            Controls.Add(lbTitle);
            Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bAdd;
        private TextBox tbCopy;
        private TextBox tbFee;
        private TextBox tbType;
        private TextBox tbName;
        private Label lbNumOfCpy;
        private Label lbFee;
        private Label lbMovieType;
        private Label lbMovieName;
        private Label lbMovieID;
        private Label lbTitle;
    }
}