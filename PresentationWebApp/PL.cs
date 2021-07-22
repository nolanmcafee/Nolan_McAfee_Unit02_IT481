using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;

namespace PresentationWebApp
{
    public class PL
    {
        private BLL busLogic;
        private List<string> customerCompanyNames;
        private int customerCount;
        
        public PL()
        {
            busLogic = new BLL();
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
