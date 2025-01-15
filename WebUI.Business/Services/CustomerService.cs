using System.Threading.Tasks;
using WebUI.Business.WCFService;

namespace WebUI.Business.Services
{
    public class CustomerService
    {
        ServiceClient _wcfService = new ServiceClient();
        public CustomerService()
        {
            //_wcfService = new WCFService.ServiceClient();
        }

        public async Task<WCFService.CustomerResponse[]> GetCustomersByCountryAsync(string country)
        { 
            return await _wcfService.GetCustomersByCountryAsync(country);
        }

        public async Task<WCFService.OrderResponse[]> CustomerOrdersInformationAsync(string customerId)
        {
            return await _wcfService.CustomerOrdersInformationAsync(customerId);
        }
    }
}
