namespace MovieTab
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
            lbTitle = new Label();
            lbMovieID = new Label();
            lbMovieName = new Label();
            lbMovieType = new Label();
            lbFee = new Label();
            lbNumOfCpy = new Label();
            dataGridView1 = new DataGridView();
            lbID = new Label();
            lbType = new Label();
            lbName = new Label();
            lbCopy = new Label();
            movieFee = new Label();
            button1 = new Button();
            addActor = new Button();
            lbActors = new Label();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(8, 12);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(105, 15);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "View movie details";
            // 
            // lbMovieID
            // 
            lbMovieID.AutoSize = true;
            lbMovieID.Location = new Point(8, 36);
            lbMovieID.Margin = new Padding(2, 0, 2, 0);
            lbMovieID.Name = "lbMovieID";
            lbMovieID.Size = new Size(54, 15);
            lbMovieID.TabIndex = 3;
            lbMovieID.Text = "Movie ID";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(8, 64);
            lbMovieName.Margin = new Padding(2, 0, 2, 0);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(75, 15);
            lbMovieName.TabIndex = 4;
            lbMovieName.Text = "Movie Name";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(8, 95);
            lbMovieType.Margin = new Padding(2, 0, 2, 0);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(68, 15);
            lbMovieType.TabIndex = 9;
            lbMovieType.Text = "Movie Type";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(8, 125);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(25, 15);
            lbFee.TabIndex = 11;
            lbFee.Text = "Fee";
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(8, 150);
            lbNumOfCpy.Margin = new Padding(2, 0, 2, 0);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(96, 15);
            lbNumOfCpy.TabIndex = 13;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(306, 150);
            dataGridView1.TabIndex = 14;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(153, 28);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 20;
            lbID.Text = "ID";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(153, 87);
            lbType.Name = "lbType";
            lbType.Size = new Size(32, 15);
            lbType.TabIndex = 21;
            lbType.Text = "Type";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(153, 56);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 22;
            lbName.Text = "Name";
            // 
            // lbCopy
            // 
            lbCopy.AutoSize = true;
            lbCopy.Location = new Point(153, 150);
            lbCopy.Name = "lbCopy";
            lbCopy.Size = new Size(35, 15);
            lbCopy.TabIndex = 24;
            lbCopy.Text = "Copy";
            // 
            // movieFee
            // 
            movieFee.AutoSize = true;
            movieFee.Location = new Point(153, 119);
            movieFee.Name = "movieFee";
            movieFee.Size = new Size(25, 15);
            movieFee.TabIndex = 25;
            movieFee.Text = "Fee";
            // 
            // button1
            // 
            button1.Location = new Point(473, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addActor
            // 
            addActor.Location = new Point(473, 206);
            addActor.Name = "addActor";
            addActor.Size = new Size(75, 23);
            addActor.TabIndex = 27;
            addActor.Text = "Add Actor";
            addActor.UseVisualStyleBackColor = true;
            addActor.Click += addActor_Click;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new Point(242, 12);
            lbActors.Name = "lbActors";
            lbActors.Size = new Size(76, 15);
            lbActors.TabIndex = 28;
            lbActors.Text = "List of Actors";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(473, 7);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 29;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // ViewDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(refreshButton);
            Controls.Add(lbActors);
            Controls.Add(addActor);
            Controls.Add(button1);
            Controls.Add(movieFee);
            Controls.Add(lbCopy);
            Controls.Add(lbName);
            Controls.Add(lbType);
            Controls.Add(lbID);
            Controls.Add(dataGridView1);
            Controls.Add(lbNumOfCpy);
            Controls.Add(lbFee);
            Controls.Add(lbMovieType);
            Controls.Add(lbMovieName);
            Controls.Add(lbMovieID);
            Controls.Add(lbTitle);
            Name = "ViewDetails";
            Text = "ViewDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label lbID;
        private Label lbType;
        private Label lbName;
        private Label lbCopy;
        private Label movieFee;
        private Button button1;
        private Button addActor;
        private Label lbActors;
        private Button refreshButton;
    }
}