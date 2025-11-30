namespace MovieTab
{
    partial class addActor
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
            lbActors = new Label();
            dataGridView1 = new DataGridView();
            addButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbActors
            // 
            lbActors.AutoSize = true;
            lbActors.Location = new Point(24, 16);
            lbActors.Name = "lbActors";
            lbActors.Size = new Size(41, 15);
            lbActors.TabIndex = 0;
            lbActors.Text = "Actors";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 161);
            dataGridView1.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(241, 220);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(332, 220);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addActor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 255);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(lbActors);
            Name = "addActor";
            Text = "addActor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbActors;
        private DataGridView dataGridView1;
        private Button addButton;
        private Button cancelButton;
    }
}