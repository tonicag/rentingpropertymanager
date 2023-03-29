using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment_1.Presenter;
using assignment_1.Model;
namespace assignment_1.View
{
    public partial class LoginView : Form, ILogin
    {
        private LoginPresenter loginPresenter;
        public LoginView()
        {
            InitializeComponent();
            DatabaseConnection db = new DatabaseConnection();
            //db.createDatabase();
            //db.CreateUsersTable();
            //db.CreateRentingPropertyTable();
            loginPresenter = new LoginPresenter(this);
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClientView clientView = new ClientView();
                clientView.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public String getUsername()
        {
            return usernameInput.Text;
        }
        public String getPassword()
        {
            return passwordInput.Text;
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginPresenter.loginUser();
        }
        public void close()
        {
            this.Close();
        }
        public void hide()
        {
            this.Hide();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
