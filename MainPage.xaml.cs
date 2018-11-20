using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace CNIT355_Final_Project
{
    public partial class MainPage : ContentPage
    {
        public SQLiteConnection myDatabase;
        public MainPage()
        {
            InitializeComponent();

            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.CreateTable<Artist>();

            var artist1 = new Artist { ArtistID = 1, ArtistName = "Bob", ArtistGenre = "Paint" };

            myDatabase.Insert(artist1);

            var firstItem = myDatabase.Query<Artist>("SELECT * FROM Artist WHERE ArtistName = 'Bob' ");

            Label nameLabel = new Label
            {

            };
            Label aidLabel = new Label
            {

            };
            Label descriptLabel = new Label
            {

            };

            nameLabel.Text = firstItem.First().ArtistName;
            aidLabel.Text = firstItem.First().ArtistID.ToString();
            descriptLabel.Text = firstItem.First().ArtistGenre;

            StackLayout stack = new StackLayout
            {
                Children =
                {
                    nameLabel,
                    aidLabel,
                    descriptLabel,
                }
            };
            this.Content = stack;
        }
    }
}
