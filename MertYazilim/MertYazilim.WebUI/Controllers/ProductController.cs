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
    public class ProductController : Controller
    {
        private ApiManager _apiManager;
        public ProductController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var products = _apiManager.GetAllAsync<Product>().Result;
            return View(products);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Product>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        { 
            var categories = _apiManager.GetAllAsync<Category>().Result;
            var suppliers = _apiManager.GetAllAsync<Supplier>().Result;
            ViewBag.Supplier = new SelectList(suppliers, "Id", "CompanyName");
            ViewBag.Category = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await _apiManager.AddAsync<Product>(product);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var categories = _apiManager.GetAllAsync<Category>().Result;
            var suppliers = _apiManager.GetAllAsync<Supplier>().Result;
            ViewBag.Supplier = new SelectList(suppliers, "Id", "CompanyName");
            ViewBag.Category = new SelectList(categories, "Id", "Name");
            var product = _apiManager.GetAsync<Product>(id).Result;
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            await _apiManager.UpdateAsync<Product>(product, product.Id);
            return RedirectToAction("Index");
        }
    }
}
