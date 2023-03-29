using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Model
{
    public class RentalPropertyRepository
    {
        Repository repository;
        public RentalPropertyRepository(Repository repository)
        {
            this.repository = repository;
        }
        public RentalPropertyRepository()
        {
            this.repository = new Repository();
        }
        public void addRentalProperty(RentalProperty rp)
        {
            string query = "INSERT INTO RentalProperty (location, type, price, rooms) VALUES(" +
                "\"" + rp.getLocation() + "\",\"" + rp.getType() + "\"," + rp.getPrice().ToString() + "," + rp.getRoomsNo().ToString() + 
                ")";
            Console.WriteLine(query);
            repository.executeStatement(query);
        }
        public RentalProperty getRentalProperty(int id)
        {
            RentalProperty rp = null;
            string query = "SELECT * FROM RentalProperty WHERE rentalId = 1";

            DataTable dt = repository.queryStatement(query);
            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            rp = new RentalProperty(int.Parse(row[0].ToString()), row[1].ToString(), 
                    float.Parse(row[2].ToString()),row[3].ToString(), int.Parse(row[4].ToString()));
            Console.WriteLine(rp);
            return rp;
        }
        public bool updateRentalProperty(RentalProperty rp)
        {
            //loc, price, type, rooms 
            bool success = true;

            string query = "UPDATE RentalProperty " +
                "SET location=\"" + rp.getLocation().ToString() + "\"," +
                "price=" + rp.getPrice().ToString() + "," +
                "type=\"" + rp.getType().ToString() + "\"," +
                "rooms=" + rp.getRoomsNo().ToString() + " " +
                "WHERE rentalId=" + rp.getId();

            success = repository.executeStatement(query);

            return success;
        }
        public bool deleteRentalProperty(int id)
        {
            bool success = true;

            string query = "DELETE FROM RentalProperty WHERE rentalId = " + id.ToString();
            success = repository.executeStatement(query);
            return success;
        }
        public List<RentalProperty> getAllRentalProperties()
        {
            List<RentalProperty> properties = new List<RentalProperty>();
            string query = "SELECT * FROM RentalProperty ORDER BY location ASC, price ASC";
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            foreach(DataRow row in dataTable.Rows)
            {
                RentalProperty rp = new RentalProperty(int.Parse(row["rentalId"].ToString()), row["location"].ToString(), float.Parse(row["price"].ToString()), row["type"].ToString(), int.Parse(row["rooms"].ToString()));
                Console.WriteLine(rp);
                properties.Add(rp);
            }
            return properties;
        }
        public DataTable getAllRentalPropertiesTable()
        {
            List<RentalProperty> properties = new List<RentalProperty>();
            string query = "SELECT * FROM RentalProperty ORDER BY location ASC, price ASC";
            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            return dataTable;
        }
        public List<RentalProperty> filterRentalProperties(Dictionary<string, List<String>> dictionary)
        {
            List<RentalProperty> properties = new List<RentalProperty>();
            string query = filterQueryBuilder(dictionary);

            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            foreach (DataRow row in dataTable.Rows)
            {
                RentalProperty rp = new RentalProperty(int.Parse(row["rentalId"].ToString()), row["location"].ToString(), float.Parse(row["price"].ToString()), row["type"].ToString(), int.Parse(row["rooms"].ToString()));
                Console.WriteLine(rp);
                properties.Add(rp);
            }
            return properties;
        }
        public DataTable filterRentalPropertiesDataTable(Dictionary<string, List<String>> dictionary)
        {
            List<RentalProperty> properties = new List<RentalProperty>();
            string query = filterQueryBuilder(dictionary);

            DataTable dataTable = repository.queryStatement(query);
            if (dataTable == null)
                return null;
            
            return dataTable;
        }
        public string filterQueryBuilder(Dictionary<string, List<String>> dictionary)
        {
            string query = "SELECT * FROM RentalProperty WHERE ";
            int length = dictionary.Count;
            int current = 0;
            foreach (KeyValuePair<string, List<String>> kvp in dictionary)
            {
                //Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                if(!kvp.Key.Equals("price"))
                {
                    query = query + kvp.Key + " IN (";

                    bool isInteger = false;
                    try
                    {
                        int p = int.Parse(kvp.Value.ElementAt(0));
                        isInteger = true;
                    }
                    catch (Exception e)
                    {
                        isInteger = false;
                        Console.WriteLine("Is not integer");
                    }

                    for (int i = 0; i < kvp.Value.Count; i++)
                    {
                        if (!isInteger)
                            query = query + "\"" + kvp.Value.ElementAt(i) + "\"";
                        else
                            query = query + kvp.Value.ElementAt(i);
                        if (i != kvp.Value.Count - 1)
                        {
                            query = query + ", ";
                        }
                    }
                    query = query + ")";
                    if (current != length - 1)
                    {
                        query = query + " AND ";
                    }
                    current++;
                }
                else
                {
                    int minValue=0, maxValue=int.MaxValue;
                    string a = kvp.Value.ElementAt(0).ToString();
                    string b = kvp.Value.ElementAt(1).ToString();
                    try
                    {
                        if (a != null)
                            minValue = int.Parse(a.Substring(1));
                        if (b != null)
                            maxValue = int.Parse(b.Substring(1));
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        minValue = 0;
                        maxValue = int.MaxValue;
                    }


                    query = query + " price > " + minValue.ToString() + " AND price < " + maxValue.ToString();

                    if(current != length - 1)
                    {
                        query = query + " AND ";
                    }

                    current++;
                    

                }
                
            }

            Console.WriteLine(query);
            return query;
        }
        public Dictionary<string, List<String>> getCategories()
        {
            Dictionary<string,List<String>> categories = new Dictionary<string,List<String>>();

            List<String> categoryNames = new List<String>() {"location", "type", "rooms" };


            foreach(String key in categoryNames)
            {
                string query = "SELECT DISTINCT " + key + " FROM RentalProperty";
                DataTable dt = repository.queryStatement(query);
                if (dt == null) return null;
                List<String> temp = new List<String>();
                foreach (DataRow row in dt.Rows)
                {
                    temp.Add(row[key].ToString());
                }
                categories.Add(key, temp);
            }

            foreach (KeyValuePair<string, List<String>> kvp in categories)
            {
                Console.WriteLine(kvp.Key);
                foreach(String t in kvp.Value)
                {
                    Console.Write("{0}, ", t);
                }
                Console.Write("\n");
            }


            return categories;
        }
    }
}
