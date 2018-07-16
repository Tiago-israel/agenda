using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.Intefaces
{
    public interface IBaseAppService<T>
    {
        T Salvar(T viewModel);
        T Atualizar(Guid id,T viewModel);
        void Excluir(Guid id);
        T BuscarPorId(Guid id);
        IEnumerable<T> BuscarTodos();
    }
}
