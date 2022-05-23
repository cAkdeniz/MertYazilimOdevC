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
    public class OrderController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public OrderController(ILogService logService)
        {
            _northwindApiManager = new NorthwindApiManager("orders");
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Order/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var orders = await _northwindApiManager.GetAllAsync<Order>();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Order/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var order = await _northwindApiManager.GetAsync<Order>(id);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Order order)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Order/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Order>(order);
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Order/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Order>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Order order, int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Order/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Order>(order, id);
            return NoContent();
        }
    }
}
