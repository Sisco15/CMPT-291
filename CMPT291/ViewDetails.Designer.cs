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
            lbID = new Label();
            dataGridView1 = new DataGridView();
            lbNumOfCpy = new Label();
            lbFee = new Label();
            lbMovieType = new Label();
            lbMovieName = new Label();
            lbMovieID = new Label();
            lbTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(677, 17);
            refreshButton.Margin = new Padding(4, 5, 4, 5);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(107, 38);
            refreshButton.TabIndex = 45;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new Point(347, 25);
            lbActors.Margin = new Padding(4, 0, 4, 0);
            lbActors.Name = "lbActors";
            lbActors.Size = new Size(116, 25);
            lbActors.TabIndex = 44;
            lbActors.Text = "List of Actors";
            // 
            // addActor
            // 
            addActor.Location = new Point(677, 348);
            addActor.Margin = new Padding(4, 5, 4, 5);
            addActor.Name = "addActor";
            addActor.Size = new Size(107, 38);
            addActor.TabIndex = 43;
            addActor.Text = "Add Actor";
            addActor.UseVisualStyleBackColor = true;
            addActor.Click += addActor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(677, 397);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 42;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // movieFee
            // 
            movieFee.AutoSize = true;
            movieFee.Location = new Point(220, 203);
            movieFee.Margin = new Padding(4, 0, 4, 0);
            movieFee.Name = "movieFee";
            movieFee.Size = new Size(39, 25);
            movieFee.TabIndex = 41;
            movieFee.Text = "Fee";
            // 
            // lbCopy
            // 
            lbCopy.AutoSize = true;
            lbCopy.Location = new Point(220, 255);
            lbCopy.Margin = new Padding(4, 0, 4, 0);
            lbCopy.Name = "lbCopy";
            lbCopy.Size = new Size(54, 25);
            lbCopy.TabIndex = 40;
            lbCopy.Text = "Copy";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(220, 98);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(59, 25);
            lbName.TabIndex = 39;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(220, 150);
            lbType.Margin = new Padding(4, 0, 4, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(49, 25);
            lbType.TabIndex = 38;
            lbType.Text = "Type";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(220, 52);
            lbID.Margin = new Padding(4, 0, 4, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(30, 25);
            lbID.TabIndex = 37;
            lbID.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(347, 65);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(437, 250);
            dataGridView1.TabIndex = 36;
            // 
            // lbNumOfCpy
            // 
            lbNumOfCpy.AutoSize = true;
            lbNumOfCpy.Location = new Point(12, 255);
            lbNumOfCpy.Name = "lbNumOfCpy";
            lbNumOfCpy.Size = new Size(146, 25);
            lbNumOfCpy.TabIndex = 35;
            lbNumOfCpy.Text = "Number of Copy";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(12, 213);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(39, 25);
            lbFee.TabIndex = 34;
            lbFee.Text = "Fee";
            // 
            // lbMovieType
            // 
            lbMovieType.AutoSize = true;
            lbMovieType.Location = new Point(12, 163);
            lbMovieType.Name = "lbMovieType";
            lbMovieType.Size = new Size(103, 25);
            lbMovieType.TabIndex = 33;
            lbMovieType.Text = "Movie Type";
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Location = new Point(12, 112);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(113, 25);
            lbMovieName.TabIndex = 32;
            lbMovieName.Text = "Movie Name";
            // 
            // lbMovieID
            // 
            lbMovieID.AutoSize = true;
            lbMovieID.Location = new Point(12, 65);
            lbMovieID.Name = "lbMovieID";
            lbMovieID.Size = new Size(84, 25);
            lbMovieID.TabIndex = 31;
            lbMovieID.Text = "Movie ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(12, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(159, 25);
            lbTitle.TabIndex = 30;
            lbTitle.Text = "View movie details";
            // 
            // ViewDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private Button refreshButton;
        private Label lbActors;
        private Button addActor;
        private Button button1;
        private Label movieFee;
        private Label lbCopy;
        private Label lbName;
        private Label lbType;
        private Label lbID;
        private DataGridView dataGridView1;
        private Label lbNumOfCpy;
        private Label lbFee;
        private Label lbMovieType;
        private Label lbMovieName;
        private Label lbMovieID;
        private Label lbTitle;
    }
}