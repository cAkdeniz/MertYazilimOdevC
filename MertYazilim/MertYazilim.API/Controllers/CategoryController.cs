using MertYazilim.API.ApiService.Concrete;
using MertYazilim.Business.Abstract;
using MertYazilim.Business.StringInfos.LogInfo;
using MertYazilim.Entities.Concrete;
using MertYazilim.Entities.Concrete.Log;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertYazilim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public CategoryController(ILogService logService)
        {
            _logService = logService;
            _northwindApiManager = new NorthwindApiManager("categories");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/category/GetAll",
                Query = ""
            };
            _logService.Add(log);

            var categories = await _northwindApiManager.GetAllAsync<Category>();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/category/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var category = await _northwindApiManager.GetAsync<Category>(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/category/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Category>(category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/category/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Category>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Category category,int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/category/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Category>(category, id);
            return NoContent();
        }
    }
}
