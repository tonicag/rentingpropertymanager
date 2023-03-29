using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.View
{
    public interface IEmployee
    {
        public DataGridView GetDataGridViewRental();
        public FlowLayoutPanel getLocationPanel();
        public FlowLayoutPanel getTypePanel();
        public FlowLayoutPanel getRoomsPanel();
    }
}
