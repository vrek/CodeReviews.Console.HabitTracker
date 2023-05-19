using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.vrek
{
    internal class Database
    {
        public void CreateDatabase(string datebaseName)
        {

        }
        public void TestDatabase(string databaseName)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection())
                {
                    connection.Open();
                }
            }
        }
    }

}
