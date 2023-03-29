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
namespace assignment_1.View
{
    public partial class EmployeeView : Form, IEmployee
    {
        EmployeePresenter presenter;
        public EmployeeView()
        {
            InitializeComponent();
            presenter = new EmployeePresenter(this);
        }
        private void EmployeeView_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRental_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewRental_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            presenter.updateRow(e.RowIndex);
        }

        private void createProperty(object sender, EventArgs e)
        {
            AddNewRentalProperty addNewRentalProperty = new AddNewRentalProperty();
            addNewRentalProperty.setEmployeePresenter(presenter);
            addNewRentalProperty.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.deleteSelection();
        }

        public DataGridView GetDataGridViewRental()
        {
            return dataGridViewRental;
        }

        public FlowLayoutPanel getLocationPanel()
        {
            return locationPanel;
        }

        public FlowLayoutPanel getTypePanel()
        {
            return typePanel;
        }

        public FlowLayoutPanel getRoomsPanel()
        {
            return roomsPanel;
        }
    }
}
