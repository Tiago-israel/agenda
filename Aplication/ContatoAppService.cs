
using Aplication.Intefaces;
using Aplication.ViewModels;
using AutoMapper;
using Domain.Models;
using Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoAppService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public ContatoViewModel Atualizar(Guid id, ContatoViewModel viewModel)
        {
            var contato = Mapper.Map<Contato>(viewModel);
            var contatoVm = Mapper.Map<ContatoViewModel>(_contatoRepository.Atualizar(id, contato));
            return contatoVm;
        }

        public ContatoViewModel BuscarPorId(Guid id)
        {
            var contato = _contatoRepository.BuscarContatoComInclude(id);
            return Mapper.Map<ContatoViewModel>(contato);
        }

        public IEnumerable<ContatoViewModel> BuscarTodos()
        {
            var contatos = _contatoRepository.BuscarContatosComInclude();
            return Mapper.Map<IEnumerable<ContatoViewModel>>(contatos);
        }

        public void Excluir(Guid id)
        {
            _contatoRepository.Excluir(id);
        }

        public ContatoViewModel Salvar(ContatoViewModel viewModel)
        {
            var contato = Mapper.Map<Contato>(viewModel);
            var contatoVm = Mapper.Map<ContatoViewModel> (_contatoRepository.Salvar(contato));
            return contatoVm;
        }
    }
}
