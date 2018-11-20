using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CNIT355_Final_Project
{
    interface IDatabase
    {
        SQLiteConnection ConnectToDB();
    }
}
