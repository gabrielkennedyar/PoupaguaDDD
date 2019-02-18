using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PoupaguaDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryRead<TEntity> : IDisposable where TEntity : EntityBase
    {        
        TEntity ObterPorId(string id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterTodosAsNoTracking();
        IEnumerable<TEntity> ObterTodosPaginado(int s, int t);
        IEnumerable<TEntity> ObterEnquanto(Expression<Func<TEntity, bool>> predicate);                  
    }
}
