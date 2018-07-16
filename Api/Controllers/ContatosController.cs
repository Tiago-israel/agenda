using System;
using Aplication.Intefaces;
using Aplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Contatos")]
    public class ContatosController : Controller
    {
        private readonly IContatoAppService _contatoAppService;

        public ContatosController(IContatoAppService contatoAppService)
        {
            _contatoAppService = contatoAppService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var contatos = _contatoAppService.BuscarTodos();
            return Ok(contatos);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            var contato = _contatoAppService.BuscarPorId(id);
            return Ok(contato);
        }

        [HttpPost]
        public IActionResult Salvar([FromBody]ContatoViewModel contato)
        {
            var contatoVm = _contatoAppService.Salvar(contato);
            return Ok(contatoVm);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody]ContatoViewModel contato)
        {
            var contatoVm = _contatoAppService.Atualizar(id, contato);
            return Ok(contatoVm);
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(Guid id)
        {
            _contatoAppService.Excluir(id);
            return Ok();
        }
    }
}