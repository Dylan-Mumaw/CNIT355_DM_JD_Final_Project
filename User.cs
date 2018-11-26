using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CNIT355_Final_Project
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [MaxLength(30)]
        public string Username { get; set; }

        [MaxLength(7)]
        public string Type { get; set; }

        /*[MaxLength(2)]
        public string ArtistState { get; set; }

        [MaxLength(30)]
        public string ArtistCity { get; set; }

        [MaxLength(30)]
        public string ArtistAddress { get; set; }

        [MaxLength(5)]
        public string ArtistZIP { get; set; }

        [MaxLength(15)]
        public string ArtistPhoneNumber { get; set; }

        [MaxLength(15)]
        public string ArtistEmail { get; set; }*/
    }
}
