/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;
namespace CNIT355_Final_Project
{
    public class NewArtist : ContentPage
    {
        protected SQLiteConnection myDatabase; //creating new sqlite database connection
        public NewArtist()
        {
           myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.DropTable<Artist>();
            myDatabase.CreateTable<Artist>(); creating new artist table. need to not re-create the table just update it...but for test purposes it should work.
            asked stefanek. realistically you would have a different class create the table so it is not getting recreated everytime. 
            Artist newArtist = new Artist(); declare new instance of an artist object to get access to its functionality 

            Entry idEntry = new Entry
            {
                Placeholder = "Enter new ID here"
            };
            Entry nameEntry = new Entry
            {
                Placeholder = "Enter Full Name"
            };
            Entry genreEntry = new Entry
            {
                Placeholder = "Enter Genre here"
            };
            Label displayLabel = new Label label to display text showing new artist has been added
            {
                Text = ""
            };
            
            Button addArtist = new Button note to self go back to book to steal basic layout options
            {
                Text = "Add new artist",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };
            addArtist.Clicked += (sendernav, args) =>
            {
                var convertedID = Convert.ToInt32(idEntry.Text);
                newArtist.ArtistID = convertedID;
                newArtist.ArtistName = nameEntry.Text;
                newArtist.ArtistGenre = genreEntry.Text;

                myDatabase.Query<Artist>("INSERT INTO Artist VALUES" + "(" + "'" + newArtist.ArtistID + "'" + "," + "'" + newArtist.ArtistName + "'" + "'" + newArtist.ArtistGenre + "'" + ")");
                displayLabel.Text = "Insert successful";
            };

            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    idEntry,
                    nameEntry,
                    addArtist,
                    displayLabel,
                }
            };
            this.Content = stack1;
        }
    }
}*/