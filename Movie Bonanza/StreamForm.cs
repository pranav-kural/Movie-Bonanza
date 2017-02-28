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
    public partial class StreamForm : Form
    {
        public StreamForm(string grandTotal, string movieName)
        {
            InitializeComponent();
            this.MovieChargeLabel.Text = "Your credit card will be charged by " + grandTotal;
            this.StreamMessageLabel.Text = movieName + " will begin streaming shortly";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // close all the forms and exit the application
            Environment.Exit(0); // will also close all the background processes
        }
        
    }
}
