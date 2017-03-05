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
    public partial class SplashForm : Form
    {
        // SplashForm constructor
        public SplashForm()
        {
            InitializeComponent();
        }

        // SplashFormTimer Tick event handler
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // create an instance of the SelectionForm
            SelectionForm mySelectionForm = new SelectionForm();

            // disbale the timer of the splash form
            this.SplashFormTimer.Enabled = false;

            // show the SelectionForm
            mySelectionForm.Show();

            // hide this form
            this.Hide();
        }
    }
}
