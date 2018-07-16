using Aplication.Interfaces;
using Domain.Models;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication
{
    public class ErrorLogAppService : IErrorLogAppService
    {
        private readonly IErrorLogRepository _errorLogRepository;

        public ErrorLogAppService(IErrorLogRepository errorLogRepository) {
            _errorLogRepository = errorLogRepository;
        }

        public void GravarLog(ErrorLog errorLog)
        {
            _errorLogRepository.Salvar(errorLog);
        }
    }
}
