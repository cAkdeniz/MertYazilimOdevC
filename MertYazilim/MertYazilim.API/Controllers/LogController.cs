using MertYazilim.Business.Abstract;
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
    public class LogController : ControllerBase
    {
        private ILogService _logService;
        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var logs = _logService.GetAll();
            return Ok(logs);
        }
    }
}
