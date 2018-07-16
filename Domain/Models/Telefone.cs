using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Telefone
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Guid IdContato { get; set; }
        public virtual Contato Contato { get; set; }
    }
}
