using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class SupplierController : Controller
    {
        private ApiManager _apiManager;
        public SupplierController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var suppliers = _apiManager.GetAllAsync<Supplier>().Result;
            return View(suppliers);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Supplier>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Supplier supplier)
        {
            await _apiManager.AddAsync<Supplier>(supplier);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var supplier = _apiManager.GetAsync<Supplier>(id).Result;
            return View(supplier);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Supplier supplier)
        {
            await _apiManager.UpdateAsync<Supplier>(supplier, supplier.Id);
            return RedirectToAction("Index");
        }
    }
}
