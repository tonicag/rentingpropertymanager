using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
namespace assignment_1.Model
{
    public class DatabaseConnection
    {
        public string connectionString = "Data Source=D://RentingPlatform.sqlite;Version=3;";
        public DatabaseConnection()
        {

        }
        public void createDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile("D://RentingPlatform.sqlite");

                string connectionString = "Data Source=RentingPlatform.sqlite;Version=3;";
                SQLiteConnection m_dbConnection = new SQLiteConnection(connectionString);
                m_dbConnection.Open();
                //MessageBox.Show("DB created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateUsersTable()
        {
            
            Repository p = new Repository(connectionString);
            SQLiteCommand sqliteCmd = p.connection.CreateCommand();
            p.openConnection();
            sqliteCmd.CommandText = "CREATE TABLE IF NOT EXISTS User (userId INTEGER PRIMARY KEY, role VARCHAR(20)," +
                "firstName varchar(50), lastName varchar(50)," +
                "username varchar(50), password varchar(255))";
            try
            {
                sqliteCmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);    
            }
            p.closeConnection();
            
        }
        public void CreateRentingPropertyTable()
        {
            Repository p = new Repository(connectionString);
            SQLiteCommand sqliteCmd = p.connection.CreateCommand();
            p.openConnection();
            sqliteCmd.CommandText = "CREATE TABLE IF NOT EXISTS RentalProperty (rentalId INTEGER PRIMARY KEY," +
                "location varchar(50), price double, type varchar(50), rooms INT)";
            try
            {
                sqliteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            p.closeConnection();
        }
    }
}
