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
    public class ClientPresenter
    {
        IClient clientView;
        RentalPropertyRepository rentalRepository;
        DataGridView rentalsTable;
        public ClientPresenter(IClient view)
        {
            clientView = view;
            rentalRepository = new RentalPropertyRepository();
            rentalsTable = view.getDataGridRental();
            setCategories();
            populateTable();
        }

        public void populateTable()
        {
            DataTable table = rentalRepository.filterRentalPropertiesDataTable(getSelectedFilters());
            rentalsTable.DataSource = table;
            rentalsTable.Columns[0].ReadOnly = true;   
        }
        public void setCategories()
        {
            Dictionary<string, List<String>> categories = rentalRepository.getCategories();

            FlowLayoutPanel locationPanel = clientView.getLocationPanel();
            FlowLayoutPanel typePanel = clientView.getTypePanel();
            FlowLayoutPanel roomsPanel = clientView.getRoomsPanel();

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
            FlowLayoutPanel locationPanel = clientView.getLocationPanel();
            FlowLayoutPanel typePanel = clientView.getTypePanel();
            FlowLayoutPanel roomsPanel = clientView.getRoomsPanel();
            
            categories.Add("location",getSelectedCheckBoxes(locationPanel));
            categories.Add("type",getSelectedCheckBoxes(typePanel));
            categories.Add("rooms",getSelectedCheckBoxes(roomsPanel));

            return categories;
        }
        public List<String> getSelectedCheckBoxes(FlowLayoutPanel panel)
        {
            List<String> elements = new List<String>();
            foreach (CheckBox o in panel.Controls.OfType<CheckBox>())
            {
                if(o.Checked) elements.Add(o.Text);
            }
            return elements;
        }
    }
}
