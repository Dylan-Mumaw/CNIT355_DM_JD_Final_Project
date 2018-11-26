using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

//using System.ComponentModel;
//using System.Runtime.CompilerServices;

namespace CNIT355_Final_Project
{
    public class ArtistInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public ArtistInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            //myDatabase.DropTable<Artist>();
            myDatabase.CreateTable<Artist>();
            //change this and include an if statement so if table exist just skip re-creating this. 

            var artist1 = new Artist { ArtistID = 1, ArtistName = "Bob", ArtistGenre = "Paint" }; //hard coding in Artist for demo purposes
            var artist2 = new Artist { ArtistID = 2, ArtistName = "Jimmi", ArtistGenre = "Rock" }; //hard coding in Artist for demo purposes

            myDatabase.Insert(artist1);
            //myDatabase.Insert(artist2);
            //myDatabase.Update(artist2);

            Label artistIDLabel = new Label
            {

            };
            Label nameLabel = new Label
            {

            };
            Label genreLabel = new Label
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
                var selectItem = myDatabase.Query<Artist>("SELECT ArtistID, ArtistName FROM Artist WHERE ArtistID =  " + "'" + selectionEntry.Text + "'");
                //sets labels for display purposes
 
                artistIDLabel.Text = selectItem.First().ArtistID.ToString();
     
                nameLabel.Text = selectItem.First().ArtistName;

                genreLabel.Text = selectItem.First().ArtistGenre;
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