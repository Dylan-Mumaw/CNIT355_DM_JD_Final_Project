using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SQLite;

namespace FpV3
{
    public partial class MainPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public MainPage()
        {
            InitializeComponent();

            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();
            myDatabase.CreateTable<Manager>();
            myDatabase.CreateTable<Venue>();
            myDatabase.CreateTable<Artist>();
            myDatabase.CreateTable<User>();
        }
    }
}
