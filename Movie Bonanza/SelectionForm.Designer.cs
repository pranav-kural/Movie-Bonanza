namespace Movie_Bonanza
{
    partial class SelectionForm
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
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.SelectionTitleLabel = new System.Windows.Forms.Label();
            this.SelectionDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.SelectionDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieListBox
            // 
            this.MovieListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 20;
            this.MovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings  Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieListBox.Location = new System.Drawing.Point(44, 130);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.ScrollAlwaysVisible = true;
            this.MovieListBox.Size = new System.Drawing.Size(210, 324);
            this.MovieListBox.Sorted = true;
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(49, 85);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(194, 30);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // SelectionTitleLabel
            // 
            this.SelectionTitleLabel.AutoSize = true;
            this.SelectionTitleLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.SelectionTitleLabel.Location = new System.Drawing.Point(49, 29);
            this.SelectionTitleLabel.Name = "SelectionTitleLabel";
            this.SelectionTitleLabel.Size = new System.Drawing.Size(632, 25);
            this.SelectionTitleLabel.TabIndex = 2;
            this.SelectionTitleLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // SelectionDetailsGroupBox
            // 
            this.SelectionDetailsGroupBox.Controls.Add(this.CostLabel);
            this.SelectionDetailsGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionDetailsGroupBox.Controls.Add(this.MovieTitleLabel);
            this.SelectionDetailsGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionDetailsGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionDetailsGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionDetailsGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.SelectionDetailsGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionDetailsGroupBox.Controls.Add(this.SelectionPictureBox);
            this.SelectionDetailsGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionDetailsGroupBox.Location = new System.Drawing.Point(273, 130);
            this.SelectionDetailsGroupBox.Name = "SelectionDetailsGroupBox";
            this.SelectionDetailsGroupBox.Size = new System.Drawing.Size(445, 250);
            this.SelectionDetailsGroupBox.TabIndex = 3;
            this.SelectionDetailsGroupBox.TabStop = false;
            this.SelectionDetailsGroupBox.Text = "Your Selection";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.CostLabel.Location = new System.Drawing.Point(347, 148);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(49, 21);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.CategoryLabel.Location = new System.Drawing.Point(192, 148);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(89, 21);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.TitleLabel.Location = new System.Drawing.Point(192, 64);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(42, 21);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CostTextBox.Location = new System.Drawing.Point(351, 181);
            this.CostTextBox.MaxLength = 4;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(88, 26);
            this.CostTextBox.TabIndex = 3;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CategoryTextBox.Location = new System.Drawing.Point(192, 181);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(153, 26);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.TitleTextBox.Location = new System.Drawing.Point(192, 95);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(239, 26);
            this.TitleTextBox.TabIndex = 1;
            // 
            // SelectionPictureBox
            // 
            this.SelectionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectionPictureBox.Location = new System.Drawing.Point(17, 35);
            this.SelectionPictureBox.Name = "SelectionPictureBox";
            this.SelectionPictureBox.Size = new System.Drawing.Size(165, 198);
            this.SelectionPictureBox.TabIndex = 0;
            this.SelectionPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(603, 421);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(101, 33);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.MovieTitleTextBox.Location = new System.Drawing.Point(192, 95);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(239, 26);
            this.MovieTitleTextBox.TabIndex = 1;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.MovieTitleLabel.Location = new System.Drawing.Point(192, 64);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(42, 21);
            this.MovieTitleLabel.TabIndex = 4;
            this.MovieTitleLabel.Text = "Title";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 488);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectionDetailsGroupBox);
            this.Controls.Add(this.SelectionTitleLabel);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.MovieListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Selection Form";
            this.SelectionDetailsGroupBox.ResumeLayout(false);
            this.SelectionDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.Label SelectionTitleLabel;
        private System.Windows.Forms.GroupBox SelectionDetailsGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.PictureBox SelectionPictureBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
    }
}

