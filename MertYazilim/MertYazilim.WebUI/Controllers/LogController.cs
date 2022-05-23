using MertYazilim.Entities.Concrete.Log;
using MertYazilim.WebUI.ApiService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.WebUI.Controllers
{
    public class LogController : Controller
    {
        private ApiManager _apiManager;
        public LogController(ApiManager apiManager)
        {
            _apiManager = apiManager;
        }

        public IActionResult Index()
        {
            var logs = _apiManager.GetAllAsync<Log>().Result;
            return View(logs);
        }
    }
}
