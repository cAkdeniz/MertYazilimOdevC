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
    public class SupplierController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public SupplierController(ILogService logService)
        {
            _northwindApiManager = new NorthwindApiManager("suppliers");
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Supplier/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var suppliers = await _northwindApiManager.GetAllAsync<Supplier>();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Supplier/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var supplier = await _northwindApiManager.GetAsync<Supplier>(id);
            return Ok(supplier);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Supplier supplier)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Supplier/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Supplier>(supplier);
            return Ok(supplier);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Supplier/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Supplier>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Supplier supplier, int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Supplier/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Supplier>(supplier, id);
            return NoContent();
        }
    }
}
