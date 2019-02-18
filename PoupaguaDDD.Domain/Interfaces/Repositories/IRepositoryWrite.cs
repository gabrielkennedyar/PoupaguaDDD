using PoupaguaDDD.Domain.Entities;
using System;

namespace PoupaguaDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : EntityBase
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remover(string id);
        int SalvarMudancas();
    }
}
