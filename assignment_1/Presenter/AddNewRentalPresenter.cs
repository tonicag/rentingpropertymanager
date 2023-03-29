using assignment_1.Model;
using assignment_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Presenter
{
    public class AddNewRentalPresenter
    {
        EmployeePresenter employeePresenter;
        IAddNewRentalProperty view;
        public AddNewRentalPresenter(IAddNewRentalProperty view)
        {
            this.view = view;
        }
        public void setEmployeePresenter(EmployeePresenter employeePresenter)
        {
            this.employeePresenter = employeePresenter;
        }
        public void addRentalProperty()
        {
            try
            {
                String location = view.getLocation();
                String type = view.getType();
                float price = view.getPrice();
                int rooms = view.getRooms();

                new RentalPropertyRepository().addRentalProperty(new RentalProperty(0, location, price, type, rooms));
                employeePresenter.refresh();
                MessageBox.Show("Succesfully added RentalProperty!");
                view.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("InvalidInput!");
            }
        }
            

    }
}
