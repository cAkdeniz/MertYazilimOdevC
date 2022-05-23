using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ApiManager _apiManager;
        public CustomerController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var customers = _apiManager.GetAllAsync<Customer>().Result;
            return View(customers);
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _apiManager.DeleteAsync<Customer>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            await _apiManager.AddAsync<Customer>(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Update(string id)
        {
            var customer = _apiManager.GetAsync<Customer>(id).Result;
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer customer)
        {
            await _apiManager.UpdateAsync<Customer>(customer, customer.Id);
            return RedirectToAction("Index");
        }
    }
}
