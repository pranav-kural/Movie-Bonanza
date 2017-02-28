namespace Movie_Bonanza
{
    partial class StreamForm
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
            this.ThankYouMessageLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.MovieChargeLabel = new System.Windows.Forms.Label();
            this.StreamMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThankYouMessageLabel
            // 
            this.ThankYouMessageLabel.AutoSize = true;
            this.ThankYouMessageLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouMessageLabel.Location = new System.Drawing.Point(27, 30);
            this.ThankYouMessageLabel.Name = "ThankYouMessageLabel";
            this.ThankYouMessageLabel.Size = new System.Drawing.Size(418, 24);
            this.ThankYouMessageLabel.TabIndex = 0;
            this.ThankYouMessageLabel.Text = "Thank You for choosing movie Bonanza!";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(202, 164);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 33);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MovieChargeLabel
            // 
            this.MovieChargeLabel.AutoSize = true;
            this.MovieChargeLabel.Font = new System.Drawing.Font("Century Gothic", 13.75F);
            this.MovieChargeLabel.Location = new System.Drawing.Point(47, 84);
            this.MovieChargeLabel.Name = "MovieChargeLabel";
            this.MovieChargeLabel.Size = new System.Drawing.Size(0, 22);
            this.MovieChargeLabel.TabIndex = 2;
            this.MovieChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreamMessageLabel
            // 
            this.StreamMessageLabel.AutoSize = true;
            this.StreamMessageLabel.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.StreamMessageLabel.Location = new System.Drawing.Point(77, 127);
            this.StreamMessageLabel.Name = "StreamMessageLabel";
            this.StreamMessageLabel.Size = new System.Drawing.Size(0, 21);
            this.StreamMessageLabel.TabIndex = 3;
            this.StreamMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 230);
            this.ControlBox = false;
            this.Controls.Add(this.StreamMessageLabel);
            this.Controls.Add(this.MovieChargeLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ThankYouMessageLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouMessageLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label MovieChargeLabel;
        private System.Windows.Forms.Label StreamMessageLabel;
    }
}