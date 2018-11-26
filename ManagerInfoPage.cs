using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace CNIT355_Final_Project
{
    public class ManagerInfoPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public ManagerInfoPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.CreateTable<Manager>();

            var manager1 = new Manager { ManagerID = 1, ManagerName = "Jerry Cowgill", ArtistManaged = "Bob" };

            myDatabase.Insert(manager1);

            var firstItem = myDatabase.Query<Manager>("SELECT * FROM Manager WHERE ManagerID = 1 ");

            Label managerIDLabel = new Label
            {

            };
            Label nameLabel = new Label
            {

            };
            Label artistManagedLabel = new Label
            {

            };

            managerIDLabel.Text = firstItem.First().ManagerID.ToString();
            nameLabel.Text = firstItem.First().ManagerName;
            artistManagedLabel.Text = firstItem.First().ArtistManaged;

            StackLayout stack1 = new StackLayout
            {
                Children =
                {
                    managerIDLabel,
                    nameLabel,
                    artistManagedLabel,
                }
            };
            this.Content = stack1;
        }
    }
}