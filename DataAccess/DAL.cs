using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CustomerObject;
using System.Dynamic;
using System.Xml.Linq;
using System.Xml;

namespace DataAccess
{
    public class DAL
    {
        private string connectionString;


        public DAL (string CxnString)
        {
            connectionString = CxnString;
        }

        public List<CO> getAllData()
        {
            string queryString = "select * from Customers;";
            List<CO> customers = new List<CO>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string customerID   = reader.IsDBNull(0)    ? string.Empty : reader.GetString(0);
                    string companyName  = reader.IsDBNull(1)    ? string.Empty : reader.GetString(1);
                    string contactName  = reader.IsDBNull(2)    ? string.Empty : reader.GetString(2);
                    string contactTitle = reader.IsDBNull(3)    ? string.Empty : reader.GetString(3);
                    string address      = reader.IsDBNull(4)    ? string.Empty : reader.GetString(4);
                    string city         = reader.IsDBNull(5)    ? string.Empty : reader.GetString(5);
                    string region       = reader.IsDBNull(6)    ? string.Empty : reader.GetString(6);
                    string postalCode   = reader.IsDBNull(7)    ? string.Empty : reader.GetString(7);
                    string country      = reader.IsDBNull(8)    ? string.Empty : reader.GetString(8);
                    string phone        = reader.IsDBNull(9)    ? string.Empty : reader.GetString(9);
                    string fax          = reader.IsDBNull(10)   ? string.Empty : reader.GetString(10);

                    CO customer = new CO(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);

                    customers.Add(customer);
                }
                reader.Close();
                connection.Close();
            }

            return customers;
        }
    }
}
