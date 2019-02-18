using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class EnderecoCompletoService : IEnderecoCompletoService
    {
        private readonly IEnderecoCompletoRepository _enderecoCompletoRepository;

        public EnderecoCompletoService(IEnderecoCompletoRepository enderecoCompletoRepository)
        {
            _enderecoCompletoRepository = enderecoCompletoRepository;
        }

        public void Dispose()
        {
            _enderecoCompletoRepository.Dispose();
        }
    }
}
