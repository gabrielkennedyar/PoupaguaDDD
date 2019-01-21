using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class TarifaAppService : AppServiceBase<Tarifa>, ITarifaAppService
    {
        private readonly ITarifaService _tarifaService;

        public TarifaAppService(ITarifaService tarifaService) : base(tarifaService)
        {
            _tarifaService = tarifaService;
        }

        public float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros)
        {
            return _tarifaService.CalcularTarifa(tarifaParaCalculo, mediaDeLitros);
        }
    }
}
