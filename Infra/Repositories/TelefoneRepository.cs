using Infra.DataContext;
using Domain.Models;
using Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class TelefoneRepository : BaseRepository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(AgendaContext agendaContext) : base(agendaContext)
        {
        }
    }
}
