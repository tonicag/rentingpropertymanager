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

namespace assignment_1.View
{
    public partial class AdminView : Form, IAdmin
    {
        AdminPresenter presenter;
        public AdminView()
        {
            InitializeComponent();
            presenter = new AdminPresenter(this);
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }
        public DataGridView getUserGrid()
        {
            return userGridView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.addNewUser();
        }

        private void userGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            presenter.update(e.RowIndex);
        }
    }
}
