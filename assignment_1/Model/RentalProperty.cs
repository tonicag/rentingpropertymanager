using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Model
{
    public class RentalProperty
    {
        public int id;
        public String location;
        public float price;
        public string type;
        public int noRooms;

        public RentalProperty(int id, string location, float price, string type, int noRooms)
        {
            this.id = id;
            this.location = location;
            this.price = price;
            this.type = type;
            this.noRooms = noRooms;
        }
        public void setLocation(String location)
        {
            this.location = location;
        }
        public String getLocation()
        {
            return this.location;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id) 
        {
            this.id = id;
        }
        public float getPrice()
        {
            return price;
        }
        public void setPrice(float price) 
        {
            this.price = price;
        }
        public int getRoomsNo()
        {
            return noRooms;
        }
        public void setRoomsNo(int noRooms)
        {
            this.noRooms = noRooms;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        override
            public String ToString()
            {
            return this.id.ToString() + " " + this.location + " " + this.price.ToString();
            }
    }
}
