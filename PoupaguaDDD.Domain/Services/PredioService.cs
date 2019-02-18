using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PredioService : IPredioService
    {
        private readonly IPredioRepository _predioRepository;

        public PredioService(IPredioRepository predioRepository)
        {
            _predioRepository = predioRepository;
        }

        public void Dispose()
        {
            _predioRepository.Dispose();
        }
    }
}
