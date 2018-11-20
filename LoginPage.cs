using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CNIT355_Final_Project
{
	public class LoginPage : ContentPage
	{
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
                Text = "Enter Username" //will only be artist or manager nothing too complex
                
            };

            Entry passEntry = new Entry
            {
                Placeholder = "Enter Password"
            };

            Button loginButton = new Button
            {
                Text = "Login"
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
