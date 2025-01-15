using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WCF.Business.Services
{
    public class CustomerService
    {
        public async Task<List<CustomerResponse>> GetCustomersByCountryAsync(string country)
        {
            using (var context = new AppDbContext())
            {
                return await context.Customers
                    .Where(c => c.Country.StartsWith(country))
                    .OrderBy(x => x.ContactName)
                    .Select(x => new CustomerResponse
                    {
                        CustomerID = x.CustomerID,
                        CompanyName = x.CompanyName,
                        ContactName = x.ContactName,
                        Phone = x.Phone,
                        Fax = x.Fax
                    }).ToListAsync();
            }
        }
        public async Task<List<OrderResponse>> CustomerOrdersInformationAsync(string customerId)
        {
            using (var context = new AppDbContext())
            {
                return await context.Orders
                    .Where(x => x.CustomerID == customerId)
                    .OrderBy(x => x.ShippedDate)
                    .Select(x => new OrderResponse
                    {
                        OrderID = x.OrderID,
                        CustomerID = x.CustomerID,
                        OrderDate = x.OrderDate,
                        ShippedDate = x.ShippedDate
                    }).ToListAsync();
            }
        }
    }
}
