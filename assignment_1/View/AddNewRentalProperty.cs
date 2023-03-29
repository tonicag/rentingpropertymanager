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
    public partial class AddNewRentalProperty : Form, IAddNewRentalProperty
    {
        AddNewRentalPresenter presenter;
        
        public AddNewRentalProperty()
        {
            InitializeComponent();
            presenter = new AddNewRentalPresenter(this);
        }
        public void setEmployeePresenter(EmployeePresenter employeePresenter)
        {
            presenter.setEmployeePresenter(employeePresenter);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            presenter.addRentalProperty();
        }

        string IAddNewRentalProperty.getLocation()
        {
            return locationTextBox.Text;
        }

        float IAddNewRentalProperty.getPrice()
        {

             return float.Parse(priceTextBox.Text);

        }

        int IAddNewRentalProperty.getRooms()
        {
            return int.Parse(roomsTextBox.Text);

        }

        string IAddNewRentalProperty.getType()
        {
            return typeTextBox.Text;
        }
        public void close()
        {
            this.Close();
        }
    }
}
