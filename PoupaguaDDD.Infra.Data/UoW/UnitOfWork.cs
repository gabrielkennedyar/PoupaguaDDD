using PoupaguaDDD.Domain.Interfaces;
using PoupaguaDDD.Infra.Data.Context;

namespace PoupaguaDDD.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PoupaguaContext _poupaguaContext;

        public UnitOfWork(PoupaguaContext poupaguaContext)
        {
            _poupaguaContext = poupaguaContext;
        }

        public void BeginTransaction()
        {
            _poupaguaContext.Database.BeginTransaction();
        }

        public void RollBack()
        {
            _poupaguaContext.Database.CurrentTransaction.Rollback();
        }

        public void Commit()
        {
            _poupaguaContext.Database.CurrentTransaction.Commit();
        }

        public bool SaveChanges()
        {
            return _poupaguaContext.SaveChanges() > 0;
        }
    }
}
