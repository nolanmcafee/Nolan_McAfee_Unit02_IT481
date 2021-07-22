using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccess;
using System.Data;
using CustomerObject;

namespace BusinessLogic
{
    public class BLL
    {
        //string connection = ConfigurationManager.ConnectionStrings["Northwind"].ToString();
        //string connection = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        //static string connection = "Data Source=DESKTOP-EKHOH1V\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        //static string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"; //KNOWN GOOD CONFIGURATION
        //static string connection;
        private DAL dataCustomers;
        private List<CO> allData;
        private List<string> nameData;

        public BLL(string connection)
        {
            dataCustomers = new DAL(connection);
            allData = dataCustomers.getAllData();
        }

        public List<string> getAllCustomerCompanyNames()
        {
            nameData = new List<string>();

            foreach (CO customer in allData)
            {

                nameData.Add(customer.CompanyName);
            }

            return nameData;
        }

        public int getNumberOfCustomers()
        {
            return allData.Count;
        }
        

        //List<DAL> custlist = new List<DAL>();

        //ICollection<string> customers = new System.Collections.Generic.ICollection();
        
    }
}
