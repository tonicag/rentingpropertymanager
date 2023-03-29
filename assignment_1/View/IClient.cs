using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.View
{
    public interface IClient
    {
        public DataGridView getDataGridRental();
        public FlowLayoutPanel getLocationPanel();
        public FlowLayoutPanel getTypePanel();
        public FlowLayoutPanel getRoomsPanel();
    }
}
