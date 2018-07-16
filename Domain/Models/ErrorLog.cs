using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ErrorLog
    {
        public Guid Id { get; set; }
        public string Erro { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
