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
    public class ProductController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public ProductController(ILogService logService)
        {
            _northwindApiManager = new NorthwindApiManager("products");
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Product/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var product = await _northwindApiManager.GetAllAsync<Product>();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Product/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var products = await _northwindApiManager.GetAsync<Product>(id);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Product/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Product>(product);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Product/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Product>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Product product, int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Product/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Product>(product, id);
            return NoContent();
        }
    }
}
