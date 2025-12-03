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
            lbTitle = new Label();
            label1 = new Label();
            tbRate = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(418, 226);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 23;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(328, 226);
            bAdd.Margin = new Padding(2, 2, 2, 2);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(78, 20);
            bAdd.TabIndex = 22;
            bAdd.Text = "Add Movie";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbCopy
            // 
            tbCopy.Location = new Point(177, 152);
            tbCopy.Margin = new Padding(2, 2, 2, 2);
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(319, 23);
            tbCopy.TabIndex = 21;
            // 
            // tbFee
            // 
            tbFee.Location = new Point(177, 119);
            tbFee.Margin = new Padding(2, 2, 2, 2);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(319, 23);
            tbFee.TabIndex = 20;
            // 
            // tbType
            // 
            tbType.Location = new Point(177, 89);
            tbType.Margin = new Padding(2, 2, 2, 2);
            tbType.Name = "tbType";
            tbType.Size = new Size(318, 23);
            tbType.TabIndex = 19;
            // 
            // tbName
            // 
            tbName.Location = new Point(177, 58);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(319, 23);
            tbName.TabIndex = 18;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(32, 152);
            lbNumOfCpy.Margin = new Padding(2, 0, 2, 0);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(96, 15);
            lbNumOfCpy.TabIndex = 17;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(32, 127);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 16;
            lbFee.Text = "Fee";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(32, 97);
            lbMovieType.Margin = new Padding(2, 0, 2, 0);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(68, 15);
            lbMovieType.TabIndex = 15;
            lbMovieType.Text = "Movie Type";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(32, 67);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(75, 15);
            lbMovieName.TabIndex = 14;
            lbMovieName.Text = "Movie Name";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(32, 14);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(65, 15);
            lbTitle.TabIndex = 12;
            lbTitle.Text = "Add Movie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 190);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 24;
            label1.Text = "Average Rating";
            // 
            // tbRate
            // 
            tbRate.Location = new Point(177, 187);
            tbRate.Margin = new Padding(2);
            tbRate.Name = "tbRate";
            tbRate.Size = new Size(319, 23);
            tbRate.TabIndex = 25;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tbRate);
            Controls.Add(label1);
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
            Controls.Add(lbTitle);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label lbTitle;
        private Label label1;
        private TextBox tbRate;
    }
}
