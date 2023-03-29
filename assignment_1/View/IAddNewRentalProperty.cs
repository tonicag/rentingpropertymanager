using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.View
{
    public interface IAddNewRentalProperty
    {
        public String getLocation();
        public String getType();
        public float getPrice();
        public int getRooms();
        public void close();
    }
}
