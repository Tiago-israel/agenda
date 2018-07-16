using Domain.Models;
using Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces
{
    public interface IErrorLogRepository : IBaseRepository<ErrorLog>
    {
    }
}
