using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/ErrorLog")]
    public class ErrorLogController : Controller
    {
        private readonly IErrorLogAppService _errorLogAppService;

        public ErrorLogController(IErrorLogAppService errorLogAppService)
        {
            _errorLogAppService = errorLogAppService;
        }

        [HttpPost]
        public IActionResult GravarLog([FromBody]ErrorLog errorLog)
        {
            try
            {
                _errorLogAppService.GravarLog(errorLog);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}