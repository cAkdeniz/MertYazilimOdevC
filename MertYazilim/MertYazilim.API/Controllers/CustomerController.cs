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
    public class CustomerController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public CustomerController(ILogService logService)
        {
            _logService = logService;
            _northwindApiManager = new NorthwindApiManager("customers");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Customer/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var customers = await _northwindApiManager.GetAllAsync<Customer>();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Customer/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var customer = await _northwindApiManager.GetAsync<Customer>(id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Customer/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Customer>(customer);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Customer/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Customer>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Customer customer, string id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Customer/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Customer>(customer, id);
            return NoContent();
        }
    }
}
