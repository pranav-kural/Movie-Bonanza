using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Bonanza
{
    /// <summary>
    /// Movie Trailer Form Class
    /// 
    /// BONUS part
    /// 
    /// Shows a MovieTrailerForm to show the trailer of the movie from YouTube
    /// </summary>
    public partial class MovieTrailerForm : Form
    {
        // MovieTrailerForm constructor
        // Requires a Video ID representing the movie trailer video's YouTube ID
        public MovieTrailerForm(string TrailerVideoID)
        {
            InitializeComponent();
            // Set the web browser component to navigate to the trailer YouTube link with the ID being interpolated
            this.TrailerWebBrowser.Navigate($"http://youtube.com/v/{TrailerVideoID}?version=3");
        }
        
        // Close button click event handler
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the MovieTrailerForm
        }
    }
}
