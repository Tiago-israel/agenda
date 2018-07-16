using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Interfaces
{
    public interface IErrorLogAppService
    {
        void GravarLog(ErrorLog errorLog);
    }
}
