using assignment_1.Model;
using assignment_1.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Presenter
{
    public class AdminPresenter
    {
        IAdmin view;
        DataGridView userGridView;
        UserRepository userRepository;
        public AdminPresenter(IAdmin view)
        {
            this.view = view;   
            userGridView = view.getUserGrid();
            userRepository = new UserRepository();
            populateTable();
        }
        public void populateTable()
        {
            DataTable dataTable = userRepository.getAllUsersDataTable();
            userGridView.DataSource = dataTable;
            userGridView.Columns[0].ReadOnly = true;
            userGridView.AllowUserToAddRows = false;
        }
        public void delete()
        {
            int count = userGridView.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("Please select rows you want to delete!");
                return;
            }
            foreach (DataGridViewRow row in userGridView.SelectedRows)
            {
                userRepository.deleteUser(int.Parse(row.Cells[0].Value.ToString()));
            }
            MessageBox.Show("Succesfullt deleted " + count + " rows!");
            refresh();
        }
        public void update(int rowIndex)
        {
            DataGridViewRow row = userGridView.Rows[rowIndex];
            User user = new User(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
           
            userRepository.updateUser(user);
        }
        public void addNewUser()
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.setAdminPresenter(this);
            addNewUser.Show();
        }
        public void refresh()
        {
            populateTable();
        }
    }
}
