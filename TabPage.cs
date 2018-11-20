using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CNIT355_Final_Project
{
    class TabPage : TabbedPage
    {
        public TabPage()
        {
            this.Title = "TabbedPage";
            this.Children.Add(new LoginPage() { Title = "Login" });
            this.Children.Add(new ArtistInfoPage() { Title = "Artist Information" });
        }
    }
}
