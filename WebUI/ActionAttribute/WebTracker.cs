using System;
using System.Web.Mvc;

namespace WebUI.ActionAttribute
{
    public class WebTracker : ActionFilterAttribute
    {
        private readonly WCFService.ServiceClient _wcfService;
        public WebTracker()
        {
            _wcfService = new WCFService.ServiceClient();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string clientIp = filterContext.HttpContext.Request.UserHostAddress;
                string urlRequest = filterContext.HttpContext.Request.Url?.AbsoluteUri;
                _wcfService.AddWebTracker(new WCFService.WebTrackerRequest { SourceIp = clientIp, TimeOfAction = DateTime.Now, URLRequest = urlRequest });
            }
            catch (Exception) { }
        }
    }
}