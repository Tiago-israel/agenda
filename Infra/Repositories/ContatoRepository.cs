using Infra.DataContext;
using Domain.Models;
using Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Repositories.Interfaces;

namespace Infra.Repositories
{
    public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
    {
        
        public ContatoRepository(AgendaContext agendaContext) : base(agendaContext)
        {
            
        }

        public Contato BuscarContatoComInclude(Guid id)
        {
            var contato = _agendaContext.Contatos
                .Include(x => x.Telefones)
                .FirstOrDefault(x => x.Id == id);
            return contato;
        }

        public IEnumerable<Contato> BuscarContatosComInclude() {
            var contatos = _agendaContext.Contatos.Include(x => x.Telefones).ToList();
            return contatos;
        }

    }
}
