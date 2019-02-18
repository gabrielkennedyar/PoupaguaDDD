namespace PoupaguaDDD.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void BeginTransaction();
        void RollBack();
        bool SaveChanges();
    }
}
