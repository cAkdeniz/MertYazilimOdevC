using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class ShipperController : Controller
    {
        private ApiManager _apiManager;
        public ShipperController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var shippers = _apiManager.GetAllAsync<Shipper>().Result;
            return View(shippers);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Shipper>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Shipper shipper)
        {
            await _apiManager.AddAsync<Shipper>(shipper);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var shipper = _apiManager.GetAsync<Shipper>(id).Result;
            return View(shipper);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Shipper shipper)
        {
            await _apiManager.UpdateAsync<Shipper>(shipper, shipper.Id);
            return RedirectToAction("Index");
        }
    }
}
