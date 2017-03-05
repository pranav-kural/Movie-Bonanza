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
    public partial class OrderForm : Form
    {

        // reference to the parent form
        public SelectionForm parentForm;

        // OderForm constructor
        public OrderForm()
        {
            InitializeComponent();
        }

        // fill the details of movie selected
        public void _fillMovieSelectedDetails()
        {
            // filling the OrderForm text boxes with the current 
            // selection information being accessed through the parentForm (SelectionForm)
            // fill the Movies Selected group box
            _fillMovieSelectedGroupBox();

            // calculating and filling the values for the YourOrder textboxes
            _fillYourOrderGroupBox();

        }

        // fill the Movies Selected group box
        private void _fillMovieSelectedGroupBox()
        {
            this.TitleTextBox.Text = parentForm.selectedMovie[0]; // first element in the selectedMovies array represents the title
            this.CategoryTextBox.Text = parentForm.selectedMovie[1]; // second element in the selectedMovies array represents the category
            this.SelectionPictureBox.BackgroundImage = parentForm.selectedMovieImage; // set the image resource
        }

        // Calculates the price value for the YourOrder group box text boxes and display them
        private void _fillYourOrderGroupBox()
        {
            // update the cost value
            this.CostTextBox.Text = "$" + parentForm.selectedMovie[2];

            // calculate the sub total
            this.SubTotalTextBox.Text = "$" + (_getSanitizedPriceValue(this.CostTextBox) + _getSanitizedPriceValue(this.AdditionalChargeTextBox)).ToString();

            // calculating the sales tax
            this.SalesTaxTextBox.Text = "$" + (_getSanitizedPriceValue(this.SubTotalTextBox) * 0.13).ToString();

            // grand total value
            this.GrandTotalTextBox.Text = "$" + (_getSanitizedPriceValue(this.SubTotalTextBox) + _getSanitizedPriceValue(this.SalesTaxTextBox)).ToString();
        }

        /// <summary>
        /// Removes the '$' symbol from the TextBox's value and 
        /// return the number as a double with 2 decimal places (rounded up)
        /// </summary>
        /// <param name="textBox">TextBox the value of which needs to be sanitised and returned</param>
        /// <returns>A decimal number</returns>
        private double _getSanitizedPriceValue(TextBox textBox)
        {
            // extracts the '$' char from TextBox Text property's value
            // convert it into a Double and round it off to 2 decimal places before returning
            return Math.Round(Double.Parse(textBox.Text.Replace('$', ' ').Trim()), 2);
        }

        // The optional physical delivery option check box event handler
        private void AdditionalOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // if user selects the option for physical delivery of the movie
            if (this.AdditionalOptionCheckBox.Checked)
            {
                // make the Additional charge text box and label visible to the user
                this.AdditionalChargeLabel.Visible = true;
                this.AdditionalChargeTextBox.Visible = true;
                // add the charge of 10 dollars to the additional charge text box
                this.AdditionalChargeTextBox.Text = "$10.00";
            } else
            {
                // if the user unselects

                // hide the additional charge text box and label
                this.AdditionalChargeLabel.Visible = false;
                this.AdditionalChargeTextBox.Visible = false;
                // reset it's value to zero
                this.AdditionalChargeTextBox.Text = "0"; 
                // don't set to empty string, since it needs to be pasred to a double later for calculating grand total
            }
            // update the values of the YourOrder group box text boxes
            _fillYourOrderGroupBox();
        }

        // Stream Button click event handler
        private void StreamButton_Click(object sender, EventArgs e)
        {
            // create a new instance of StreamForm
            StreamForm myStreamForm = new StreamForm(this.GrandTotalTextBox.Text, this.TitleTextBox.Text);

            // show the StreamForm
            myStreamForm.Show();

            // hide the OrderForm
            this.Hide();
        }

        // Back button click event handler
        private void BackButton_Click(object sender, EventArgs e)
        {
            // show the parentForm back again
            parentForm.Show();

            // hide the OrderForm
            this.Hide();
        }

        // Cancel Button click event handler
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Confirm the user if he/she wants to cancel the order
            DialogResult confirmCancel = MessageBox.Show("Are you sure you want to cancel?", "Confirm Order Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // if user is sure he/she wants to cancel
            if (confirmCancel == DialogResult.Yes)
            {
                // close all the forms and exit the application
                Environment.Exit(0); // will also close all the background processes
            }
        }

        // Print menu item click event handler
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display print preview message
            MessageBox.Show($"The details of your order for the movie \"{this.TitleTextBox.Text}\", for a total of {this.GrandTotalTextBox.Text} is being printed. Thank you.", "Print Movie Order Details");
        }

        // About menu item click event handler
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the AboutBox
            AboutBox myAboutBox = new AboutBox();

            // Show About Dialog box
            myAboutBox.ShowDialog();
        }
    }
}
