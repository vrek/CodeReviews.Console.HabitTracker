using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.vrek
{
    internal class db_connect
    {
        
        public SQLiteConnection createConnection()
        {
            SQLiteConnection conn;
            string db_file = $"Habit.db3";
            if (System.IO.File.Exists(db_file))
            {
                Console.WriteLine($"The file exist and is stored at {db_file}");
                conn = new SQLiteConnection($"{db_file}; Version = 3; New = False; Compress = True;");
            }
            else
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(db_file);
                conn = new SQLiteConnection($"Data Source = {db_file}; Version = 3; New = True; Compress = True;");

                if (System.IO.File.Exists(db_file))
                {
                    Console.WriteLine($"The file was created and is stored at {db_file}");
                }
                else
                {
                    Console.WriteLine("The file was not created");
                }
                CreateSchema(conn);
                conn = new SQLiteConnection("");
            }
            return conn;
        }
        public void CreateSchema(SQLiteConnection conn)
        {
            SQLiteCommand command = null;
            string createSql = "CREATE TABLE Habits" +
                "(" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Name VARCHAR" +
                ")";
            command = conn.CreateCommand(createSql);
            command.ExecuteNonQuery();

        }
    }
}
