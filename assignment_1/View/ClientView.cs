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
    public partial class ClientView : Form, IClient
    {
        ClientPresenter presenter;

        public ClientView()
        {
            InitializeComponent();
            presenter = new ClientPresenter(this);

            
        }

        private void dataGridRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientView_Load(object sender, EventArgs e)
        {

        }
        public DataGridView getDataGridRental()
        {
            return dataGridRental;
        }

        private void dataGridRental_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("row {0} changed", e.RowIndex);

        }
        private void dataGridRental_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("Row header double click!");
            
        }
        private void ClientView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        FlowLayoutPanel IClient.getLocationPanel()
        {
            return locationPanel;
        }

        FlowLayoutPanel IClient.getTypePanel()
        {
            return typePanel;
        }

        FlowLayoutPanel IClient.getRoomsPanel()
        {
            return roomsPanel;
        }
    }
}
