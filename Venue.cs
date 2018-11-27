using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace CNIT355_Final_Project
{
    class Venue
    {
        //class for each Venue, Artist, Manager set up for database interactiability

        [PrimaryKey, AutoIncrement]
        public int VenueID { get; set; }

        [MaxLength(30)]
        public string VenueName { get; set; }

        [MaxLength(2)]
        public string VenueState { get; set; }

        [MaxLength(30)]
        public string VenueCity { get; set; }

        [MaxLength(50)]
        public string VenueAddress { get; set; }

        [MaxLength(5)]
        public string VenueZIP { get; set; }
    }
}
