using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class EnderecoDoPredioAppService : AppServiceBase<EnderecoDoPredio>, IEnderecoDoPredioAppService
    {
        private readonly IEnderecoDoPredioService _enderecoDoPredioService;

        public EnderecoDoPredioAppService(IEnderecoDoPredioService enderecoDoPredioService) : base(enderecoDoPredioService)
        {
            _enderecoDoPredioService = enderecoDoPredioService;
        }
    }
}
