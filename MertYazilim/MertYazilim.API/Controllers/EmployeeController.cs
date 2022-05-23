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
    public class EmployeeController : ControllerBase
    {
        private NorthwindApiManager _northwindApiManager;
        private ILogService _logService;
        public EmployeeController(ILogService logService)
        {
            _northwindApiManager = new NorthwindApiManager("employess");
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Employee/GetAll",
                Query = $""
            };
            _logService.Add(log);

            var employess = await _northwindApiManager.GetAllAsync<Employee>();
            return Ok(employess);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Get,
                Path = "/Employee/GetById",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            var employee = await _northwindApiManager.GetAsync<Employee>(id);
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Post,
                Path = "/Employee/Add",
                Query = $""
            };
            _logService.Add(log);

            await _northwindApiManager.AddAsync<Employee>(employee);
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Delete,
                Path = "/Employee/Delete",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.DeleteAsync<Employee>(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Employee employee, int id)
        {
            Log log = new Log
            {
                Method = LogMethodInfo.Put,
                Path = "/Employee/Update",
                Query = $"/?id={id}"
            };
            _logService.Add(log);

            await _northwindApiManager.UpdateAsync<Employee>(employee, id);
            return NoContent();
        }
    }
}
