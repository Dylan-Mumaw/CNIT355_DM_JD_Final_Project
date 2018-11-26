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
        public LoginPage ()
		{
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
                myDatabase.Query<User>("SELECT Username FROM User WHERE Username = " + nameEntry.Text);
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
