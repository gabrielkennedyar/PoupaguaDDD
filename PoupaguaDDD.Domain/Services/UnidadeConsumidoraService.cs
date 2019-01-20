using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class UnidadeConsumidoraService : ServiceBase<UnidadeConsumidora>, IUnidadeConsumidoraService
    {
        private readonly IUnidadeConsumidoraRepository _unidadeConsumidoraRepository;

        public UnidadeConsumidoraService(IUnidadeConsumidoraRepository unidadeConsumidoraRepository) : base(unidadeConsumidoraRepository)
        {
            _unidadeConsumidoraRepository = unidadeConsumidoraRepository;
        }
    }
}
