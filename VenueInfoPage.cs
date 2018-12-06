using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace FpV3
{
    public class VenueInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public VenueInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            var venue1 = new Venue { VenueID = 1, VenueName = "Concord Music Hall", VenueCity = "Chicago" }; 

            myDatabase.Insert(venue1); 

            Entry selectionEntry = new Entry
            {
                Placeholder = "Enter ID here"
            };
            Button selectButton = new Button
            {
                Text = "Select Venue",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            Label venueIDLabel = new Label
            {
                FontSize = 30,
            };
            Label nameLabel = new Label
            {
                FontSize = 30,
            };
            Label locationLabel = new Label
            {
                FontSize = 30,
            };

            selectButton.Clicked += (sendernav, args) =>
            {
                var item = (myDatabase.Get<Venue>(selectionEntry.Text));
                venueIDLabel.Text = item.VenueID.ToString();
                nameLabel.Text = item.VenueName;
                locationLabel.Text = item.VenueAddress + " " + item.VenueCity + " " + item.VenueZIP;
            };

            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    selectionEntry,
                    venueIDLabel,
                    nameLabel,
                    locationLabel,
                    selectButton
                }
            };
            this.Content = stack1;
        }
    }
}