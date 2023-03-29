using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.View
{
    public interface IAddNewUser
    {
        public String getUserName();
        public String getFirstName();
        public String getLastName();
        public String getPassword();
        public String getRole();
        public void close();
    }
}
