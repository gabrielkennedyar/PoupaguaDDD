using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class PontoDeConsumoAppService : AppServiceBase<PontoDeConsumo>, IPontoDeConsumoAppService
    {
        private readonly IPontoDeConsumoService _pontoDeConsumoService;

        public PontoDeConsumoAppService(IPontoDeConsumoService pontoDeConsumoService) : base(pontoDeConsumoService)
        {
            _pontoDeConsumoService = pontoDeConsumoService;
        }
    }
}
