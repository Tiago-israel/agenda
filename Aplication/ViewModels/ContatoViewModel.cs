using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.ViewModels
{
    public class ContatoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public virtual IEnumerable<TelefoneViewModel> Telefones { get; set; }
    }
}
