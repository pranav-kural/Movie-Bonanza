namespace Movie_Bonanza
{
    partial class MovieTrailerForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.TrailerWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(502, 337);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TrailerWebBrowser
            // 
            this.TrailerWebBrowser.Location = new System.Drawing.Point(-2, 0);
            this.TrailerWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TrailerWebBrowser.Name = "TrailerWebBrowser";
            this.TrailerWebBrowser.Size = new System.Drawing.Size(611, 331);
            this.TrailerWebBrowser.TabIndex = 2;
            // 
            // MovieTrailerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 381);
            this.Controls.Add(this.TrailerWebBrowser);
            this.Controls.Add(this.CloseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieTrailerForm";
            this.ShowIcon = false;
            this.Text = "Movie Trailer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.WebBrowser TrailerWebBrowser;
    }
}