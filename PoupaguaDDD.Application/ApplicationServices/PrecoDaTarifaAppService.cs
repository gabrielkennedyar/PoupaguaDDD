using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class PrecoDaTarifaAppService : AppServiceBase<PrecoDaTarifa>, IPrecoDaTarifaAppService
    {
        private readonly IPrecoDaTarifaService _precoDaTarifaService;

        public PrecoDaTarifaAppService(IPrecoDaTarifaService precoDaTarifaService) : base(precoDaTarifaService)
        {
            _precoDaTarifaService = precoDaTarifaService;
        }

        public float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros)
        {
            return _precoDaTarifaService.CalcularPreco(precoDaTarifaParaCalculo, mediaDeLitros);
        }
    }
}
