using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CNIT355_Final_Project
{
	public class AccountCreation : ContentPage
	{
		public AccountCreation ()
		{
            Entry firstEntry = new Entry
            {
                Placeholder = "*First Name:"
            };

            Entry lastEntry = new Entry
            {
                Placeholder = "*Last Name:"
            };

            Entry venueName = new Entry
            {
                Placeholder = "Venue Name"
            };

            Entry billingAddress = new Entry
            {
                Placeholder = "Billing Adress: "
            };

            Entry cardEntry = new Entry
            {
                Placeholder = "Card #: "
            };

            Entry cvEntry = new Entry
            {
                Placeholder = "CV"
            };

            Entry expEntry = new Entry
            {
                Placeholder = "Exp Date: "
            };

            Button createButton = new Button
            {
                Text = "Create Account"
            };

            createButton.Clicked += (sender, args) =>
            {
                if (Validate())
                {

                }
            };

            bool Validate()
            {
                if (firstEntry == null || lastEntry == null || venueName == null || billingAddress == null || 
                    cardEntry == null || cvEntry == null || expEntry == null)
                {
                    DisplayAlert("Error", "Please enter information into all required fields", "OK");
                    return false;
                }
                else
                {
                    return false;
                }
            }

            StackLayout stack = new StackLayout
            {
                Children =
                {
                    firstEntry,
                    lastEntry,
                    venueName,
                    billingAddress,
                    cardEntry,
                    cvEntry,
                    expEntry
                }
            };
            this.Content = stack;
		}
	}
}