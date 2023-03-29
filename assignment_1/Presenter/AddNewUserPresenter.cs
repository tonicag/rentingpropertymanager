using assignment_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment_1.Model;
namespace assignment_1.Presenter
{
    public class AddNewUserPresenter
    {
        UserRepository userRepository;
        IAddNewUser view;
        AdminPresenter adminPresenter;
        public AddNewUserPresenter(IAddNewUser view)
        {
            this.view = view;
            userRepository = new UserRepository();  
        }
        public void setAdminPresenter(AdminPresenter aPresenter)
        {
            adminPresenter = aPresenter;
        }
        public void addNewUser()
        {
            string username = view.getUserName();
            string password = view.getPassword();   
            string role = view.getRole();
            string firstname = view.getFirstName();
            string lastname = view.getLastName();

            User user = new User(0,role, firstname,lastname,username,password);
            try
            {
                userRepository.createUser(user);
            }
            catch(Exception ex) {
                MessageBox.Show("Something went wrong!");
                return;
            }
            MessageBox.Show("Succesfully created user"!);
            
            view.close();
            adminPresenter.refresh();

        }



    }
}
