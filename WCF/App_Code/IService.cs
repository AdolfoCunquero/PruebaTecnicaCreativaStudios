using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	Task<List<CustomerResponse>> GetCustomersByCountryAsync(string country);

	[OperationContract]
	Task<List<OrderResponse>> CustomerOrdersInformationAsync(string customerId);

	[OperationContract]
	Task AddWebTrackerAsync(WebTrackerRequest request);
}

