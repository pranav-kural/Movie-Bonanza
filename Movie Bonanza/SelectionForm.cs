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

        // ArrayList to list of movies with their categories
        // Stores - [Movie Name], [ _movies object]
        private Dictionary<string, _movies> _movieList;

        // selected movie
        public string[] selectedMovie;
        // Image resource location of the selected movie
        public Image selectedMovieImage;

        public SelectionForm()
        {
            InitializeComponent();
            this._movieList = new Dictionary<string, _movies>(); // instantiate the _moviesList Arraylist
            this._initializeMoviesList();
        }

        // Initialize the values of the _moviesList ArrayList
        private void _initializeMoviesList()
        {
             // add the movies to the _moviesList
            _movieList.Add("Cedar Rapids", new _movies("Cedar Rapids", "Comedy", Movie_Bonanza.Properties.Resources.Cedar_Rapids, "d7LkZwnfwfc"));
            _movieList.Add("Company Men", new _movies("Company Men", "Drama", Movie_Bonanza.Properties.Resources.Company_Men, "Pie66GR63Fc"));
            _movieList.Add("Death Race 2", new _movies("Death Race 2", "Action", Movie_Bonanza.Properties.Resources.Death_Race_2, "e9L88V0yh1U"));
            _movieList.Add("Footloose", new _movies("Footloose", "New Release", Movie_Bonanza.Properties.Resources.Footloose, "gtjI6OHVk00"));
            _movieList.Add("Gnomeo and Juliet", new _movies("Gnomeo and Juliet", "Family", Movie_Bonanza.Properties.Resources.Gnomeo_and_Juliet, "6avpvkoZQtk"));
            _movieList.Add("I am Number Four", new _movies("I am Number Four", "Sci-Fi", Movie_Bonanza.Properties.Resources.I_am_Number_Four, "g5djHG3hPu0"));
            _movieList.Add("Just Go With It", new _movies("Just Go With It", "Comedy", Movie_Bonanza.Properties.Resources.Just_Go_With_It, "Jz5Ubqhru7g"));
            _movieList.Add("No Strings  Attached", new _movies("No Strings  Attached", "Comedy", Movie_Bonanza.Properties.Resources.No_Strings__Attached, "Ubfcfs98MBw"));
            _movieList.Add("Real Steel", new _movies("Real Steel", "New Release", Movie_Bonanza.Properties.Resources.Real_Steel, "3S8a180uYBM"));
            _movieList.Add("Sanctum", new _movies("Sanctum", "Action", Movie_Bonanza.Properties.Resources.Sanctum, "jaZHjv3ASfw"));
            _movieList.Add("Season of the Witch", new _movies("Season of the Witch", "Sci-Fi", Movie_Bonanza.Properties.Resources.Season_of_the_Witch, "YHR56TdWC44"));
            _movieList.Add("The Dilemma", new _movies("The Dilemma", "Comedy", Movie_Bonanza.Properties.Resources.The_Dilemma, "TU8JFk7aXyA"));
            _movieList.Add("The Eagle", new _movies("The Eagle", "Action", Movie_Bonanza.Properties.Resources.The_Eagle, "Yx4bnwvGmKM"));
            _movieList.Add("The Green Hornet", new _movies("The Green Hornet", "Action", Movie_Bonanza.Properties.Resources.The_Green_Hornet, "PMA-taGtfXs"));
            _movieList.Add("The Mechanic", new _movies("The Mechanic", "Action", Movie_Bonanza.Properties.Resources.The_Mechanic, "CMklQNn0OH0"));
            _movieList.Add("The Other Woman", new _movies("The Other Woman", "Action", Movie_Bonanza.Properties.Resources.The_Other_Woman, "juxTC7hYGTE"));
            _movieList.Add("The Rite", new _movies("The Rite", "Horror", Movie_Bonanza.Properties.Resources.The_Rite, "FhHnP-9iekg"));
            _movieList.Add("The Roommate", new _movies("The Roommate", "Thriller", Movie_Bonanza.Properties.Resources.The_Roommate, "7NX30f8b1Oo"));
            _movieList.Add("The Way Back", new _movies("The Way Back", "Drama", Movie_Bonanza.Properties.Resources.The_Way_Back, "87kezJTpyMI"));
            _movieList.Add("Waiting for Forever", new _movies("Waiting for Forever", "Drama", Movie_Bonanza.Properties.Resources.Waiting_for_Forever, "Z2BRdTBM7F8"));
        }

        // _movies sturct to create an object for each movie with it's associated properties
        private struct _movies
        {
            public string name;
            public string category;
            public string cost;
            public Image poster_image; // movie poster image resource
            public string YouTubeTrailerID;

            // _movies struct constructor
            public _movies(string movieName, string categoryName, Image image, string youtubeTrailerID)
            {
                name = movieName;
                category = categoryName;
                poster_image = image;
                cost = ""; // set to empty initialy
                YouTubeTrailerID = youtubeTrailerID;
                setCost();
            }

            // set cost method to set the cost depending on the value of Category
            public void setCost()
            {
                // switch based on the value of category
                switch (category)
                {
                    case "Comedy":
                    case "Drama":
                    case "Thriller":
                        cost = "1.99"; // $1.99 for Comedy, Drama and thriller
                        break;
                    case "Action":
                    case "Sci-Fi":
                    case "Horror":
                        cost = "2.99"; // $2.99 for Action, Sci-Fi and Horror
                        break;
                    case "Family":
                        cost = "0.99"; // $0.99 for family
                        break;
                    case "New Release":
                        cost = "4.99"; // $4.99 for new releases
                        break;
                }
            }
        }

        // The Movie list select index changed event handler
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the Your Selection text boxes
            SelectionPictureBox.BackgroundImage = this._movieList[this.MovieListBox.SelectedItem.ToString()].poster_image;
            MovieTitleTextBox.Text = this._movieList[this.MovieListBox.SelectedItem.ToString()].name;
            CategoryTextBox.Text = this._movieList[this.MovieListBox.SelectedItem.ToString()].category;
            CostTextBox.Text = "$" + this._movieList[this.MovieListBox.SelectedItem.ToString()].cost;

            // Binding the video url Id information to the watch trailer button   (for bonus part)
            WatchTrailerButton.Tag = this._movieList[this.MovieListBox.SelectedItem.ToString()].YouTubeTrailerID;

            // enabling the next button once a selection has been made
            NextButton.Enabled = true;

        }

        // Next button click event handler
        private void NextButton_Click(object sender, EventArgs e)
        {
            // storing the info about the current selection at the time pressing of the next button
            this.selectedMovie = new [] { MovieTitleTextBox.Text, CategoryTextBox.Text, this._movieList[this.MovieListBox.SelectedItem.ToString()].cost };
            this.selectedMovieImage = this._movieList[this.MovieListBox.SelectedItem.ToString()].poster_image;

            // creating an instance of the OrderForm
            OrderForm myOrderForm = new OrderForm();

            // passing this form as the parent form
            myOrderForm.parentForm = this;

            // calling the OrderForm method to fill in the form
            myOrderForm._fillMovieSelectedDetails();

            // showing the OrderForm
            myOrderForm.Show();

            // hiding the SelectionForm
            this.Hide();
        }

        // BONUS
        // Watch Trailer button click event handler
        private void WatchTrailerButton_Click(object sender, EventArgs e)
        {
            // if the Vidoe Code has been set to the tag
            if (!(WatchTrailerButton.Tag == null || WatchTrailerButton.Tag.Equals("")))
            {
                // create a new instance of the MovieTrailerForm
                MovieTrailerForm trailerForm = new MovieTrailerForm(WatchTrailerButton.Tag.ToString());

                // show the trailer form as a dialog form
                trailerForm.ShowDialog();
            }
            else
            {
                // show a warning message to select a movie first before trying to watch trailer
                MessageBox.Show("Please select a movie first", "Watch Trailer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
