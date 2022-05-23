using MertYazilim.Entities.Concrete;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private ApiManager _apiManager;
        public EmployeeController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var employess = _apiManager.GetAllAsync<Employee>().Result;
            return View(employess);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiManager.DeleteAsync<Employee>(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            await _apiManager.AddAsync<Employee>(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var employee = _apiManager.GetAsync<Employee>(id).Result;
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee employee)
        {
            await _apiManager.UpdateAsync<Employee>(employee, employee.Id);
            return RedirectToAction("Index");
        }
    }
}
