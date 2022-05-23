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
    public class ShipperController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public ShipperController(ILogService logService)
        {
            _northwindApiManager = new NorthwindApiManager("shippers");
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Shipper/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var shippers = await _northwindApiManager.GetAllAsync<Shipper>();
            return Ok(shippers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Shipper/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var shipper = await _northwindApiManager.GetAsync<Shipper>(id);
            return Ok(shipper);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Shipper shipper)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Shipper/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Shipper>(shipper);
            return Ok(shipper);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Shipper/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Shipper>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Shipper shipper, int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Shipper/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Shipper>(shipper, id);
            return NoContent();
        }
    }
}
