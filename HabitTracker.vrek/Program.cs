using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace HabitTracker.vrek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            db_connect database = new db_connect();
            database.createConnection();
         
        }
    }

}