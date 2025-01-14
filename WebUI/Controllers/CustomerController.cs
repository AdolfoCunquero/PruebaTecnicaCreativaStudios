using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.ActionAttribute;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly WCFService.ServiceClient _wcfService;
        public CustomerController()
        {
            _wcfService = new WCFService.ServiceClient();
        }

        [WebTracker]
        public async Task<ActionResult> Index(string country)
        {
            try
            {
                var customers = await _wcfService.GetCustomersByCountryAsync(country);
                ViewBag.Customers = customers;
                ViewBag.Search = country;
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
        }

        [WebTracker]
        public async Task<ActionResult> CustomerOrdersInformation(string id)
        {
            try
            {
                var orders = await _wcfService.CustomerOrdersInformationAsync(id);
                ViewBag.Orders = orders;
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
        }
    }
}