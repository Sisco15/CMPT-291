namespace CMPT291
{
    partial class ViewDetails
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
            refreshButton = new Button();
            lbActors = new Label();
            addActor = new Button();
            button1 = new Button();
            movieFee = new Label();
            lbCopy = new Label();
            lbName = new Label();
            lbType = new Label();
            dataGridView1 = new DataGridView();
            lbNumOfCpy = new Label();
            lbFee = new Label();
            lbMovieType = new Label();
            lbMovieName = new Label();
            lbTitle = new Label();
            lbRate = new Label();
            lbRating = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(474, 10);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 45;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new Point(243, 15);
            lbActors.Name = "lbActors";
            lbActors.Size = new Size(76, 15);
            lbActors.TabIndex = 44;
            lbActors.Text = "List of Actors";
            // 
            // addActor
            // 
            addActor.Location = new Point(474, 209);
            addActor.Name = "addActor";
            addActor.Size = new Size(75, 23);
            addActor.TabIndex = 43;
            addActor.Text = "Add Actor";
            addActor.UseVisualStyleBackColor = true;
            addActor.Click += addActor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(474, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 42;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // movieFee
            // 
            movieFee.AutoSize = true;
            movieFee.Location = new Point(154, 122);
            movieFee.Name = "movieFee";
            movieFee.Size = new Size(25, 15);
            movieFee.TabIndex = 41;
            movieFee.Text = "Fee";
            // 
            // lbCopy
            // 
            lbCopy.AutoSize = true;
            lbCopy.Location = new Point(154, 153);
            lbCopy.Name = "lbCopy";
            lbCopy.Size = new Size(35, 15);
            lbCopy.TabIndex = 40;
            lbCopy.Text = "Copy";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(154, 59);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 39;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(154, 90);
            lbType.Name = "lbType";
            lbType.Size = new Size(32, 15);
            lbType.TabIndex = 38;
            lbType.Text = "Type";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(306, 150);
            dataGridView1.TabIndex = 36;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(8, 153);
            lbNumOfCpy.Margin = new Padding(2, 0, 2, 0);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(96, 15);
            lbNumOfCpy.TabIndex = 35;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(8, 128);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 34;
            lbFee.Text = "Fee";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(8, 98);
            lbMovieType.Margin = new Padding(2, 0, 2, 0);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(68, 15);
            lbMovieType.TabIndex = 33;
            lbMovieType.Text = "Movie Type";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(8, 67);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(75, 15);
            lbMovieName.TabIndex = 32;
            lbMovieName.Text = "Movie Name";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(8, 15);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(105, 15);
            lbTitle.TabIndex = 30;
            lbTitle.Text = "View movie details";
            // 
            // lbRate
            // 
            lbRate.AutoSize = true;
            lbRate.Location = new Point(8, 184);
            lbRate.Margin = new Padding(2, 0, 2, 0);
            lbRate.Name = "lbRate";
            lbRate.Size = new Size(87, 15);
            lbRate.TabIndex = 46;
            lbRate.Text = "Average Rating";
            // 
            // lbRating
            // 
            lbRating.AutoSize = true;
            lbRating.Location = new Point(154, 184);
            lbRating.Margin = new Padding(2, 0, 2, 0);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(87, 15);
            lbRating.TabIndex = 47;
            lbRating.Text = "Average Rating";
            // 
            // ViewDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lbRating);
            Controls.Add(lbRate);
            Controls.Add(refreshButton);
            Controls.Add(lbActors);
            Controls.Add(addActor);
            Controls.Add(button1);
            Controls.Add(movieFee);
            Controls.Add(lbCopy);
            Controls.Add(lbName);
            Controls.Add(lbType);
            Controls.Add(dataGridView1);
            Controls.Add(lbNumOfCpy);
            Controls.Add(lbFee);
            Controls.Add(lbMovieType);
            Controls.Add(lbMovieName);
            Controls.Add(lbTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewDetails";
            Text = "ViewDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshButton;
        private Label lbActors;
        private Button addActor;
        private Button button1;
        private Label movieFee;
        private Label lbCopy;
        private Label lbName;
        private Label lbType;
        private DataGridView dataGridView1;
        private Label lbNumOfCpy;
        private Label lbFee;
        private Label lbMovieType;
        private Label lbMovieName;
        private Label lbTitle;
        private Label lbRate;
        private Label lbRating;
    }
}
