using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using System.Configuration;
//using System.Configuration.Assemblies;

namespace PresentationWebApp
{
    public class PL
    {
        private BLL busLogic;
        private List<string> customerCompanyNames;
        private int customerCount;
        //private string connection;

        private string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"; //KNOWN GOOD CONFIGURATION
        //connection = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        public PL()
        {
            busLogic = new BLL(connection);
            customerCompanyNames = busLogic.getAllCustomerCompanyNames();
            customerCount = busLogic.getNumberOfCustomers();
        }
        
        public List<string> CompanyNames()
        {
            return customerCompanyNames;
        }

        public int Count()
        {
            return customerCount;
        }
    }
}
