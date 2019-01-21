using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class PredioAppService : AppServiceBase<Predio>, IPredioAppService
    {
        private readonly IPredioService _predioService;

        public PredioAppService(IPredioService predioService) : base(predioService)
        {
            _predioService = predioService;
        }
    }
}
