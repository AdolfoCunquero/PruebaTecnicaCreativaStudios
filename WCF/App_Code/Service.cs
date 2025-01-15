using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WCF.Business.Services;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private readonly WebTrackerService _webTrackerService;
    private readonly CustomerService _customerService;
    public Service()
    { 
        _customerService = new CustomerService();
        _webTrackerService = new WebTrackerService();
    }
    public async Task<List<CustomerResponse>> GetCustomersByCountryAsync(string country)
    {
        return await _customerService.GetCustomersByCountryAsync(country);
    }

    public async Task<List<OrderResponse>> CustomerOrdersInformationAsync(string customerId)
    {
        return await _customerService.CustomerOrdersInformationAsync(customerId);
    }

    public async Task AddWebTrackerAsync(WebTrackerRequest request)
    {
        await _webTrackerService.AddWebTrackerAsync(request);
    }
}
