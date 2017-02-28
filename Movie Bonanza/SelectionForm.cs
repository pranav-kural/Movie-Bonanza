using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Bonanza
{
    public partial class SelectionForm : Form
    {

        // list of movies with their categories
        private Dictionary<string, _movies> _movieList;

        public SelectionForm()
        {
            InitializeComponent();
            this._movieList = new Dictionary<string, _movies>();
            this._initializeMoviesList();
        }


        private void _initializeMoviesList()
        {
             // add the movies to the _moviesList
            _movieList.Add("Cedar Rapids", new _movies("Cedar Rapids", "Comedy", Movie_Bonanza.Properties.Resources.Cedar_Rapids));
            _movieList.Add("Company Men", new _movies("Company Men", "Drama", Movie_Bonanza.Properties.Resources.Company_Men));
            _movieList.Add("Death Race 2", new _movies("Death Race 2", "Action", Movie_Bonanza.Properties.Resources.Death_Race_2));
            _movieList.Add("Footloose", new _movies("Footloose", "New Release", Movie_Bonanza.Properties.Resources.Footloose));
            _movieList.Add("Gnomeo and Juliet", new _movies("Gnomeo and Juliet", "Family", Movie_Bonanza.Properties.Resources.Gnomeo_and_Juliet));
            _movieList.Add("I am Number Four", new _movies("I am Number Four", "Sci-Fi", Movie_Bonanza.Properties.Resources.I_am_Number_Four));
            _movieList.Add("Just Go With It", new _movies("Just Go With It", "Comedy", Movie_Bonanza.Properties.Resources.Just_Go_With_It));
            _movieList.Add("No Strings  Attached", new _movies("No Strings  Attached", "Comedy", Movie_Bonanza.Properties.Resources.No_Strings__Attached));
            _movieList.Add("Real Steel", new _movies("Real Steel", "New Release", Movie_Bonanza.Properties.Resources.Real_Steel));
            _movieList.Add("Sanctum", new _movies("Sanctum", "Action", Movie_Bonanza.Properties.Resources.Sanctum));
            _movieList.Add("Season of the Witch", new _movies("Season of the Witch", "Sci-Fi", Movie_Bonanza.Properties.Resources.Season_of_the_Witch));
            _movieList.Add("The Dilemma", new _movies("The Dilemma", "Comedy", Movie_Bonanza.Properties.Resources.The_Dilemma));
            _movieList.Add("The Eagle", new _movies("The Eagle", "Action", Movie_Bonanza.Properties.Resources.The_Eagle));
            _movieList.Add("The Green Hornet", new _movies("The Green Hornet", "Action", Movie_Bonanza.Properties.Resources.The_Green_Hornet));
            _movieList.Add("The Mechanic", new _movies("The Mechanic", "Action", Movie_Bonanza.Properties.Resources.The_Mechanic));
            _movieList.Add("The Other Woman", new _movies("The Other Woman", "Action", Movie_Bonanza.Properties.Resources.The_Other_Woman));
            _movieList.Add("The Rite", new _movies("The Rite", "Horror", Movie_Bonanza.Properties.Resources.The_Rite));
            _movieList.Add("The Roommate", new _movies("The Roommate", "Thriller", Movie_Bonanza.Properties.Resources.The_Roommate));
            _movieList.Add("The Way Back", new _movies("The Way Back", "Drama", Movie_Bonanza.Properties.Resources.The_Way_Back));
            _movieList.Add("Waiting for Forever", new _movies("Waiting for Forever", "Drama", Movie_Bonanza.Properties.Resources.Waiting_for_Forever));
            
        }


        private struct _movies
        {
            public string name;
            public string category;
            public string cost;
            public Image image_short_code;

            public _movies(string movieName, string categoryName, Image image)
            {
                name = movieName;
                category = categoryName;
                cost = "$";
                image_short_code = image;
                setCost();
            }

            public void setCost()
            {
                switch (category)
                {
                    case "Comedy":
                    case "Drama":
                    case "Thriller":
                        cost += "1.99";
                        break;
                    case "Action":
                    case "Sci-Fi":
                    case "Horror":
                        cost += "2.99";
                        break;
                    case "Family":
                        cost += "0.99";
                        break;
                    case "New Release":
                        cost += "4.99";
                        break;
                }
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the Your Selection text boxes
            SelectionPictureBox.BackgroundImage = this._movieList[this.MovieListBox.SelectedItem.ToString()].image_short_code;
            TitleTextBox.Text = this._movieList[this.MovieListBox.SelectedItem.ToString()].name;
            CategoryTextBox.Text = this._movieList[this.MovieListBox.SelectedItem.ToString()].category;
            CostTextBox.Text = this._movieList[this.MovieListBox.SelectedItem.ToString()].cost;

            // enabling the next button once a selection has been made
            NextButton.Enabled = true;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // creating an instance of the OrderForm
            OrderForm myOrderForm = new OrderForm();

            // passing this form as the parent form
            myOrderForm.parentForm = this;

            // showing the OrderForm
            myOrderForm.Show();

            // hiding the SelectionForm
            this.Hide();
        }
    }
}
