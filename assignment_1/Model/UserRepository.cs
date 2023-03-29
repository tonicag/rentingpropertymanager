using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace assignment_1.Model
{
    public class UserRepository
    {
        private Repository repository;
        public UserRepository(Repository repository) 
        {
            this.repository = repository; 
        }
        public UserRepository()
        {
            this.repository = new Repository();
        }
        public bool createUser(User user)
        {
            string query = " INSERT INTO User(role, firstName, lastName, username, password) VALUES(" +
                "\"" + user.getRole() + "\",\"" + user.getFirstName() + "\",\"" + user.getLastName() + "\",\"" + 
                user.getUsername()+ "\",\"" + user.getPassword() + "\")";
            Console.Write(query);
            return repository.executeStatement(query);
        }
        public bool updateUser(User user)
        {
            string query = "UPDATE User SET " +
                "role=" + "\"" + user.getRole() + "\"," +
                "firstName=" + "\"" + user.getFirstName() + "\"," +
                "lastName=" + "\"" + user.getLastName() + "\"," +
                "username=" + "\"" + user.getUsername() + "\"," +
                "password=" + "\"" + user.getPassword() + "\" WHERE " +
                "userId = " + user.getId().ToString();
            Console.Write(query);
            return repository.executeStatement(query);  
        }
        public User getUserById(int id)
        {
            string query = "SELECT * FROM User WHERE userId = " + id.ToString();
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            DataRow row = dataTable.Rows[0];
            return new User(int.Parse(row["userId"].ToString()), row["role"].ToString(), row["firstname"].ToString(),
                row["lastName"].ToString(), row["username"].ToString(), row["password"].ToString());

        }
        public User getUserByUsername(string username)
        {
            string query = "SELECT * FROM User WHERE username = \"" + username.ToString() + "\"";
            Console.WriteLine(query);
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            if (dataTable.Rows.Count == 0)
                return null;
            DataRow? row = dataTable.Rows[0];
            
            return new User(int.Parse(row["userId"].ToString()), row["role"].ToString(), row["firstname"].ToString(),
                row["lastName"].ToString(), row["username"].ToString(), row["password"].ToString());

        }
        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM User";
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            foreach(DataRow row in dataTable.Rows)
            {
                User user = new User(int.Parse(row["userId"].ToString()), row["role"].ToString(), row["firstname"].ToString(),
                row["lastName"].ToString(), row["username"].ToString(), row["password"].ToString());
                users.Add(user);
                Console.Write(user.ToString());
            }
            return users;
            
        }
        public DataTable getAllUsersDataTable()
        {
            
            string query = "SELECT * FROM User";
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            return dataTable;

        }
        public bool deleteUser(int userId)
        {
            string query = "DELETE FROM User WHERE userId = " + userId.ToString();
            return repository.executeStatement(query);
        }
    }
}
