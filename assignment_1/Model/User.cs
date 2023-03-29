using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Model
{
    public class User
    {
        private int id;
        private String firstName;
        private String lastName;
        private String username;
        private String password;
        private String role;
        public User(int id, String role, String firstName, String lastName, string username, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.username = username;
            this.password = password;
        }
        public User(String role, String firstName, String lastName, string username, string password)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.username = username;
            this.password = password;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id =id;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public void setFirstName(String firstName)
        {
            this.firstName=firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public String getRole() 
        {
            return role;
        }
        public String getUsername() 
        {
            return username;
        }
        public String getPassword()
        {
            return password;
        }
        public String ToString() 
        { 
            string usr = "User id " + id.ToString() + ", " + firstName + ", " + lastName + ", " +
                username + ", " + password;
            return usr;
        }


    }
}
