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
    public class EmployeePresenter
    {
        IEmployee employeeView;
        RentalPropertyRepository rentalRepository;
        DataTable rentalsTable;
        DataGridView rentalGridView;
        public EmployeePresenter(IEmployee employeeView)
        {
            this.employeeView = employeeView;
            rentalRepository = new RentalPropertyRepository();
            rentalsTable = new DataTable();
            rentalGridView = employeeView.GetDataGridViewRental();
            rentalGridView.DataSource = rentalsTable;
            setCategories();
            populateTable();
        }
        public void populateTable()
        {
            DataTable table = rentalRepository.filterRentalPropertiesDataTable(getSelectedFilters());
            rentalGridView.DataSource = table;
            rentalGridView.Columns[0].ReadOnly = true;
        }
        public void setCategories()
        {
            Dictionary<string, List<String>> categories = rentalRepository.getCategories();

            FlowLayoutPanel locationPanel = employeeView.getLocationPanel();
            FlowLayoutPanel typePanel = employeeView.getTypePanel();
            FlowLayoutPanel roomsPanel = employeeView.getRoomsPanel();

            setCheckBoxes(locationPanel, categories["location"]);
            setCheckBoxes(typePanel, categories["type"]);
            setCheckBoxes(roomsPanel, categories["rooms"]);


        }
        public void resetCategories(Object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());
            populateTable();
        }
        private void setCheckBoxes(FlowLayoutPanel panel, List<String> elements)
        {
            foreach (String t in elements)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = t;
                checkBox.Checked = true;
                checkBox.CheckedChanged += resetCategories;
                panel.Controls.Add(checkBox);
            }
        }
        public Dictionary<string, List<String>> getSelectedFilters()
        {
            Dictionary<string, List<String>> categories = new Dictionary<string, List<String>>();
            FlowLayoutPanel locationPanel = employeeView.getLocationPanel();
            FlowLayoutPanel typePanel = employeeView.getTypePanel();
            FlowLayoutPanel roomsPanel = employeeView.getRoomsPanel();

            categories.Add("location", getSelectedCheckBoxes(locationPanel));
            categories.Add("type", getSelectedCheckBoxes(typePanel));
            categories.Add("rooms", getSelectedCheckBoxes(roomsPanel));

            return categories;
        }
        public List<String> getSelectedCheckBoxes(FlowLayoutPanel panel)
        {
            List<String> elements = new List<String>();
            foreach (CheckBox o in panel.Controls.OfType<CheckBox>())
            {
                if (o.Checked) elements.Add(o.Text);
            }
            return elements;
        }
        public void updateRow(int rowIndex)
        {
            DataGridViewRow row = rentalGridView.Rows[rowIndex];
            RentalProperty rp = new RentalProperty(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(),
                    float.Parse(row.Cells[2].Value.ToString()), row.Cells[3].Value.ToString(), int.Parse(row.Cells[4].Value.ToString()));
            //Console.WriteLine("HERE {0}",row.Cells[0].Value.ToString());   
            rentalRepository.updateRentalProperty(rp);
            Console.WriteLine("Success updating!");
        }
        public void refresh()
        {
            setCategories();
            populateTable(); 
        }
        public void deleteSelection()
        {
            int count = rentalGridView.SelectedRows.Count;
            if(count == 0)
            {
                MessageBox.Show("Please select rows you want to delete!");
                return;
            }
            foreach(DataGridViewRow row in rentalGridView.SelectedRows)
            {
                rentalRepository.deleteRentalProperty(int.Parse(row.Cells[0].Value.ToString()));
            }
            MessageBox.Show("Succesfully deleted " + count.ToString() + " rows!");
            refresh();
        }
    }
}
