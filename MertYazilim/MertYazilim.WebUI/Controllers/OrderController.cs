using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private ApiManager _apiManager;
        public OrderController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var orders = _apiManager.GetAllAsync<Order>().Result;
            return View(orders);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Order>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            var customers = _apiManager.GetAllAsync<Customer>().Result;
            var employess = _apiManager.GetAllAsync<Employee>().Result;
            ViewBag.Customer = new SelectList(customers, "Id", "CompanyName");
            ViewBag.Employee = new SelectList(employess, "Id", "FirstName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Order order)
        {
            await _apiManager.AddAsync<Order>(order);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var customer = _apiManager.GetAllAsync<Customer>().Result;
            var employee = _apiManager.GetAllAsync<Employee>().Result;
            ViewBag.Customer = new SelectList(customer, "Id", "CompanyName");
            ViewBag.Employee = new SelectList(employee, "Id", "FirstName");
            var order = _apiManager.GetAsync<Order>(id).Result;
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Order order)
        { 
            await _apiManager.UpdateAsync<Order>(order, order.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var order = _apiManager.GetAsync<Order>(id).Result;
            
            List<OrderDetail> details = new List<OrderDetail>();

            foreach (var item in order.Details)
            {
                OrderDetail detail = new OrderDetail();
                detail.ProductId = item.ProductId;
                detail.UnitPrice = item.UnitPrice;
                detail.Quantity = item.Quantity;
                detail.Discount = item.Discount;

                details.Add(detail);
            }

            return View(details);
        }
    }
}
