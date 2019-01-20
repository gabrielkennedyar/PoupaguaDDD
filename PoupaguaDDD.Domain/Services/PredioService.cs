using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PredioService : ServiceBase<Predio>, IPredioService
    {
        private readonly IPredioRepository _predioRepository;

        public PredioService(IPredioRepository predioRepository) : base(predioRepository)
        {
            _predioRepository = predioRepository;
        }
    }
}
