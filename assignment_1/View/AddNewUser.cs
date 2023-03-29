using assignment_1.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment_1.View
{
    public partial class AddNewUser : Form, IAddNewUser
    {
        AddNewUserPresenter presenter;
        
        public AddNewUser()
        {
            InitializeComponent();
            presenter = new AddNewUserPresenter(this);
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            roleComboBox.Items.Add("ADMIN");
            roleComboBox.Items.Add("EMPLOYEE");
        }
        public void setAdminPresenter(AdminPresenter p)
        {
            presenter.setAdminPresenter(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.addNewUser();
        }

        string IAddNewUser.getFirstName()
        {
            return firstNameTextBox.Text;
        }

        string IAddNewUser.getLastName()
        {
            return lastNameTextBox.Text;    
        }

        string IAddNewUser.getPassword()
        {
            return paswwordTextBox.Text;
        }

        string IAddNewUser.getRole()
        {
            string selectedItem = roleComboBox.Items[roleComboBox.SelectedIndex].ToString();
            return selectedItem;
        }

        string IAddNewUser.getUserName()
        {
            return usernameTextBox.Text;
        }
        public void close()
        {
            this.Close();
        }
    }
}
