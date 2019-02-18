using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PontoDeConsumoService : IPontoDeConsumoService
    {
        private readonly IPontoDeConsumoRepository _pontoDeConsumoRepository;

        public PontoDeConsumoService(IPontoDeConsumoRepository pontoDeConsumoRepository)
        {
            _pontoDeConsumoRepository = pontoDeConsumoRepository;
        }

        public void Dispose()
        {
            _pontoDeConsumoRepository.Dispose();
        }
    }
}
