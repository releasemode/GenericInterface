using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICustomer _customer;

        public IndexModel(ILogger<IndexModel> logger, ICustomer customer)
        {
            _logger = logger;
            _customer = customer;   
        }

        public void OnGet()
        {
            _customer.CallCustomerA();
            _customer.CallCustomerB();
        }
    }
}