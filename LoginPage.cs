using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace CNIT355_Final_Project
{
	public class LoginPage : ContentPage
	{
        protected SQLiteConnection myDatabase;
        public string currentUser;
        public string userType;
        public LoginPage ()
		{
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.CreateTable<User>();
            var user1 = new User{FirstName = "Dylan", LastName = "Mumaw", Username = "DylanMumaw", Type = "Artist"};
            Label homeLabel = new Label
            {
                Text = "Welcome to FAME's Artist Managment System, please sign in below ",
                FontSize = 30,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Entry nameEntry = new Entry
            {
                Placeholder = "Enter Username" //will only be artist or manager nothing too complex                
            };

            Entry passEntry = new Entry
            {
                Placeholder = "Enter Password"
            };

            Button loginButton = new Button
            {
                Text = "Login"
            };
            loginButton.Clicked += (sendernav, args) =>
            {
               currentUser = myDatabase.Query<User>("SELECT Username FROM User WHERE Username = " + "'" + nameEntry.Text.ToString() + "'").ToString();
               userType = myDatabase.Query<User>("SELECT Type FROM User WHERE Username = " + "'" + currentUser + "'").ToString();
               if(currentUser == null)
               {
                    DisplayAlert("Error", "Create an account to continue.", "OK");
               }
               else if (userType == "Venue")
               {
                    Navigation.PushAsync(new VenueInfoPage());
               }
               else if (userType == "Manager")
               {
                    Navigation.PushAsync(new ManagerInfoPage());
               }
               else if (userType == "Artist")
                {
                    Navigation.PushAsync(new ArtistInfoPage());
                }
            };

            Button accountButton = new Button
            {
                Text = "Create Account"
            };
            accountButton.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new AccountCreation());
            };
            StackLayout stack = new StackLayout
            {
                Children =
                {
                    homeLabel,
                    nameEntry,
                    passEntry,
                    loginButton,
                    accountButton,
                }
            };
            this.Content = stack;
        }
    }
}
