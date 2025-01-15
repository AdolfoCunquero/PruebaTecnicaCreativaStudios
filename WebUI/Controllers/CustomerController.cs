using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.ActionAttribute;
using WebUI.Business.Services;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        [WebTracker]
        public async Task<ActionResult> Index(string country)
        {
            try
            {
                var customers = await _customerService.GetCustomersByCountryAsync(country);
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
                var orders = await _customerService.CustomerOrdersInformationAsync(id);
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