using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CNIT355_Final_Project
{
	public class ArtistInfoPage : ContentPage
	{
		public ArtistInfoPage ()
		{
            Artist a1 = new Artist()
           {
                ArtistID = 1, //this will be equal to some data from a database instead. Fed into an intermediatary like the artist class
                ArtistName = "Bob Ross",
                ArtistGenre = "Painter"
            };
            Label idLabel = new Label
            {
                Text = a1.ArtistID.ToString(),
            };
            Label nameLabel = new Label
            {
                Text = a1.ArtistName,
            };
           Label genreLabel = new Label
           {
               Text = a1.ArtistGenre,
           };

           Content = new StackLayout {
           Children = {
           new Label { Text = "Welcome to Xamarin.Forms!" }
           }
           };
        }
    }
}