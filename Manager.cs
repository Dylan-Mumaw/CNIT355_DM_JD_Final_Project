using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CNIT355_Final_Project
{
    class Manager
    {
        /* public int ManagerID;
         public string ManagerName;
         public string ManagedArtist;*/

        [PrimaryKey, AutoIncrement]
        public int ManagerID { get; set; }

        [MaxLength(20)]
        public string ManagerFirst { get; set; }

        [MaxLength(20)]
        public string ManagerLast { get; set; }

        [MaxLength(2)]
        public string ManagerState { get; set; }

        [MaxLength(30)]
        public string ManagerCity { get; set; }

        [MaxLength(30)]
        public string ManagerAddress { get; set; }

        [MaxLength(5)]
        public string ManagerZIP { get; set; }

        [MaxLength(15)]
        public string ManagerPhoneNumber { get; set; }

        [MaxLength(15)]
        public string ManagerEmail { get; set; }
    }
}
