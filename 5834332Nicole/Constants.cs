using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5834332Nicole
{
    public static class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db";
        public const SQLite.SQLiteOpenFlags flags =

       SQLite.SQLiteOpenFlags.ReadWrite |
       SQLite.SQLiteOpenFlags.Create |
       SQLite.SQLiteOpenFlags.SharedCache;


        public static string DatabasePath =>
        Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    }


}
