using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace CNIT355_Final_Project
{
    public class VenueInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public VenueInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.CreateTable<Venue>();

            var venue1 = new Venue { VenueID = 1, VenueName = "Concord Music Hall", VenueCity = "Chicago" };

            myDatabase.Insert(venue1); //manually inserting records into the venue table thru the venue1 object

            var firstItem = myDatabase.Query<Venue>("SELECT * FROM Venue WHERE VenueID = 1 "); //selecting the first venueID to show write/read ability 

            Label venueIDLabel = new Label
            {

            };
            Label nameLabel = new Label
            {

            };
            Label locationLabel = new Label
            {

            };

            venueIDLabel.Text = firstItem.First().VenueID.ToString();
            nameLabel.Text = firstItem.First().VenueName;
            locationLabel.Text = firstItem.First().VenueCity;

            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    venueIDLabel,
                    nameLabel,
                    locationLabel,
                }
            };
            this.Content = stack1;
        }
    }
}