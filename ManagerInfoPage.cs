using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace FpV3
{
    public class ManagerInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        
        public ManagerInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
           // myDatabase.CreateTable<Manager>(); //maybe move create table functions to different classes. Maybe main class? 

            var manager1 = new Manager { ManagerID = 1, ManagerName = "Jerry Cowgill" };//add rest of manager variables
            myDatabase.Insert(manager1);

            Entry selectionEntry = new Entry
            {
                Placeholder = "Enter ID here"
            };
            Button selectButton = new Button
            {
                Text = "Select Manager",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            Label IDLabel = new Label
            {
                FontSize = 30,
            };
            Label nameLabel = new Label
            {
                FontSize = 30,
            };
            Label addressLabel = new Label
            {
                FontSize = 30,
            };
            Label emailLabel = new Label
            {
                FontSize = 30,
            };

            /*Label artistManagedLabel = new Label
            {
            };*/

            selectButton.Clicked += (sendernav, args) =>
            {
                var item = (myDatabase.Get<Manager>(selectionEntry.Text));
                IDLabel.Text = item.ManagerID.ToString();
                nameLabel.Text = item.ManagerName;
                addressLabel.Text = item.ManagerAddress + " " + item.ManagerCity + " " + item.ManagerZIP;
                emailLabel.Text = item.ManagerEmail;
 
            };


            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    selectionEntry,
                    IDLabel,
                    nameLabel,
                    addressLabel,
                    selectButton,

                    //artistManagedLabel,
                }
            };
            this.Content = stack1;
        }
    }
}