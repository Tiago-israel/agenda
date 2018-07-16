
using Api.Repositories.Interfaces;
using Aplication.Intefaces;
using Aplication.ViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class TelefoneAppService : ITelefoneAppService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneAppService(ITelefoneRepository telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public TelefoneViewModel Atualizar(Guid id, TelefoneViewModel viewModel)
        {
            var telefone = Mapper.Map<Telefone>(viewModel);
            var telefoneVm = Mapper.Map<TelefoneViewModel>(_telefoneRepository.Atualizar(id, telefone));
            return telefoneVm;
        }

        public TelefoneViewModel BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TelefoneViewModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            _telefoneRepository.Excluir(id);
        }

        public TelefoneViewModel Salvar(TelefoneViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
