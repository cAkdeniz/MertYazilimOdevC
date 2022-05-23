using MertYazilim.Business.Abstract;
using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ApiManager _apiManager;
        public CategoryController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var categories = _apiManager.GetAllAsync<Category>().Result;
            return View(categories);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Category>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            await _apiManager.AddAsync<Category>(category);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var category = _apiManager.GetAsync<Category>(id).Result;
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            await _apiManager.UpdateAsync<Category>(category, category.Id);
            return RedirectToAction("Index");
        }
    }
}
