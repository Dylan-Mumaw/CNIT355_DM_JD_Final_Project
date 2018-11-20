using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CNIT355_Final_Project
{
    class Artist
    {
        [PrimaryKey, AutoIncrement]
        public int ArtistID { get; set; }
        
        [MaxLength(50)]
        public string ArtistName { get; set; }
        
        [MaxLength(25)]
        public string ArtistGenre { get; set; }
        
        [MaxLength(50)]
        public string ArtistBio { get; set; }
    }
}
