using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class UnidadeConsumidoraService : IUnidadeConsumidoraService
    {
        private readonly IUnidadeConsumidoraRepository _unidadeConsumidoraRepository;

        public UnidadeConsumidoraService(IUnidadeConsumidoraRepository unidadeConsumidoraRepository)
        {
            _unidadeConsumidoraRepository = unidadeConsumidoraRepository;
        }

        public void Dispose()
        {
            _unidadeConsumidoraRepository.Dispose();
        }
    }
}
