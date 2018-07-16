using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Salvar(T entity);
        T Atualizar(Guid id, T entity);
        T BuscarPorId(Guid id);
        IEnumerable<T> BuscarTodos();
        void Excluir(Guid id);
    }
}
