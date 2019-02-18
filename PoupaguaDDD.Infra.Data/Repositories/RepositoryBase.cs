using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace PoupaguaDDD.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryRead<TEntity>, IRepositoryWrite<TEntity> where TEntity : EntityBase, new()
    {
        protected PoupaguaContext Db;
        protected DbSet<TEntity> DbSet;

        public RepositoryBase(PoupaguaContext poupaguaContext)
        {
            Db = poupaguaContext;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public virtual void Remover(string id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterTodosAsNoTracking()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual TEntity ObterPorId(string id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> ObterEnquanto(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual IEnumerable<TEntity> ObterTodosPaginado(int s, int t)
        {
            return DbSet.Take(t).Skip(s);
        }

        public int SalvarMudancas()
        {
            return Db.SaveChanges();
        }   
        
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }        
    }
}
