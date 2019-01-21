using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class EnderecoCompletoAppService : AppServiceBase<EnderecoCompleto>, IEnderecoCompletoAppService
    {
        private readonly IEnderecoCompletoService _enderecoCompletoService;

        public EnderecoCompletoAppService(IEnderecoCompletoService enderecoCompletoService) : base(enderecoCompletoService)
        {
            _enderecoCompletoService = enderecoCompletoService;
        }
    }
}
