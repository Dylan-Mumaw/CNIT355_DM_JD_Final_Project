using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace CNIT355_Final_Project
{
	public class AccountCreation : ContentPage
	{
        protected SQLiteConnection myDatabase;
		public AccountCreation ()
		{
            //NEW USER INFO ENTRY
            Label firstLabel = new Label
            {
                Text = "First Name: "
            };
            Entry firstEntry = new Entry
            {
            };

            Label lastLabel = new Label
            {
                Text = "Last Name: "
            };
            Entry lastEntry = new Entry
            {
            };

            Label userLabel = new Label
            {
                Text = "Username: "
            };
            Entry userEntry = new Entry
            {
            };

            Picker typePicker = new Picker
            {
                Title = "User Type:"
            };
            var options = new List<string> { "Venue", "Manager", "Artist" };
            foreach (string optionName in options)
            {
                typePicker.Items.Add(optionName);
            }

            Button newUserButton = new Button
            {
                Text = "Create Account"
            };
            newUserButton.Clicked += (sender, args) =>
            {
                if(UserValidate())
                {
                    if (typePicker.SelectedItem.ToString() == "Venue")
                    {
                        //Make VENUE info visible
                    }
                    if (typePicker.SelectedItem.ToString() == "Manager")
                    {
                        //Make MANAGER info visible
                    }
                    if (typePicker.SelectedItem.ToString() == "Artist")
                    {
                        //Make ARTIST info visible
                    }
                }
            };
            bool UserValidate()
            {
                if (firstEntry == null || lastEntry == null || userEntry == null || typePicker.SelectedItem == null)
                {
                    DisplayAlert("Alert", "Please fill out all required fields", "OK");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //NEW VENUE INFO - IF VENUE MAKE THIS VISIBLE
            Label venNameLabel = new Label
            {
                Text = "Venue Name: "
            };
            Entry venNameEntry = new Entry
            {
            };

            //State DropDownList

            Label venCityLabel = new Label
            {
                Text = "City"
            };
            Entry venCityEntry = new Entry
            {
            };

            Label venAddLabel = new Label
            {
                Text = "Venue Address: "
            };
            Entry venAddEntry = new Entry
            {
            };

            Label venZIPLabel = new Label
            {
                Text = "ZIP: "
            };
            Entry venZIPEntry = new Entry
            {
            };

            Label venEmailLabel = new Label
            {
                Text = "Email Address: "
            };
            Entry venEmailEntry = new Entry
            {
            };

            Label venPhoneLabel = new Label
            {
                Text = "Contact Number: "
            };
            Entry venPhoneEntry = new Entry
            {
            };

            //VENUE PAY INFO
            Label venBillLabel = new Label
            {
                Text = "Billing Address:"
            };
            Entry venBillEntry = new Entry
            {
            };

            Label venBankLabel = new Label
            {
                Text = "Bank: "
            };
            Entry venBankEntry = new Entry
            {
            };

            Label venRoutingLabel = new Label
            {
                Text = "Routing #: "
            };
            Entry venRoutingEntry = new Entry
            {
            };

            Label venAccLabel = new Label
            {
                Text = "Account #: "
            };
            Entry venAccEntry = new Entry
            {
            };

            Button newVenueButton = new Button
            {
                Text = "Create Venue Account"
            };
            newUserButton.Clicked += (sendernav, args) =>
            {
                myDatabase.Query<Venue>("INSERT INTO Venue VALUES" + "(" + "'");
            };//FILL IN

            bool VenueValidate()
            {
                if (venNameEntry == null || venCityEntry == null || venAddEntry == null || venZIPEntry == null)
                {
                    DisplayAlert("Alert", "Please fill out all required fields", "OK");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //END VENUE

            //NEW ARTIST INFO - IF ARTIST MAKE THIS VISIBLE
            Label artNameLabel = new Label
            {
                Text = "Artist/Group Name: "
            };
            Entry artNameEntry = new Entry
            {
            };

            Label artManLabel = new Label
            {
                Text = "Manager (IN if independent): "
            };
            Entry artManEntry = new Entry
            {
            };

            Label artGenLabel = new Label
            {
                Text = "Genre: "
            };
            Entry artGenEntry = new Entry
            {
            };

            Label artBioLabel = new Label
            {
                Text = "Bio/Description (max 1566 char*): "
            };
            Entry artBioEntry = new Entry
            {
            };

            Label artYearsLabel = new Label
            {
                Text = "Years Active (xxxx-xxxx): "
            };
            Entry artYearsEntry = new Entry
            {
            };

            //State DropDownList
            Label artCityLabel = new Label
            {
                Text = "City: "
            };
            Entry artCityEntry = new Entry
            {
            };

            Label artAddLabel = new Label
            {
                Text = "Mailing Address: "
            };
            Entry artAddEntry = new Entry
            {
            };

            Label artZIPLabel = new Label
            {
                Text = "ZIP: "
            };
            Entry artZIPEntry = new Entry
            {
            };

            Label artEmailLabel = new Label
            {
                Text = "Email Address: "
            };
            Entry artEmailEntry = new Entry
            {
            };

            Label artPhoneLabel = new Label
            {
                Text = "Contact Number: "
            };
            Entry artPhoneEntry = new Entry
            {
            };

            //ARTIST PAY INFO
            Label artBillLabel = new Label
            {
                Text = "Billing Address:"
            };
            Entry artBillEntry = new Entry
            {
            };

            Label artBankLabel = new Label
            {
                Text = "Bank: "
            };
            Entry artBankEntry = new Entry
            {
            };

            Label artRoutingLabel = new Label
            {
                Text = "Routing #: "
            };
            Entry artRoutingEntry = new Entry
            {
            };

            Label artAccLabel = new Label
            {
                Text = "Account #: "
            };
            Entry artAccEntry = new Entry
            {
            };
            //END ARTIST

            //NEW MANAGER INFO - IF MANAGER MAKE THIS VISIBLE
            Label manFirstLabel = new Label
            {
                Text = "First Name: "
            };
            Entry manFirstEntry = new Entry
            {
            };

            Label artLastLabel = new Label
            {
                Text = "Last Name: "
            };
            Entry artLastEntry = new Entry
            {
            };
            

            //State DropDownList
            Label manCityLabel = new Label
            {
                Text = "City: "
            };
            Entry manCityEntry = new Entry
            {
            };

            Label manAddLabel = new Label
            {
                Text = "Mailing Address: "
            };
            Entry manAddEntry = new Entry
            {
            };

            Label manZIPLabel = new Label
            {
                Text = "ZIP: "
            };
            Entry manZIPEntry = new Entry
            {
            };

            Label manEmailLabel = new Label
            {
                Text = "Email Address: "
            };
            Entry manEmailEntry = new Entry
            {
            };

            //MANAGER PAY INFO
            Label manBillLabel = new Label
            {
                Text = "Billing Address:"
            };
            Entry manBillEntry = new Entry
            {
            };

            Label manBankLabel = new Label
            {
                Text = "Bank: "
            };
            Entry manBankEntry = new Entry
            {
            };

            Label manRoutingLabel = new Label
            {
                Text = "Routing #: "
            };
            Entry manRoutingEntry = new Entry
            {
            };

            Label manAccLabel = new Label
            {
                Text = "Account #: "
            };
            Entry manAccEntry = new Entry
            {
            };
            //END MANAGER

            Button createButton = new Button
            {
                Text = "Create Account"
            };

            createButton.Clicked += (sender, args) =>
            {
                /*if (Validate())
                {

                }*/
            };

            /*bool Validate()
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
            }*/

            StackLayout userStack = new StackLayout
            {
                Children =
                {
                    firstLabel,
                    firstEntry,
                    lastLabel,
                    lastEntry,
                    userLabel,
                    userEntry,
                    typePicker,
                    newUserButton
                }
            };
            StackLayout venStack = new StackLayout
            {
                Children =
                {
                    venNameLabel,
                    venNameEntry,
                    venCityLabel,
                    venCityEntry,
                    venAddLabel,
                    venAddEntry,
                    venZIPLabel,
                    venZIPEntry
                }
            };
            StackLayout artStack = new StackLayout
            {
                Children =
                {
                    artNameLabel,
                    artNameEntry,
                    artManLabel,
                    artManEntry,
                    artGenLabel,
                    artGenEntry,
                    artBioLabel,
                    artBioEntry,
                    artYearsLabel,
                    artYearsEntry,
                    artCityLabel,
                    artCityEntry,
                    artAddLabel,
                    artAddEntry,
                    artZIPLabel,
                    artZIPEntry,
                    artEmailLabel,
                    artEmailEntry,
                    artPhoneLabel,
                    artPhoneEntry
                }
            };

            StackLayout mainStack = new StackLayout
            {
                
            };
            this.Content = mainStack;
		}
	}
}