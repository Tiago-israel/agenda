using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Intefaces;
using Aplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Telefones")]
    public class TelefonesController : Controller
    {
        private readonly ITelefoneAppService _telefoneAppService;

        public TelefonesController(ITelefoneAppService telefoneAppService)
        {
            _telefoneAppService = telefoneAppService;
        }


        // GET: api/Telefones/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/Telefones/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]TelefoneViewModel telefone)
        {
            _telefoneAppService.Atualizar(id, telefone);
            return Ok();
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _telefoneAppService.Excluir(id);
            return Ok();
        }
    }
}
