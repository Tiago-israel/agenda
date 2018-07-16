using Infra.DataContext;
using Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Repositories.Interfaces;

namespace Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AgendaContext _agendaContext;

        public BaseRepository(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }

        public T Atualizar(Guid id, T entity)
        {
            _agendaContext.Update<T>(entity);
            _agendaContext.SaveChanges();
            return entity;

        }

        public T BuscarPorId(Guid id)
        {
            return _agendaContext.Find<T>(id);
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _agendaContext.Set<T>();
        }

        public void Excluir(Guid id)
        {
            var entityDb = this.BuscarPorId(id);
            if(entityDb != null)
            {
                _agendaContext.Remove<T>(entityDb);
                _agendaContext.SaveChanges();
            }
        }

        public T Salvar(T entity)
        {
            _agendaContext.Add<T>(entity);
            _agendaContext.SaveChanges();
            return entity;
        }
    }
}
