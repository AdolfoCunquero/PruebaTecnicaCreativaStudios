using System;
using System.Web.Mvc;
using WebUI.Business.Services;

namespace WebUI.ActionAttribute
{
    public class WebTracker : ActionFilterAttribute
    {
        private readonly WebTrackerService _webTrackerService;
        public WebTracker()
        {
            _webTrackerService = new WebTrackerService();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string clientIp = filterContext.HttpContext.Request.UserHostAddress;
                string urlRequest = filterContext.HttpContext.Request.Url?.AbsoluteUri;
                _webTrackerService.AddWebTracker(clientIp, urlRequest);
            }
            catch (Exception) { }
        }
    }
}