using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class UnidadeConsumidoraAppService : AppServiceBase<UnidadeConsumidora>, IUnidadeConsumidoraAppService
    {
        private readonly IUnidadeConsumidoraService _unidadeConsumidoraService;

        public UnidadeConsumidoraAppService(IUnidadeConsumidoraService unidadeConsumidoraService) : base(unidadeConsumidoraService)
        {
            _unidadeConsumidoraService = unidadeConsumidoraService;
        }
    }
}
