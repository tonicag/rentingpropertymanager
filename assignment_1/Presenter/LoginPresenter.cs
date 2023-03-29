using assignment_1.Model;
using assignment_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Presenter
{
    public class LoginPresenter
    {
        private ILogin loginView;
        private UserRepository uRep;
        public LoginPresenter(ILogin login)
        {
            this.loginView = login;
            this.uRep = new UserRepository();
        }
        public void loginUser()
        {
            string username = loginView.getUsername();
            string password = loginView.getPassword();
            User user = uRep.getUserByUsername(username);
            if(user == null || !user.getPassword().Equals(password))
            {
                //Console.WriteLine("{0}, pass: {1}",user.getUsername(), user.getPassword());
                //Console.WriteLine("{0}, pass: {1}",username, password);
                MessageBox.Show("Invalid password/username!");
                return;
            }
            else
            {

                switch(user.getRole())
                {
                    case "ADMIN":
                        openAdminView();
                        break;
                    case "EMPLOYEE":
                        openEmployeeView();
                        break;
                    default:
                        break;
                }
                //loginView.close();
            }
        }
        public void openEmployeeView()
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
            loginView.hide();
        }
        public void openAdminView()
        {
            AdminView adminView = new AdminView();
            adminView.Show();
            loginView.hide();
        }
    }
}
