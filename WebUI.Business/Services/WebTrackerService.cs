
using System;

namespace WebUI.Business.Services
{
    public class WebTrackerService
    {
        private readonly WCFService.ServiceClient _wcfService;
        public WebTrackerService()
        {
            _wcfService = new WCFService.ServiceClient();
        }

        public void AddWebTracker(string clientIp, string urlRequest)
        {
            _wcfService.AddWebTracker(new WCFService.WebTrackerRequest { SourceIp = clientIp, TimeOfAction = DateTime.Now, URLRequest = urlRequest });
        }
    }
}
