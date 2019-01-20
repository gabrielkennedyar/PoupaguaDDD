using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class EnderecoCompletoService : ServiceBase<EnderecoCompleto>, IEnderecoCompletoService
    {
        private readonly IEnderecoCompletoRepository _enderecoCompletoRepository;

        public EnderecoCompletoService(IEnderecoCompletoRepository enderecoCompletoRepository) : base(enderecoCompletoRepository)
        {
            _enderecoCompletoRepository = enderecoCompletoRepository;
        }
    }
}
