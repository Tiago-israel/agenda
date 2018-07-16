using Domain.Models;
using Infra.DataContext;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories
{
    public class ErrorLogRepository : BaseRepository<ErrorLog>, IErrorLogRepository
    {
        public ErrorLogRepository(AgendaContext agendaContext) : base(agendaContext)
        {

        }
    }
}
