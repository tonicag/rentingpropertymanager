using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Model
{
    

    public class Repository
    {
        public SQLiteConnection connection;

        public string connectionString = "Data Source=D://RentingPlatform.sqlite;Version=3;";
        public Repository()
        {
            connection = new SQLiteConnection(connectionString);    
        }
        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SQLiteConnection(connectionString);
        }

        public void openConnection()
        {
            connection.Open();  
        }
        public void closeConnection()
        {
            connection.Close(); 
        }

        public bool executeStatement(String sqlQuery)
        {
            bool success = true;
            this.openConnection();
            SQLiteCommand command = this.connection.CreateCommand();
            command.CommandText = sqlQuery; 
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                success = false;
            }
            this.closeConnection();
            return success;
        }
        public DataTable? queryStatement(String sqlQuery)
        {
            this.openConnection();
            SQLiteCommand command = this.connection.CreateCommand();
            command.CommandText = sqlQuery;
            DataTable dataTable = new DataTable();
            SQLiteDataReader dataReader = null;
            try
            {
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Here!");
                dataTable = null;
            }
            this.closeConnection(); 
            return dataTable;
        }

        
    }
}
