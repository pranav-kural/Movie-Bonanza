namespace Movie_Bonanza
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.MovieBonanzoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieBonanzoLabel
            // 
            this.MovieBonanzoLabel.AutoSize = true;
            this.MovieBonanzoLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieBonanzoLabel.ForeColor = System.Drawing.Color.DarkSalmon;
            this.MovieBonanzoLabel.Location = new System.Drawing.Point(222, 3);
            this.MovieBonanzoLabel.Name = "MovieBonanzoLabel";
            this.MovieBonanzoLabel.Size = new System.Drawing.Size(383, 58);
            this.MovieBonanzoLabel.TabIndex = 0;
            this.MovieBonanzoLabel.Text = "Movie Bonanzo";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPictureBox.Image = global::Movie_Bonanza.Properties.Resources.movie_bonanza_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(155, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(476, 453);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(795, 469);
            this.Controls.Add(this.MovieBonanzoLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieBonanzoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}