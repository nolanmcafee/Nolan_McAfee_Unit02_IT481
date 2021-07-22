using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PresentationWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<string> customerCompanyNames;
        public int customerCount;

        public string btnClk;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            PL customers = new PL();
            customerCompanyNames = customers.CompanyNames();
            customerCount = customers.Count();
            /*foreach (string customer in customers.CompanyNames())
            {
                //table1.Rows.Add(customer);
                Console.WriteLine(customer);
            }*/
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            
        }

        public void formactions()
        {

        }
        public void btnClick()
        {
            PL customers = new PL();
            customerCompanyNames = customers.CompanyNames();
            foreach (string customer in customers.CompanyNames())
            {
                //table1.Rows.Add(customer);
                Console.WriteLine(customer);
            }
        }

        /*public async Task OnGetAsync(string btnClk)
        {

        }*/
        
    }
}
