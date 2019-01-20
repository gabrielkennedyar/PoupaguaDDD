using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PontoDeConsumoService : ServiceBase<PontoDeConsumo>, IPontoDeConsumoService
    {
        private readonly IPontoDeConsumoRepository _pontoDeConsumoRepository;

        public PontoDeConsumoService(IPontoDeConsumoRepository pontoDeConsumoRepository) : base(pontoDeConsumoRepository)
        {
            _pontoDeConsumoRepository = pontoDeConsumoRepository;
        }
    }
}
