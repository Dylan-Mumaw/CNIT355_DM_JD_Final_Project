using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

//using System.ComponentModel;
//using System.Runtime.CompilerServices;

namespace FpV3
{
    public class ArtistInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public ArtistInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            var artist1 = new Artist { ArtistID = 1, ArtistName = "Bob", ArtistGenre = "Paint" }; //add rest of variables for artist

            myDatabase.Insert(artist1);

            Label artistIDLabel = new Label
            {
                FontSize = 30,
            };
            Label nameLabel = new Label
            {
                FontSize = 30,
            };
            Label genreLabel = new Label
            {
                FontSize = 30,
            };
            Label addressLabel = new Label
            {

            };
            Entry selectionEntry = new Entry
            {
                Placeholder = "Enter ID here"
            };
            Button selectButton = new Button
            {
                Text = "Select Artist",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            selectButton.Clicked += (sendernav, args) =>
            {
                var item = (myDatabase.Get<Artist>(selectionEntry.Text));
                artistIDLabel.Text = item.ArtistID.ToString();
                nameLabel.Text = item.ArtistName;
                addressLabel.Text = item.ArtistAddress + " " + item.ArtistCity + " " + item.ArtistZIP;
            };

            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    selectionEntry,
                    artistIDLabel,
                    nameLabel,
                    genreLabel,
                    selectButton,
                }
            };
            this.Content = stack1;
        }
    }
}