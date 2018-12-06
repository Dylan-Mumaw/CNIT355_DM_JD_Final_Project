using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace FpV3
{
    public class AccountCreation : ContentPage
    {
        
        protected SQLiteConnection myDatabase;
        StackLayout currentStack;

        public AccountCreation()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            //NEW USER INFO ENTRY
            Label userIDLabel = new Label
            {
                Text = "Enter ID: "
            };
            Entry userIDEntry = new Entry
            {

            };
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
                Text = "Create User"
            };

            Picker statePicker = new Picker
            {
                Title = "State"
            };
            var stateOptions = new List<string> {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI",
                                                 "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI",
                                                 "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC",
                                                 "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT",
                                                 "VT", "VA", "WA", "WV", "WI", "WY"};
            foreach (string state in stateOptions)
            {
                statePicker.Items.Add(state);
            }

            //NEW VENUE INFO - IF VENUE MAKE THIS VISIBLE
            Label venIDLabel = new Label
            {
                Text = "Enter venue ID: "
            };
            Entry venIDEntry = new Entry
            {

            };
            Label venNameLabel = new Label
            {
                Text = "Venue Name: "
            };
            Entry venNameEntry = new Entry
            {
            };

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
            //END VENUE

            //NEW ARTIST INFO - IF ARTIST MAKE THIS VISIBLE
            Label artIDLabel = new Label
            {
                Text = "Enter artist ID: "
            };
            Entry artIDEntry = new Entry
            {
            
            };
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
            //END ARTIST

            //NEW MANAGER INFO - IF MANAGER MAKE THIS VISIBLE
            Label manIDLabel = new Label
            {
                Text = "ID: "
            };
            Entry manIDEntry = new Entry
            {
            };
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
            //END MANAGER

            //PAY INFO
            Label billLabel = new Label
            {
                Text = "Billing Address:"
            };
            Entry billEntry = new Entry
            {
            };

            Label bankLabel = new Label
            {
                Text = "Bank: "
            };
            Entry bankEntry = new Entry
            {
            };

            Label routingLabel = new Label
            {
                Text = "Routing #: "
            };
            Entry routingEntry = new Entry
            {
            };

            Label accLabel = new Label
            {
                Text = "Account #: "
            };
            Entry accEntry = new Entry
            {
            };

            Button createButton = new Button
            {
                Text = "Create Account"
            };


            //StackLayout payStack = new StackLayout
            //{
            //    Children =
            //    {
            //        billLabel,
            //        billEntry,
            //        bankLabel,
            //        bankEntry,
            //        routingLabel,
            //        routingEntry,
            //        accLabel,
            //        accEntry
            //    }
            //};
            StackLayout userStack = new StackLayout
            {
                Children =
                {
                    userIDLabel,
                    userIDEntry,
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
                    venIDLabel,
                    venIDEntry,
                    venNameLabel,
                    venNameEntry,
                    venCityLabel,
                    venCityEntry,
                    statePicker,
                    venAddLabel,
                    venAddEntry,
                    venZIPLabel,
                    venZIPEntry,
                    //payStack,
                    createButton
                }
            };
            StackLayout artStack = new StackLayout
            {
                Children =
                {
                    artIDLabel,
                    artIDEntry,
                    artNameLabel,
                    artNameEntry,
                    artManLabel,
                    //artManEntry,
                    //artGenLabel,
                    //artGenEntry,
                    //artBioLabel,
                    //artBioEntry,
                    //artYearsLabel,
                    //artYearsEntry,
                    statePicker,
                    artCityLabel,
                    artCityEntry,
                    artAddLabel,
                    artAddEntry,
                    artZIPLabel,
                    artZIPEntry,
                    artEmailLabel,
                    artEmailEntry,
                    artPhoneLabel,
                    artPhoneEntry,
                    //payStack,
                    createButton
                }
            };
            StackLayout manStack = new StackLayout
            {
                Children =
                {
                    manIDLabel,
                    manIDEntry,
                    manCityLabel,
                    manCityEntry,
                    statePicker,
                    manAddLabel,
                    manAddEntry,
                    manZIPLabel,
                    manZIPEntry,
                    manEmailLabel,
                    manEmailEntry,
                    //payStack,
                    createButton
                }
            };


            StackLayout mainStack = new StackLayout
            {
                Children =
                {
                    userStack,
                }
            };
            newUserButton.Clicked += (sender, args) =>
            {
                Validate();
            };

            bool Validate()
            {
                if (firstEntry == null || lastEntry == null || userEntry == null || typePicker.SelectedItem == null)
                {
                    DisplayAlert("Alert", "Please fill out all required fields", "OK");
                    return false;
                }
                else
                {
                    if (typePicker.SelectedItem.ToString() == "Venue")
                    {
                        currentStack = venStack;
                        mainStack.Children.Add(venStack);
                    }
                    if (typePicker.SelectedItem.ToString() == "Manager")
                    {
                        currentStack = manStack;
                        mainStack.Children.Add(manStack);   
                    }
                    if (typePicker.SelectedItem.ToString() == "Artist")
                    {
                        currentStack = artStack;
                        mainStack.Children.Add(artStack);
                    }
               
                    User newUser = new User();

                    newUser.UserID = Convert.ToInt32(userIDEntry.Text);
                    newUser.Username = userEntry.Text;
                    newUser.FirstName = firstEntry.Text;
                    newUser.LastName = lastEntry.Text;
                    newUser.Type = typePicker.SelectedItem.ToString();
                    myDatabase.Insert(newUser);

                    if (newUser.UserID != 0)
                    {
                        myDatabase.Update(newUser);
                    }
                    else
                    {
                        myDatabase.Insert(newUser);
                    }
                    DisplayAlert("Insert successful", "Insert Successful", "Ok");
                    DisplayAlert("Thanks!", "Please fill out the following fields", "OK");
                    return true;
                }
            };

            createButton.Clicked += (sender, args) =>
            {
                if (typePicker.SelectedItem.ToString() == "Venue")
                {
                    Venue newVenue = new Venue();

                    newVenue.VenueName = venNameEntry.Text;
                    newVenue.VenueAddress = venAddEntry.Text;
                    newVenue.VenueCity = venCityEntry.Text;
                    //newVenue.VenueState = statePicker.SelectedItem.ToString();
                    newVenue.VenueZIP = venZIPEntry.Text;

                    if (newVenue.VenueID != 0)
                    {
                        myDatabase.Update(newVenue);
                    }
                    else
                    {
                        myDatabase.Insert(newVenue);
                    }

                    DisplayAlert("Insert", "Insert into venue", "ok");
                }
                else if (typePicker.SelectedItem.ToString() == "Artist")
                {
                    Artist newArtist = new Artist();

                    newArtist.ArtistName = artNameEntry.Text;
                    newArtist.ArtistAddress = artAddEntry.Text;
                    newArtist.ArtistCity = artCityEntry.Text;
                    //newArtist.ArtistState = statePicker.SelectedItem.ToString();
                    newArtist.ArtistZIP = artZIPEntry.Text;

                    if (newArtist.ArtistID != 0)
                    {
                        myDatabase.Update(newArtist);
                    }
                    else
                    {
                        myDatabase.Insert(newArtist);
                    }
                    DisplayAlert("Insert", "Inserted into artist", "ok");
                }
                else if (typePicker.SelectedItem.ToString() == "Manager")
                {
                    var newManager1 = new Manager();

                    newManager1.ManagerID = Convert.ToInt32(manIDEntry.Text);
                    newManager1.ManagerName = firstEntry.Text + lastEntry.Text;
                    newManager1.ManagerAddress = manAddEntry.Text;
                    newManager1.ManagerCity = manCityEntry.Text;
                   // newManager1.ManagerState = statePicker.SelectedItem.ToString();
                    newManager1.ManagerZIP = manZIPEntry.Text;
                    newManager1.ManagerEmail = manEmailEntry.Text;


                    if (newManager1.ManagerID != 0)
                        {
                            myDatabase.Update(newManager1);
                        }
                        else
                        {
                            myDatabase.Insert(newManager1);
                        }
                    DisplayAlert("Insert", "Inserted into manager", "ok");
                }
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = mainStack
            };
            this.Content = scrollView;
        }
    }
}