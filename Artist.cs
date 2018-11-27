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
        
        [MaxLength(30)]
        public string ArtistName { get; set; }
        
        [MaxLength(25)]
        public string ArtistGenre { get; set; }
        
        [MaxLength(1566)]
        public string ArtistBio { get; set; }
		
		[MaxLength(9)]
        public string YearsActive { get; set; }

        [MaxLength(2)]
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
        public string ArtistEmail { get; set; }

        [MaxLength(50)]
        public string ManagedBy { get; set; }

        /*[PrimaryKey, AutoIncrement]
         public int ArtistID
         {
             get
             {
                 return ArtistID;
             }
             set
             {
                 ArtistID = value;
                 OnPropertyChanged("ArtistID"); //this invokes the OnPropertyChanged method.
             }
         }*/
        /*public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged("Description"); //this invokes the OnPropertyChanged method.
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/


    }
}
