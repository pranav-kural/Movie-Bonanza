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
    public partial class MovieTrailerForm : Form
    {
        private string _trailerVideoID;

        public MovieTrailerForm(string TrailerVideoID)
        {
            InitializeComponent();
            this._trailerVideoID = TrailerVideoID;
            this.TrailerWebBrowser.Navigate($"http://youtube.com/v/{this._trailerVideoID}?version=3");
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
